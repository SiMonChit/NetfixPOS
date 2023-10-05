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

namespace NetfixPOS.Admin
{
    public partial class AutoGenerate : Form, IFormBase
    {
        public AutoGenerate()
        {
            InitializeComponent();
            _generate = new AutoGenerateController();
            autogenerate = new AutoGenerateModel();

            DataBind();
            ClearControl();
        }
        AutoGenerateController _generate;
        AutoGenerateModel autogenerate;
        int id = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            autogenerate.GenerateNo = txtGenerateNo.Text;
            autogenerate.GenerateType = txtGenerateType.Text;
            autogenerate.LastValue = Convert.ToInt32(txtLastValue.Text);
            autogenerate.GenerateDate = dtpGenerateDate.Value;

            switch (btnSave.Text)
            {
                case "Save":
                    _generate.Insert(autogenerate);
                    break;

                case "Update":
                    _generate.Update(autogenerate);
                    break;
            }

            ClearControl();
            DataBind();

        }

        public void ClearControl()
        {
            txtGenerateNo.Clear();
            txtGenerateType.Clear();
            txtLastValue.Clear();
            id = 0;
            btnSave.Text = "Save";
            
        }

        public void DataBind()
        {
            dgvAutoGenerate.AutoGenerateColumns = false;
            dgvAutoGenerate.DataSource = _generate.GetGenerateData();
        }

        private void dgvAutoGenerate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvAutoGenerate.Columns[dgvAutoGenerate.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                id = Convert.ToInt32(dgvAutoGenerate.Rows[e.RowIndex].Cells["colGenerateId"].Value);
                txtGenerateNo.Text = dgvAutoGenerate.Rows[e.RowIndex].Cells["colGenerateNo"].Value.ToString();
                txtGenerateType.Text = dgvAutoGenerate.Rows[e.RowIndex].Cells["colGenerateType"].Value.ToString();
                txtLastValue.Text = dgvAutoGenerate.Rows[e.RowIndex].Cells["colLastValue"].Value.ToString();
            }
            else if (colName == "colDel")
            {
                id = Convert.ToInt32(dgvAutoGenerate.Rows[e.RowIndex].Cells["colGenerateId"].Value);
                if (DialogResult.Yes == MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo))
                {
                    _generate.Delete(id);
                }   
            }
        }
    }
}
