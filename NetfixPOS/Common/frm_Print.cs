﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Reporting.WinForms;
using NetfixPOS.Controller;
using NetfixPOS.Models;

namespace NetfixPOS.Common
{
    public partial class frm_Print : KryptonForm
    {
        public frm_Print()
        {
            InitializeComponent();
            GetTemplateFile();
            BindPrinterDevice();
        }
        public frm_Print(string SaleId)
        {
            InitializeComponent();
            GetTemplateFile();
            BindPrinterDevice();
            saleid = SaleId;
            _sale = new SaleController();
        }
        SaleController _sale;
        string saleid = "";
        private void BindPrinterDevice()
        {
            cboPrinter.Items.Clear();

            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                PrinterSettings printerSettings = new PrinterSettings();
                printerSettings.PrinterName = printerName;
                string deviceID = printerSettings.PrinterName;
                cboPrinter.Items.Add(new PrinterInfo(deviceID, printerName));
            }
            cboPrinter.DisplayMember = "DisplayName";
            cboPrinter.ValueMember = "DeviceID";
        }
        private void GetTemplateFile()
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string folderPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\PrintTemplate";

            if (Directory.Exists(folderPath))
            {
                string[] rdlcFiles = Directory.GetFiles(folderPath, "*.rdlc");
                List<string> rdlcFileNames = new List<string>();
                foreach (string filePath in rdlcFiles)
                {
                    rdlcFileNames.Add(Path.GetFileName(filePath));
                }
                cboTemplate.Items.AddRange(rdlcFileNames.ToArray());
            }
            else
            {
                MessageBox.Show("Folder does not exist.");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(saleid);
            this.Close();
        }
        private void Print(string SaleId)
        {
            DataTable slipdata = new DataTable();
            LocalReport report = new LocalReport();

            if (cboTemplate.Text == "SlipTemplate.rdlc")
            {
                slipdata = _sale.GetSaleSlip(SaleId);
                string path = Path.GetDirectoryName(Application.ExecutablePath);
                string fullPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 10) + @"\PrintTemplate\SlipTemplate.rdlc";
                report.ReportPath = fullPath;
                report.DataSources.Add(new ReportDataSource("SaleSlip_DataSet", slipdata));
            }
            else if(cboTemplate.Text == "A4Voucher.rdlc")
            {

            }
            else if (cboTemplate.Text == "A5Voucher.rdlc")
            {

            }

            try
            {
                int printQty = Convert.ToInt32(txtPrintQty.Text);
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
        private static List<Stream> m_streams;
        private static int m_currentPageIndex = 0;

        public static void PrintToPrinter(LocalReport report)
        {
            Export(report);
        }

        public static void Export(LocalReport report, bool print = true)
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

        public static void Print()
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
        public static void PrintPage(object sender, PrintPageEventArgs ev)
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

        public static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void DisposePrint()
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
