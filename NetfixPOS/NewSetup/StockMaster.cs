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
    public partial class StockMaster : Form
    {
        public StockMaster()
        {
            InitializeComponent();
            _category = new CategoryController();
            _stock = new StockMasterController();
            trvCategory.AfterSelect += trvCategory_AfterSelect;
            PopulateTreeView();
        }
        CategoryController _category;
        StockMasterController _stock;
        private void StockDataBind()
        {

        }
        private void PopulateTreeView()
        {
            // Clear existing nodes
            trvCategory.Nodes.Clear();
            DataTable categories = new DataTable();
            categories = _category.GetCategory(0,"Sale");

            foreach (DataRow row in categories.Rows)
            {
                if (row[3] == DBNull.Value)
                {
                    TreeNode rootNode = new TreeNode(row[1].ToString());
                    rootNode.Tag = Convert.ToInt32(row[0]); // Store the category ID in the Tag property
                    trvCategory.Nodes.Add(rootNode);
                }
            }

            // Create child nodes
            foreach (DataRow row in categories.Rows)
            {
                if (row[3] != DBNull.Value && trvCategory.Nodes.ContainsKey(row[3].ToString()))
                {
                    TreeNode childNode = new TreeNode(row[1].ToString());
                    childNode.Tag = Convert.ToInt32(row[0]); // Store the category ID in the Tag property
                    trvCategory.Nodes[row[3].ToString()].Nodes.Add(childNode);
                }
            }
        }

        private void trvCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node != null)
            {
                int categoryId = (int)e.Node.Tag; // You need to implement this function

                DataTable stocks = _stock.GetStockByCateoryId(categoryId); // Replace with your data retrieval method

                dgvStockMaster.AutoGenerateColumns = false;
                dgvStockMaster.DataSource = stocks;
            }

        }

        private void dgvStockMaster_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }
    }
}
