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
    public partial class Currency : Form, IFormBase
    {
        CurrencyController _currency;
        public Currency()
        {
            InitializeComponent();
            _currency = new CurrencyController();
            currency = new CurrencyModel();

            ClearControl();
            DataBind();
        }
        int id = 0;
        CurrencyModel currency;
        public void ClearControl()
        {
            btnSave.Text = "Save";
            id = 0;
            txtCurrency.Clear();
            txtSymbol.Clear();
            chkIsDefault.Checked = false;
        }

        public void DataBind()
        {
            dgvCurrency.AutoGenerateColumns = false;
            dgvCurrency.DataSource = _currency.GetCurrency(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrency.Text)) return;
            currency.CurrencyId = id;
            currency.Currency = txtCurrency.Text;
            currency.Symbol = txtSymbol.Text;
            currency.IsDefault = chkIsDefault.Checked;

            switch (btnSave.Text)
            {
                case "Save":
                    _currency.Insert(currency);
                    break;
                case "Update":
                    _currency.Update(currency);
                    break;
            }
            ClearControl();
            DataBind();
        }

        private void dgvCurrency_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void dgvCurrency_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCurrency.Columns[dgvCurrency.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                id = Convert.ToInt32(dgvCurrency.Rows[e.RowIndex].Cells["colCurrencyId"].Value);
                txtCurrency.Text = dgvCurrency.Rows[e.RowIndex].Cells["colCurrency"].Value.ToString();
                txtSymbol.Text = dgvCurrency.Rows[e.RowIndex].Cells["colSymbol"].Value.ToString();
                chkIsDefault.Checked = Convert.ToBoolean(dgvCurrency.Rows[e.RowIndex].Cells["colIsDefault"].Value);
                btnSave.Text = "Update";
            }
            else if (colName == "colDel")
            {
                id = Convert.ToInt32(dgvCurrency.Rows[e.RowIndex].Cells["colCurrencyId"].Value);
                if (DialogResult.Yes == MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo))
                {
                    _currency.Delete(id);
                    ClearControl();
                    DataBind();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControl();
        }
    }
}
