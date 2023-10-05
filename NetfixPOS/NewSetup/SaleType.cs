using NetfixPOS.Common;
using NetfixPOS.Controller;
using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetfixPOS.NewSetup
{
    public partial class SaleType : Form, IFormBase
    {
        public SaleType()
        {
            InitializeComponent();
            _saleType = new SaleTypeController();
            saleType = new SaleTypeModel();
            DataBind();
        }
        SaleTypeController _saleType;
        SaleTypeModel saleType;
        int id = 0;
        public void ClearControl()
        {
            txtSaleType.Clear();
            id = 0;
            btnSave.Text = "Save";
        }

        public void DataBind()
        {
            dgvSaleType.AutoGenerateColumns = false;
            dgvSaleType.DataSource = _saleType.GetSaleType();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saleType.SaleTypeName = txtSaleType.Text;
            switch (btnSave.Text)
            {
                case "Save":
                    _saleType.Insert(saleType);
                    break;

                case "Update":
                    _saleType.Update(saleType);
                    break;
            }
            ClearControl();
            DataBind();
        }

        private void dgvSaleType_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }
    }
}
