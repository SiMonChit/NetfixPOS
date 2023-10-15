using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using NetfixPOS.Common;
using NetfixPOS.Controller;
using NetfixPOS.Models;
using NetfixPOS.Models.DataSetFile;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using OfficeOpenXml;
using BorderStyle = NPOI.SS.UserModel.BorderStyle;
using HorizontalAlignment = NPOI.SS.UserModel.HorizontalAlignment;

namespace NetfixPOS.Purchase
{
    public partial class frm_ImportPurchase : KryptonForm
    {
        public frm_ImportPurchase()
        {
            InitializeComponent();
            _purchase = new PurchaseController();
            purchasetb = new ds_Purchase.tbl_PurchaseDataTable();
        }
        string selectedFolderPath = "";
        PurchaseController _purchase;
        ds_Purchase.tbl_PurchaseDataTable purchasetb;
        private List<PurchaseModel> GetPurchaseItems()
        {
            List<PurchaseModel> purchaseItems = new List<PurchaseModel>
            {
                new PurchaseModel { StockName = "ItemName", PurchasePrice = 10.0m, Qty = 5, Amount = 50.0m },
            };

            return purchaseItems;
        }

        private void btnCreateExcelFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog
            {
                SelectedPath = "C:\\Users\\UserName\\Documents", // Set your desired initial directory
                Description = "Select destination folder for the Excel template", // Dialog description
            };

            DialogResult dialogResult = folderDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string destinationFolder = folderDialog.SelectedPath;
                string destinationPath = Path.Combine(destinationFolder, "PurchaseItem.xlsx");

                try
                {
                    List<PurchaseModel> purchaseItem = new List<PurchaseModel>();

                    ExportToExcel(purchaseItem, destinationPath);
                    MessageBox.Show("Excel template created successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while copying the Excel template:" + Environment.NewLine + ex.Message);
                }
            }
        }
        private void ExportToExcel(List<PurchaseModel> purchaseItem, string filePath)
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet worksheet = workbook.CreateSheet("Sheet1");

            // Set column widths for specific columns
            worksheet.SetColumnWidth(0, 15 * 256); // Column 0 (StockName), 15 characters
            worksheet.SetColumnWidth(1, 15 * 256); // Column 1 (PurchasePrice), 15 characters
            worksheet.SetColumnWidth(2, 10 * 256); // Column 2 (Qty), 10 characters
            worksheet.SetColumnWidth(3, 15 * 256); // Column 3 (Amount), 15 characters


            IRow headerRow = worksheet.CreateRow(0);

            XSSFCellStyle headerStyle = (XSSFCellStyle)workbook.CreateCellStyle();
            headerStyle.Alignment = HorizontalAlignment.Center;
            headerStyle.BorderBottom = BorderStyle.Thin;
            headerStyle.BorderLeft = BorderStyle.Thin;
            headerStyle.BorderRight = BorderStyle.Thin;
            headerStyle.BorderTop = BorderStyle.Thin;

            // Create header cells
            string[] columnNames = new string[]
            {
                "StockName", "PurchasePrice", "Qty", "Amount"
            };

            for (int i = 0; i < columnNames.Length; i++)
            {
                ICell headerCell = headerRow.CreateCell(i);
                headerCell.SetCellValue(columnNames[i]);
                headerCell.CellStyle = headerStyle;
            }

            // Populate data rows
            for (int i = 0; i < purchaseItem.Count; i++)
            {
                PurchaseModel pur_Item = purchaseItem[i];
                IRow row = worksheet.CreateRow(i + 1);
                string[] cellValues = new string[]
                {
                    pur_Item.StockName,
                    pur_Item.PurchasePrice.ToString(),
                    pur_Item.Qty.ToString(),
                    pur_Item.Amount.ToString()
                };

                for (int j = 0; j < cellValues.Length; j++)
                {
                    ICell cell = row.CreateCell(j);
                    cell.SetCellValue(cellValues[j]);
                }
            }

            // Save the Excel file
            using (FileStream fileStream = File.Create(filePath))
            {
                workbook.Write(fileStream);
            }
        }

        private void btnOpenExcelFile_Click(object sender, EventArgs e)
        {
            OpenExcelFile();
        }
        private void OpenExcelFile()
        {
            string FilePath;
            OpenFileDialog ofdExcel = new OpenFileDialog();

            ofdExcel.FileName = "";
            ofdExcel.Filter = "Excel WorkBook|*.xlsx";
            ofdExcel.ShowDialog();
            FilePath = ofdExcel.FileName;

            if (FilePath == "")
                return;

            string connStr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", FilePath);
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                conn.Open();
                string selectQuery = "SELECT * FROM [Sheet1$]";
                using (OleDbCommand cmd = new OleDbCommand(selectQuery, conn))
                {
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvPurchaseItem.DataSource = dt;
                    }
                }
            }
        }

        private void dgvPurchaseItem_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPurchaseItem.Rows)
            {
                ds_Purchase.tbl_PurchaseRow purchaseRow = purchasetb.Newtbl_PurchaseRow();
                purchaseRow.StockName = row.Cells[0].Value.ToString();
                purchaseRow.PurchasePrice = Convert.ToDecimal(row.Cells[1].Value);
                purchaseRow.Qty = Convert.ToInt32(row.Cells[2].Value);
                purchaseRow.Amount = Convert.ToDecimal(row.Cells[3].Value);
                purchaseRow.Pur_Date = DateTime.Now;
                purchaseRow.UserID = 1;
                _purchase.InsertFromExcel(purchaseRow);
            }
            dgvPurchaseItem.DataSource = null;
            MessageBox.Show("Insert successful", "Purchase ImportExcel", MessageBoxButtons.OK);
        }
        private void CheckValidate()
        {
            foreach (DataGridViewRow row in dgvPurchaseItem.Rows)
            {

            }
        }
    }
}
