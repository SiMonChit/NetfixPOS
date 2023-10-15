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

namespace NetfixPOS.Main
{
    public partial class LoginPage : KryptonForm
    {
        public LoginPage()
        {
            InitializeComponent();
            _user = new UsersController();
            app_check = new App_Information_Check();
            _permission = new UserPermissionController();
            _generate = new AutoGenerateController();
            UserDataBind();
        }
        UsersController _user;
        UserPermissionController _permission;
        AutoGenerateController _generate;
        private App_Information_Check app_check;
        private bool CheckRequireFill()
        {
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please fill your password :", "Login", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void UserDataBind()
        {
            cboUsers.DataSource = _user.GetUsers(0);
            cboUsers.DisplayMember = "UserName";
            cboUsers.ValueMember = "UserID";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckRequireFill())
            {
                try
                {
                    GlobalFunction.LoginUser = _user.UsersLogin(cboUsers.Text, txtPassword.Text);
                    GlobalFunction.LoginUser_Permission = _permission.GetPermission(GlobalFunction.LoginUser.UserID);
                    app_check.Check_IsRegister();
                    GlobalFunction.appInfo = _generate.GetAppInfo();
                    MainForm mainForm = new MainForm();
                    MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK);
                    this.Hide();
                    mainForm.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK);
                }

            }
        }
    }
}
