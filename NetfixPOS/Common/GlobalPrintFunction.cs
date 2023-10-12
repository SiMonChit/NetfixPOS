using Microsoft.Reporting.WinForms;
using NetfixPOS.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetfixPOS.Common
{
    public class GlobalPrintFunction
    {
        public GlobalPrintFunction()
        {
            _sale = new SaleController();
        }
        SaleController _sale;
        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;

        public void Print(string SaleId, string Template, int printQty)
        {
            DataTable slipdata = new DataTable();
            LocalReport report = new LocalReport();

            if (Template == "SlipTemplate.rdlc")
            {
                slipdata = _sale.GetSaleSlip(SaleId);
                string path = Path.GetDirectoryName(Application.ExecutablePath);
                string fullPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\PrintTemplate\SlipTemplate.rdlc";
                report.ReportPath = fullPath;
                report.DataSources.Add(new ReportDataSource("SaleSlip_DataSet", slipdata));
            }
            else if (Template == "A4Voucher.rdlc")
            {

            }
            else if (Template == "A5Voucher.rdlc")
            {

            }

            try
            {
                for (int i = 0; i < printQty; i++)
                {
                    PrintToPrinter(report);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("How many paper your want to print ?", "Print Count", MessageBoxButtons.OK);
            }

        }

        private static void PrintToPrinter(LocalReport report)
        {
            Export(report);
        }

        private static void Export(LocalReport report, bool print = true)
        {
            string deviceInfo =
             @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>3in</PageWidth>
                <PageHeight>8.3in</PageHeight>
                <MarginTop>0in</MarginTop>
                <MarginLeft>0.1in</MarginLeft>
                <MarginRight>0.1in</MarginRight>
                <MarginBottom>0in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;

            if (print)
            {
                Print();
            }
        }
        private static void Print()
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
        private static void PrintPage(object sender, PrintPageEventArgs ev)
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

        private static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        private static void DisposePrint()
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
