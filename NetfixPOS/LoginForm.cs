using NetfixPOS.Common;
using NetfixPOS.Controller;
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

namespace NetfixPOS
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
            _user = new UsersController();
            app_check = new App_Information_Check();
            _permission = new UserPermissionController();
            _generate = new AutoGenerateController();
        }
        UsersController _user;
        UserPermissionController _permission;
        AutoGenerateController _generate;
        private App_Information_Check app_check;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckRequireFill()
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please fill your username :", "Login", MessageBoxButtons.OK);
                return false;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please fill your password :", "Login", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckRequireFill())
            {
                try
                {
                    GlobalFunction.LoginUser = _user.UsersLogin(txtUserName.Text, txtPassword.Text);
                    GlobalFunction.LoginUser_Permission = _permission.GetPermission(GlobalFunction.LoginUser.UserID);
                    app_check.Check_IsRegister();
                    GlobalFunction.appInfo = _generate.GetAppInfo();

                    MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK);
                }
                
            }
        }
    }
}
