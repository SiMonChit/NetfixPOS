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
    public partial class Users : Form, IFormBase
    {
        private UsersController _users;
        private UsersModel users;

        public Users()
        {
            InitializeComponent();
            users = new UsersModel();
            _users = new UsersController();

            DataBind();
        }
        int id = 0;
        public void ClearControl()
        {
            picUser.Image = null;
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            id = 0;
            btnSave.Text = "Save";
        }

        public void DataBind()
        {
            dgvUser.AutoGenerateColumns = false;
            dgvUser.DataSource = _users.GetUsers(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text)) return;
            users.UserID = id;
            users.UserImage = GlobalFunction.ConvertImageToBinary(picUser.Image);
            users.UserName = txtUserName.Text;
            users.Email = txtEmail.Text;
            users.Phone = txtPhone.Text;
            users.Password = txtPassword.Text;
            users.Password_Salt = txtPassword.Text;
            switch (btnSave.Text)
            {
                case "Save":
                    _users.Insert(users);
                    GlobalFunction.WriteLog("User Form " + " Insert User " + users.UserName);
                    break;
                   
                case "Update":
                    _users.Update(users);
                    GlobalFunction.WriteLog("User Form " + " Update User " + users.UserName);
                    break;
            }
            ClearControl();
            DataBind();
        }

        private void dgvUser_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "User Image";
            openFile.Filter = "Images (*.BMP;*.JPG;,*.PNG)|*.BMP;*.JPG;*.PNG|" + "All files (*.*)|*.*";
            DialogResult dr = openFile.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                picUser.Image = Bitmap.FromFile(openFile.FileName);
                picUser.SizeMode = PictureBoxSizeMode.StretchImage;
                picUser.Refresh();
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[dgvUser.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                id = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["colUserId"].Value);
                txtUserName.Text = dgvUser.Rows[e.RowIndex].Cells["colUserName"].Value.ToString();
                txtEmail.Text = dgvUser.Rows[e.RowIndex].Cells["colEmail"].Value != DBNull.Value ? Convert.ToString(dgvUser.Rows[e.RowIndex].Cells["colEmail"].Value) : "";

                txtPhone.Text = dgvUser.Rows[e.RowIndex].Cells["colPhone"].Value != DBNull.Value ? Convert.ToString(dgvUser.Rows[e.RowIndex].Cells["colPhone"].Value) : "";
                txtPassword.Text = dgvUser.Rows[e.RowIndex].Cells["colPassword"].Value.ToString();
                Byte[] data = new Byte[0];
                data = (Byte[])(dgvUser.Rows[e.RowIndex].Cells["colUsersImage"].Value);
                MemoryStream mem = new MemoryStream(data);
                picUser.Image = Image.FromStream(mem);
                btnSave.Text = "Update";
            }
            else if (colName == "colDel")
            {
                id = Convert.ToInt32(dgvUser.Rows[e.RowIndex].Cells["colUserId"].Value);
                if (DialogResult.Yes == MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo))
                {
                    _users.Delete(id);
                    ClearControl();
                    DataBind();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControl();
            GlobalFunction.WriteLog("User Form " + " New Button Click");
        }
    }
}
