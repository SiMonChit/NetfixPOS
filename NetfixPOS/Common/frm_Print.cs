using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
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
            string folderPath = @"D:\PrintTemplate";
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

        }
    }
}
