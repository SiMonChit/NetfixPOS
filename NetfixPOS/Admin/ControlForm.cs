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
using NetfixPOS.Common;
using NetfixPOS.Controller;
using NetfixPOS.Models;

namespace NetfixPOS.Admin
{
    public partial class ControlForm : KryptonForm, IFormBase
    {
        public ControlForm()
        {
            InitializeComponent();
            _control = new ControlFormController();
            control = new ControlFormModel();

            DataBind();
        }
        ControlFormController _control;
        ControlFormModel control;
        int id = 0;
        private void dgvControlForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvControlForm.Columns[dgvControlForm.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                id = Convert.ToInt32(dgvControlForm.Rows[e.RowIndex].Cells["colControlId"].Value);
                txtControlName.Text = dgvControlForm.Rows[e.RowIndex].Cells["colControlForm"].Value.ToString();
                GlobalFunction.WriteLog("ControlForm : EditButton Click ");
                btnSave.Text = "Update";
            }
            else if (colName == "colDel")
            {
                id = Convert.ToInt32(dgvControlForm.Rows[e.RowIndex].Cells["colControlId"].Value);
                _control.Delete(id);
                txtControlName.Text = dgvControlForm.Rows[e.RowIndex].Cells["colControlForm"].Value.ToString();
                GlobalFunction.WriteLog("ControlForm : DeleteButton Click " + txtControlName.Text);

                ClearControl();
                DataBind();
            }
        }

        public void ClearControl()
        {
            txtControlName.Clear();
            id = 0;
            btnSave.Text = "Save";
        }

        public void DataBind()
        {
            dgvControlForm.AutoGenerateColumns = false;
            dgvControlForm.DataSource = _control.GetControlForm(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtControlName.Text)) return;
            control.ControlForm = txtControlName.Text;
            switch (btnSave.Text)
            {
                case "Save":
                    _control.Insert(control);
                    GlobalFunction.WriteLog("ControlForm : SaveButton Click " + control.ControlForm);
                    break;

                case "Update":
                    _control.Update(control);
                    GlobalFunction.WriteLog("ControlForm : UpdateButton Click " + control.ControlForm);
                    break;
            }
            ClearControl();
            DataBind();
        }

        private void dgvControlForm_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }
    }
}
