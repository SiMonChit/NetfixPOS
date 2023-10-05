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
using NetfixPOS.Models;

namespace NetfixPOS.NewSetup
{
    public partial class frm_Supplier : KryptonForm, IFormBase
    {
        public frm_Supplier()
        {
            InitializeComponent();
            _supplier = new SupplierController();
            supplier = new SupplierModel();

            ClearControl();
            DataBind();
        }
        int id = 0;
        SupplierController _supplier;
        SupplierModel supplier;
        public void ClearControl()
        {
            txtSupplierName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            btnSave.Text = "Save";
            id = 0;
        }

        public void DataBind()
        {
            dgvSupplier.AutoGenerateColumns = false;
            dgvSupplier.DataSource = _supplier.GetSupplier(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            supplier.SupplierId = id;
            supplier.SupplierName = txtSupplierName.Text;
            supplier.Email = txtEmail.Text;
            supplier.Phone = txtPhone.Text;
            supplier.CurrentAddress = txtAddress.Text;

            switch (btnSave.Text)
            {
                case "Save":
                    _supplier.Insert(supplier);
                    GlobalFunction.WriteLog("Supplier : SaveButton Click " + supplier.SupplierName);
                    break;

                case "Update":
                    _supplier.Update(supplier);
                    GlobalFunction.WriteLog("Supplier : UpdateButton Click " + supplier.SupplierName);
                    break;
            }
            ClearControl();
            DataBind();
        }

        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSupplier.Columns[dgvSupplier.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                id = Convert.ToInt32(dgvSupplier.Rows[e.RowIndex].Cells["colSupplierId"].Value);
                txtSupplierName.Text = dgvSupplier.Rows[e.RowIndex].Cells["colSupplierName"].Value.ToString();
                txtEmail.Text = dgvSupplier.Rows[e.RowIndex].Cells["colEmail"].Value.ToString();
                txtPhone.Text = dgvSupplier.Rows[e.RowIndex].Cells["colPhone"].Value.ToString();
                txtAddress.Text = dgvSupplier.Rows[e.RowIndex].Cells["colCurrentAddress"].Value.ToString();
                GlobalFunction.WriteLog("Supplier : EditButton Click " + txtSupplierName.Text);
                btnSave.Text = "Update";
            }
            else if (colName == "colDel")
            {
                id = Convert.ToInt32(dgvSupplier.Rows[e.RowIndex].Cells["colSupplierId"].Value);

                txtSupplierName.Text = dgvSupplier.Rows[e.RowIndex].Cells["colSupplierName"].Value.ToString();
                GlobalFunction.WriteLog("Supplier : DeleteButton Click " + txtSupplierName.Text);

                if (DialogResult.Yes == MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo))
                {
                    _supplier.Delete(id);
                    ClearControl();
                    DataBind();
                }
            }
        }

        private void dgvSupplier_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }
    }
}
