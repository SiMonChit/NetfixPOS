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

namespace NetfixPOS.NewSetup
{
    public partial class ConfitUnit : Form
    {
        public ConfitUnit(DataTable unitConfig)
        {
            InitializeComponent();

            Initialize();

            if (unitConfig.Rows.Count > 0)
            {
                foreach (DataRow row in unitConfig.Rows)
                {
                    lstBoxOrder.Items.Add(row[0]);
                    cboUnit.Items.Remove(row[0]);
                }
            }

        }
        #region Variable

        #region Method
        private void Initialize()
        {
            unitData.Columns.Add("UnitName");
            unitData.Columns.Add("UnitID");
            unitData.Columns.Add("Serial");

            BindUnit();
        }

        private void BindUnit()
        {
            DataTable dt = new UnitController().GetUint();

            cboUnit.Items.Clear();
            unitList.Clear();
            unitIdList.Clear();

            foreach (DataRow row in dt.Rows)
            {
                cboUnit.Items.Add(row[1]);

                unitList.Add(row[1].ToString());
                unitIdList.Add(row[0].ToString());
            }

            if (cboUnit.Items.Count > 0)
            {
                cboUnit.SelectedIndex = 0;
            }

        }


        #endregion

        DataTable unitData = new DataTable();

        public DataTable UnitData
        {
            get { return unitData; }
            set { unitData = value; }
        }

        List<string> unitList = new List<string>();
        List<string> unitIdList = new List<string>();

        #endregion
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            BindUnit();
            lstBoxOrder.Items.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            unitData.Rows.Clear();

            string unit;
            string unitId;

            int count = 1;
            foreach (var item in lstBoxOrder.Items)
            {
                unit = item.ToString();
                unitId = this.unitIdList[(this.unitList.IndexOf(item.ToString()))];

                unitData.Rows.Add(new object[]{
                    unit, unitId , count++
                });
            }

            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lstBoxOrder.Items.Count == 0) return;


            int current = lstBoxOrder.SelectedIndex;
            if (current <= 0) return;

            lstBoxOrder.Items.Insert(current - 1, lstBoxOrder.SelectedItem);
            lstBoxOrder.Items.RemoveAt(current + 1);
            lstBoxOrder.SelectedIndex = current - 1;
        }

        private void lstBoxOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstBoxOrder.Items.Count == 0) return;
            if (lstBoxOrder.SelectedIndex == -1) return;

            if (e.KeyCode == Keys.Delete)
            {
                cboUnit.Items.Add(lstBoxOrder.Text);
                lstBoxOrder.Items.RemoveAt(lstBoxOrder.SelectedIndex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboUnit.SelectedIndex == -1) return;

            lstBoxOrder.Items.Add(cboUnit.Text);
            cboUnit.Items.RemoveAt(cboUnit.SelectedIndex);

            if (cboUnit.Items.Count > 0)
            {
                cboUnit.SelectedIndex = 0;
            }
        }
    }
}
