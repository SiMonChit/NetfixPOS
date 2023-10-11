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
using System.Data.SqlClient;
using System.Configuration;
using NetfixPOS.Common;

namespace NetfixPOS.Database
{
    public partial class ServerConnect : KryptonForm
    {
        public ServerConnect()
        {
            InitializeComponent();
        }
        string serverName;
        public SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
        //private string GetLocalSqlServerInstanceName()
        //{
        //    string serverName = string.Empty;

        //    try
        //    {
        //        DataTable instances = SmoApplication.EnumAvailableSqlServers(true);
        //        if (instances.Rows.Count > 0)
        //        {
        //            txtServerName.Text = instances.Rows[0]["Name"].ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error getting server name: " + ex.Message);
        //    }

        //    return serverName;
        //}

        private void DatabaseBind()
        {
            string serverName = txtServerName.Text;

            if (!string.IsNullOrEmpty(serverName))
            {
                string connectionString = $"Data Source={serverName};Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to retrieve the list of database names
                    string query = "SELECT name FROM sys.databases WHERE database_id > 4";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string dbName = reader["name"].ToString();
                                cboDatabase.Items.Add(dbName);
                            }
                        }
                    }
                }
            }
        }


        private string constr;


        public void GetServerConnection()
        {
            string[] tmpserver;
            string[] tmpDatabase1;
            string[] tmpDatabase2;
            string[] tmpUser1;
            string[] tmpUser2;
            string[] tmpPassword1;
            string[] tmpPassword2;
            string DBType = "";

            DBType = AppConfiguration.ReadProviderName();
            constr = AppConfiguration.ReadConnectionString();

            if (DBType == "System.Data.SqlClient")
            {
                
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
                txtPassword.Visible = true;

                tmpserver = constr.Split("Data Source=");
                txtServerName.Enabled = true;
                txtServerName.Text = tmpserver[1];

                tmpDatabase1 = constr.Split("Initial Catalog=");
                tmpDatabase2 = tmpDatabase1[1].Split(";");
                cboDatabase.Items.Add(tmpDatabase2[0]);
                cboDatabase.SelectedIndex = 0;

                tmpUser1 = constr.Split("User ID=");
                if (tmpUser1.Length > 1)
                {
                    tmpUser2 = tmpUser1[1].Split(";");
                    if (!string.IsNullOrEmpty(tmpUser2[0]))
                    {
                        string str = tmpUser2[0];
                        txtUserName.Enabled = true;
                        txtUserName.ReadOnly = false;
                        txtUserName.Text = str;
                        rbtSQL.Checked = true;
                        rbtWindow.Checked = false;
                    }
                    else
                    {
                        rbtSQL.Checked = false;
                        rbtWindow.Checked = true;
                    }
                }

                tmpPassword1 = constr.Split("Password=");
                if (tmpPassword1.Length > 1)
                {
                    tmpPassword2 = tmpPassword1[1].Split(";");
                    if (!string.IsNullOrEmpty(tmpPassword2[0]))
                    {
                        txtPassword.Text = tmpPassword2[0];
                    }
                }
            }
        }
    }

}

