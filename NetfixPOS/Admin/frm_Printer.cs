using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using NetfixPOS.Models;

namespace NetfixPOS.Admin
{
    public partial class frm_Printer : KryptonForm
    {
        public frm_Printer()
        {
            InitializeComponent();
            BindPrinterDevice();
            PopulatePrinterListView();
        }
        private void BindPrinterDevice()
        {
            kto_cbo_Printer.Items.Clear();

            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                PrinterSettings printerSettings = new PrinterSettings();
                printerSettings.PrinterName = printerName;

                // Get the printer's device ID
                string deviceID = printerSettings.PrinterName;

                // Add the Printer ID and Name to the ComboBox
                kto_cbo_Printer.Items.Add(new PrinterInfo(deviceID, printerName));
            }

            // Set the ComboBox display and value members
            kto_cbo_Printer.DisplayMember = "DisplayName";
            kto_cbo_Printer.ValueMember = "DeviceID";
        }
        private void PopulatePrinterListView()
        {
            // Clear the ListView in case it was previously populated
            liv_printer.Items.Clear();

            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                PrinterSettings printerSettings = new PrinterSettings();
                printerSettings.PrinterName = printerName;

                // Get the printer's device ID
                string deviceID = printerSettings.PrinterName;

                // Create a ListViewItem with the printer's device ID and name
                ListViewItem item = new ListViewItem(new string[] { deviceID, printerName });

                // Add the ListViewItem to the ListView
                liv_printer.Items.Add(item);
            }
        }
    }

}
