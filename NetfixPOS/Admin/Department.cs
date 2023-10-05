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

namespace NetfixPOS.Admin
{
    public partial class Department : Form, IFormBase
    {
        public Department()
        {
            InitializeComponent();
            _department = new DepartmentController();
            department = new DepartmentModel();

            ClearControl();
            DataBind();
        }
        DepartmentController _department;
        DepartmentModel department;
        int id = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepartment.Text)) return;

            department.DepartmentId = id;
            department.DepartmentName = txtDepartment.Text;
            department.CreatedDate = DateTime.Now;
            switch (btnSave.Text)
            {
                case "Save":
                    _department.Insert(department);
                    break;

                case "Update":
                    _department.Update(department);
                    break;
            }
            ClearControl();
            DataBind();
        }

        public void ClearControl()
        {
            txtDepartment.Clear();
            btnSave.Text = "Save";
            id = 0;
        }

        public void DataBind()
        {
            dgvDepartment.AutoGenerateColumns = false;
            dgvDepartment.DataSource = _department.GetDepartment(0);
        }

        private void dgvDepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvDepartment.Columns[dgvDepartment.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                id = Convert.ToInt32(dgvDepartment.Rows[e.RowIndex].Cells["colDepartmentId"].Value);
                txtDepartment.Text = dgvDepartment.Rows[e.RowIndex].Cells["colDepartmentName"].Value.ToString();
                btnSave.Text = "Update";
            }
            else if (colName == "colDel")
            {
                id = Convert.ToInt32(dgvDepartment.Rows[e.RowIndex].Cells["colDepartmentId"].Value);
                if (DialogResult.Yes == MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo))
                {
                    _department.Delete(id);
                    ClearControl();
                    DataBind();
                }
            }
        }

        private void dgvDepartment_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }
    }
}
