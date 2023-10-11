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
using ComponentFactory.Krypton.Toolkit;

namespace NetfixPOS.NewSetup
{
    public partial class Category : KryptonForm, IFormBase
    {
        public Category()
        {
            InitializeComponent();
            _category = new CategoryController();
            category = new CategoryModel();
            DataBind();
        }
        CategoryController _category;
        CategoryModel category;
        int id = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            category.CategoryId = id;
            category.CategoryName = txtCategoryName.Text;
            category.CategoryType = txtCategoryType.Text;

            if (string.IsNullOrEmpty(txtCategoryName.Text)) return;

            switch (btnSave.Text)
            {
                case "Save":
                    _category.Insert(category);
                    GlobalFunction.WriteLog("Category SaveButton Click " + category.CategoryName);
                    break;

                case "Update":
                    _category.Update(category);
                    GlobalFunction.WriteLog("Category UpdateButton Click " + category.CategoryName);
                    break;
            }
            

            ClearControl();
            DataBind();
        }

        public void ClearControl()
        {
            id = 0;
            btnSave.Text = "Save";
            txtCategoryName.Clear();
        }
        public void DataBind()
        {
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.DataSource = _category.GetAll();
        }
        private void dgvCategory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategory.Columns[dgvCategory.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                id = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells["colCategoryId"].Value);
                txtCategoryName.Text = dgvCategory.Rows[e.RowIndex].Cells["colCategoryName"].Value.ToString();
                txtCategoryType.Text = dgvCategory.Rows[e.RowIndex].Cells["colCategoryType"].Value.ToString();
                btnSave.Text = "Update";
            }
            else if (colName == "colDel")
            {
                id = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells["colCategoryId"].Value);
                if (DialogResult.Yes == MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo))
                {
                    _category.Delete(id);
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
