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
    public partial class Customer : Form, IFormBase
    {
        public Customer()
        {
            InitializeComponent();
            _customer = new CustomerController();
            customer = new CustomerModel();
            DataBind();
        }
        private CustomerController _customer;
        CustomerModel customer;
        int id = 0;
        private void dgvCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            customer.CustomerId = id;
            customer.CustomerName = txtCustomerName.Text;
            customer.Email = txtEmail.Text;
            customer.Phone = txtPhone.Text;
            customer.CurrentAddress = txtCurrentAddress.Text;
            customer.IsDefault = chkIsDefault.Checked;

            switch (btnSave.Text)
            {
                case "Save":
                    _customer.Insert(customer);
                    GlobalFunction.WriteLog("Customer SaveButton Click " + customer.CustomerName);
                    break;

                case "Update":
                    _customer.Update(customer);
                    break;
            }
            ClearControl();
            DataBind();
        }

        public void ClearControl()
        {
            txtCurrentAddress.Clear();
            txtCustomerName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            btnSave.Text = "Save";
            id = 0;
        }

        public void DataBind()
        {
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = _customer.GetCustomer(0);
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[dgvCustomer.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                id = Convert.ToInt32(dgvCustomer.Rows[e.RowIndex].Cells["colCustomerId"].Value);
                txtCustomerName.Text = dgvCustomer.Rows[e.RowIndex].Cells["colCustomerName"].Value.ToString();
                txtEmail.Text = dgvCustomer.Rows[e.RowIndex].Cells["colEmail"].Value.ToString();
                txtPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells["colPhone"].Value.ToString();
                txtCurrentAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells["colCurrentAddress"].Value.ToString();
                chkIsDefault.Checked = Convert.ToBoolean(dgvCustomer.Rows[e.RowIndex].Cells["colIsDefault"].Value);

                btnSave.Text = "Update";
            }
            else if (colName == "colDel")
            {
                id = Convert.ToInt32(dgvCustomer.Rows[e.RowIndex].Cells["colCustomerId"].Value);
                if (DialogResult.Yes == MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo))
                {
                    _customer.Delete(id);
                    ClearControl();
                    DataBind();
                }
            }
        }
    }
}
