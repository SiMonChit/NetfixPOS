using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using NetfixPOS.Common;
using NetfixPOS.Controller;

namespace NetfixPOS.Sales
{
    public partial class frm_SaleList : KryptonForm
    {
        public frm_SaleList()
        {
            InitializeComponent();
            _sale = new SaleController();
        }
        SaleController _sale;
        string SaleId = "";
        private void dgvSaleHeaderList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvSaleHeaderList.AutoGenerateColumns = false;
            dgvSaleHeaderList.DataSource = _sale.SaleHeaderSelectByDate(dtp_FromDate.Value, dtp_ToDate.Value);
        }

        private void dgvSaleHeaderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
