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
    public partial class Table : Form,IFormBase
    {
        public Table()
        {
            InitializeComponent();
            _table = new TableController();
            table = new TableModel();
            ClearControl();
            DataBind();
        }
        TableController _table;
        TableModel table;
        int id = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            table.TableID = id;
            table.TableNo = txtTableNo.Text;
            table.TableName = txtTableName.Text;
            table.CompanyId = 1;
            table.ModifiedDate = DateTime.Now;
            table.IsDefault = chkIsDefault.Checked;

            switch (btnSave.Text)
            {
                case "Save":
                    _table.Insert(table);
                    break;

                case "Update":
                    _table.Update(table);
                    break;
            }
            ClearControl();
            DataBind();
        }

        public void ClearControl()
        {
            txtTableNo.Clear();
            txtTableName.Clear();
            id = 0;
            btnSave.Text = "Save";
        }

        public void DataBind()
        {
            dgvTable.AutoGenerateColumns = false;
            dgvTable.DataSource = _table.GetTable(0);
        }

        private void dgvTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvTable.Columns[dgvTable.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                id = Convert.ToInt32(dgvTable.Rows[e.RowIndex].Cells["colTableId"].Value);
                txtTableName.Text = dgvTable.Rows[e.RowIndex].Cells["colTableName"].Value.ToString();
                txtTableNo.Text = dgvTable.Rows[e.RowIndex].Cells["colTableNo"].Value.ToString();
               
                btnSave.Text = "Update";
            }
            else if (colName == "colDel")
            {
                id = Convert.ToInt32(dgvTable.Rows[e.RowIndex].Cells["colTableId"].Value);
                if (DialogResult.Yes == MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo))
                {
                    _table.Delete(id);
                    ClearControl();
                    DataBind();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControl();
        }
    }
}
