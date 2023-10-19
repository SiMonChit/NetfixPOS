using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.DataAccess
{
    public class DataControllerBase
    {
        #region Private Variables
        private bool useTransaction;

        private SqlCommand command;

        private SqlConnection connection;

        //private Database db;

        private SqlTransaction transaction;

        private SqlDataAdapter adapter;
        #endregion


        public DataControllerBase()
        {
            // Create DbConnection object
            //LocalDB
            //this.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MainServerDB"].ConnectionString);
            this.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalDB"].ConnectionString);

        }

        //Transaction Method

        #region Protected Properties

        protected SqlCommand Command
        {
            get
            {
                return this.command;
            }

            set
            {
                this.command = value;
            }
        }


        protected SqlConnection Connection
        {
            get
            {
                return this.connection;
            }

            set
            {
                this.connection = value;
            }
        }


        /// Gets DataBase

        //protected Database DB
        //{
        //    get
        //    {
        //        this.db = DatabaseFactory.CreateDatabase(MainDatabaseConnectionStringName);
        //        return this.db;
        //    }
        //}


        protected SqlTransaction Transaction
        {
            get
            {
                return this.transaction;
            }

            set
            {
                this.transaction = value;
            }
        }

        protected SqlDataAdapter Adapter
        {
            get { return this.adapter; }
            set { this.adapter = value; }
        }
        #endregion   
        public void RollbackTransaction()
        {
            // Check that transaction exists and connection opens
            if ((this.Transaction != null) && (this.Connection.State == ConnectionState.Open))
            {
                // Rollback transaction
                this.Transaction.Rollback();

                // Check that connection open
                if (this.Connection.State == ConnectionState.Open)
                {
                    // Close connection
                    this.Connection.Close();
                }

                // Remove transaction
                this.useTransaction = false;
            }
        }

        public void StartTransaction()
        {
            // Check that connection is close
            if (this.Connection.State == ConnectionState.Closed)
            {
                // Open connection
                this.Connection.Open();
            }

            // Create transaction
            this.Transaction = this.Connection.BeginTransaction();
            this.useTransaction = true;
        }

        public void CommitTransaction()
        {
            // Check that transaction exists and connection opens
            if ((this.Transaction != null) && (this.Connection.State == ConnectionState.Open))
            {
                // Commit transaction
                this.Transaction.Commit();

                // Check that connection open
                if (this.Connection.State == ConnectionState.Open)
                {
                    // Close connection
                    this.Connection.Close();
                }

                // Remove transaction
                this.useTransaction = false;
            }
        }
    }
}
