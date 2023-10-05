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
    public partial class Unit : Form, IFormBase
    {
        public Unit()
        {
            InitializeComponent();
            _unit = new UnitController();
            unit = new UnitModel();

            ClearControl();
            DataBind();
        }
        UnitController _unit;
        UnitModel unit;
        int id = 0;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUnitName.Text)) return;

            unit.UnitID = id;
            unit.UnitName = txtUnitName.Text;
            unit.DefaultQty = Convert.ToInt32(nudDefaultQty.Value);
            switch (btnSave.Text)
            {
                case "Save":
                    _unit.Insert(unit);
                    break;

                case "Update":
                    _unit.Update(unit);
                    break;
            }
            ClearControl();
            DataBind();
        }

        public void ClearControl()
        {
            id = 0;
            btnSave.Text = "Save";
            txtUnitName.Text = "";
            nudDefaultQty.Value = 0;
        }

        public void DataBind()
        {
            dgvUnit.AutoGenerateColumns = false;
            dgvUnit.DataSource = _unit.GetUint();
        }

        private void dgvUnit_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void dgvUnit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUnit.Columns[dgvUnit.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                id = Convert.ToInt32(dgvUnit.Rows[e.RowIndex].Cells["colUnitID"].Value);
                txtUnitName.Text = dgvUnit.Rows[e.RowIndex].Cells["colUnitName"].Value.ToString();
                nudDefaultQty.Value = Convert.ToInt32(dgvUnit.Rows[e.RowIndex].Cells["colDefaultQty"].Value);

                btnSave.Text = "Update";
            }
            else if (colName == "colDel")
            {
                id = Convert.ToInt32(dgvUnit.Rows[e.RowIndex].Cells["colUnitID"].Value);
                if (DialogResult.Yes == MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo))
                {
                    _unit.Delete(id);
                    ClearControl();
                    DataBind();
                }
            }
        }
    }
}
