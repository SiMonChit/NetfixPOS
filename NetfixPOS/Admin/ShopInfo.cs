using NetfixPOS.Common;
using NetfixPOS.Controller;
using NetfixPOS.Models;
using NetfixPOS.Models.DataSetFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetfixPOS.Admin
{
    public partial class ShopInfo : Form
    {
        public ShopInfo()
        {
            InitializeComponent();
            _shop = new ShopController();
            shop = new ShopModel();
            general = new GeneralModel();
            _generate = new AutoGenerateController();
            ShopDataBind();
            SoftwareInfoDataBind();

        }
        ShopController _shop;
        ShopModel shop;
        GeneralModel general;
        AutoGenerateController _generate;
        int id = 0, General_Id = 0;
        private void SoftwareInfoDataBind()
        {
            dgvSoftwareInfo.AutoGenerateColumns = false;
            dgvSoftwareInfo.DataSource = _generate.GetAppInfo();
        }
        private void ShopDataBind()
        {
            int IsRegister = 0;
            IsRegister = _shop.Check_IsRegister();
            if (IsRegister != 0)
            {
                ds_ShopInfo.ShopInfoRow infoRow = _shop.Select();
                txtShopName.Text = infoRow.ShopName;
                txtPhoneNo.Text = infoRow.PhoneNo;
                txtEmail.Text = infoRow.Email;
                txtAddress.Text = infoRow.CurrentAddress;
                picLogo.Image = GlobalFunction.ConvertByteArrayToImage(infoRow.ShopImage);
            }
            else
            {
                btnShopUpdate.Text = "Save";
            }
        }
        public void ClearControl()
        {
            id = 0;
            General_Id = 0;
            btnSave.Text = "Save";
            txtDiscount.Clear();
            txtService.Clear();
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "Shop Logo";
            openFile.Filter = "Images (*.BMP;*.JPG;,*.PNG)|*.BMP;*.JPG;*.PNG|" + "All files (*.*)|*.*";
            DialogResult dr = openFile.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                picLogo.Image = Bitmap.FromFile(openFile.FileName);
                picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                picLogo.Refresh();
            }
        }

        private void btnShopUpdate_Click(object sender, EventArgs e)
        {
            shop.ShopId = id;
            shop.ShopName = txtShopName.Text;
            shop.PhoneNo = txtPhoneNo.Text;
            shop.Email = txtEmail.Text;
            shop.CurrentAddress = txtAddress.Text;
            shop.ShopLogo = GlobalFunction.ConvertImageToBinary(picLogo.Image);
            switch (btnShopUpdate.Text)
            {
                case "Save":
                    _shop.Insert(shop);
                    break;
            }
            ShopDataBind();
            MessageBox.Show("Save successful", txtShopName.Text, MessageBoxButtons.OK);
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtService.Text)) return;
            if (string.IsNullOrEmpty(txtDiscount.Text)) return;

            general.General_Id = General_Id;
            general.ShopId = id;
            general.SaleDate = dtpSaleDate.Value;
            general.ServiceTax = Convert.ToDecimal(txtService.Text);
            general.InvDiscount = Convert.ToDecimal(txtDiscount.Text);

            switch (btnSave.Text)
            {
                case "Save":

                    break;

                case "Update":
                    _generate.AppInfo_Update(general);
                    GlobalFunction.WriteLog("Shop Info " + " Update Button Click");
                    break;
            }
            
            ClearControl();
        }

        private void dgvSoftwareInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSoftwareInfo.Columns[dgvSoftwareInfo.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                General_Id = Convert.ToInt32(dgvSoftwareInfo.Rows[e.RowIndex].Cells["colGeneral_Id"].Value);
                dtpSaleDate.Value = Convert.ToDateTime(dgvSoftwareInfo.Rows[e.RowIndex].Cells["colSaleDate"].Value);
                txtService.Text = dgvSoftwareInfo.Rows[e.RowIndex].Cells["colServiceTax"].Value.ToString();
                txtDiscount.Text = dgvSoftwareInfo.Rows[e.RowIndex].Cells["colInvDiscount"].Value.ToString();
                GlobalFunction.WriteLog("Shop Info " + " Edit Button Click ShopInfo GridView");
                btnSave.Text = "Update";
            }
        }
    }
}
