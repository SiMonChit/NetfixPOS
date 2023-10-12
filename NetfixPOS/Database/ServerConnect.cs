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


    }

}

