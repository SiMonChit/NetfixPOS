using NetfixPOS.Common;
using NetfixPOS.Controller;
using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetfixPOS.Admin
{
    public partial class Employee : Form, IFormBase
    {
        public Employee()
        {
            InitializeComponent();
            _employee = new EmployeeController();
            employee = new EmployeeModel();
            _department = new DepartmentController();

            DepartmentDataBind();
            ClearControl();
            DataBind();
        }
        EmployeeController _employee;
        DepartmentController _department;
        EmployeeModel employee;
        int empid = 0;
        private void DepartmentDataBind()
        {
            cboDepartment.DataSource = _department.GetDepartment(0);
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "DepartmentId";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "User Image";
            openFile.Filter = "Images (*.BMP;*.JPG;,*.PNG)|*.BMP;*.JPG;*.PNG|" + "All files (*.*)|*.*";
            DialogResult dr = openFile.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                picEmployee.Image = Bitmap.FromFile(openFile.FileName);
                picEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
                picEmployee.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employee.EmpId = empid;
            employee.EmpName = txtEmployeeName.Text;
            employee.EmpImage = GlobalFunction.ConvertImageToBinary(picEmployee.Image);
            employee.EnrollNumber = txtEnrollNumber.Text;
            employee.PhoneNo = txtPhoneNo.Text;
            employee.DepartmentId = Convert.ToInt32(cboDepartment.SelectedValue);
            if (rdoMale.Checked)
            {
                employee.Gender = rdoMale.Checked;
            }
            else
            {
                employee.Gender = rdoFemale.Checked;
            }
            employee.BirthPlace = txtBirthPlace.Text;
            employee.JoinDate = dtpJoinDate.Value;

            switch (btnSave.Text)
            {
                case "Save":
                    _employee.Insert(employee);
                    GlobalFunction.WriteLog("Employee : SaveButton Click " + txtEmployeeName.Text);
                    break;

                case "Update":
                    _employee.Update(employee);
                    GlobalFunction.WriteLog("Employee : UpdateButton Click " + txtEmployeeName.Text);
                    break;
            }
            ClearControl();
            DataBind();

        }

        private void dgvUser_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            rdoFemale.Checked = false;

        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {
            rdoMale.Checked = false;
        }

        public void ClearControl()
        {
            txtEnrollNumber.Clear();
            txtEmployeeName.Clear();
            txtBirthPlace.Clear(); txtPhoneNo.Clear();
            rdoFemale.Checked = false; rdoMale.Checked = false;
            picEmployee.Image = null;
            empid = 0; btnSave.Text = "Save";
        }

        public void DataBind()
        {
            dgvEmployee.AutoGenerateColumns = false;
            dgvEmployee.DataSource = _employee.GetEmpList(0);
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployee.Columns[dgvEmployee.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                empid = Convert.ToInt32(dgvEmployee.Rows[e.RowIndex].Cells["colEmpId"].Value);
                txtEnrollNumber.Text = dgvEmployee.Rows[e.RowIndex].Cells["colEnrollNumber"].Value.ToString();
                txtEmployeeName.Text = dgvEmployee.Rows[e.RowIndex].Cells["colEmpName"].Value.ToString();
                
                txtPhoneNo.Text = dgvEmployee.Rows[e.RowIndex].Cells["colPhoneNo"].Value.ToString();
                txtBirthPlace.Text = dgvEmployee.Rows[e.RowIndex].Cells["colBirthPlace"].Value.ToString();
                cboDepartment.SelectedValue = dgvEmployee.Rows[e.RowIndex].Cells["colDepartmentId"].Value.ToString();
                dtpJoinDate.Value = Convert.ToDateTime(dgvEmployee.Rows[e.RowIndex].Cells["colJoinDate"].Value);
                bool gender = dgvEmployee.Rows[e.RowIndex].Cells["colGender"].Value != DBNull.Value ? Convert.ToBoolean(dgvEmployee.Rows[e.RowIndex].Cells["colGender"].Value) : false;
                if (gender)
                {
                    rdoMale.Checked = gender;
                }
                else
                {
                    rdoFemale.Checked = gender;
                }
                Byte[] data = new Byte[0];
                data = (Byte[])(dgvEmployee.Rows[e.RowIndex].Cells["colEmpImage"].Value);
                MemoryStream mem = new MemoryStream(data);
                picEmployee.Image = Image.FromStream(mem);

                GlobalFunction.WriteLog("Employee : EditButton Click " + txtEmployeeName.Text);
                btnSave.Text = "Update";
            }
            else if (colName == "colDel")
            {
                empid = Convert.ToInt32(dgvEmployee.Rows[e.RowIndex].Cells["colEmpId"].Value);

                _employee.Delete(empid);
                txtEnrollNumber.Text = dgvEmployee.Rows[e.RowIndex].Cells["colEnrollNumber"].Value.ToString();

                GlobalFunction.WriteLog("Employee : DeleteButton Click " + txtEmployeeName.Text);

                ClearControl();
                DataBind();
            }
        }
    }
}
