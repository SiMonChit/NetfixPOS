using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing;
using NetfixPOS.Controller;
using NetfixPOS.Models;

namespace NetfixPOS.Common
{
    class GlobalPrinter : IDisposable
    {

        /// <summary>
        ///  Use for Slip Printer (width 3 in ),Need update for other printer
        /// </summary>
        private int m_currentPageIndex;
        private IList<Stream> m_streams;
        string InvId = null;
        string type = null;

        // Routine to provide to the report renderer, in order to
        //    save an image for each page of the report.
        public GlobalPrinter(string _InvId, string _type)
        {
            InvId = _InvId;
            type = _type;
            Run();
        }
        private Stream CreateStream(string name,
          string fileNameExtension, Encoding encoding,
          string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }
        // Export the given report as an EMF (Enhanced Metafile) file.
        private void Export(LocalReport report)
        {
            //< PageHeight > 11in</ PageHeight >
            string deviceInfo =
           @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>3in</PageWidth>               
                <MarginTop>0.0in</MarginTop>
                <MarginLeft>0.0in</MarginLeft>
                <MarginRight>0.0in</MarginRight>
                <MarginBottom>0.0in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }
        // Handler for PrintPageEvents
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }
        // Create a local report for Report.rdlc, load the data,
        // Export the report to an .emf file, and print it.
        private void Run()
        {

            try
            {

                DataTable dt = new DataTable();
                SaleController s_contol = new SaleController();
                AutoGenerateController G_controller = new AutoGenerateController();


                //string receiptno = G_controller.GetGenerateNo("Receipt");
                dsSaleSetup.SaleHeaderSlipRow InvRow = s_contol.SaleHeaderSlipSelectById(InvId);

                dt = s_contol.GetSaleSlip(InvId);

                //   xsdSaleReport.Invoice_ReportRow invrow= s_contol.InvoiceSelectById("");
                ReportParameter[] param = new ReportParameter[5];
                param[0] = new ReportParameter("pReceiptNo", "receiptno");
                param[1] = new ReportParameter("pInvNo", InvRow.InvNo);
                param[2] = new ReportParameter("pCusName", InvRow.CustomerName);
                param[3] = new ReportParameter("pTotalAmount", InvRow.TotalAmount.ToString("#,##0"));
                param[4] = new ReportParameter("pDate", InvRow.InvDate.ToString("dd/MMM/yyyy"));
                //ToString());
                ////////////////////////////////
                ///
                /// 

                ///
                LocalReport report = new LocalReport
                {
                    ReportPath = @"..\..\rdlc_File\ReceiptReport.rdlc"
                };
                report.DataSources.Add(
                   new ReportDataSource("Sales", dt));
                report.SetParameters(param);
                Export(report);
                Print();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }


        }

        public void Dispose()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }
    }
}
