using NetfixPOS.Common;
using NetfixPOS.Controller;
using NetfixPOS.Models.DataSetFile;
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

namespace NetfixPOS.Admin
{
    public partial class UserPermission : KryptonForm
    {
        public UserPermission()
        {
            InitializeComponent();
            _users = new UsersController();
            _permission = new UserPermissionController();
            _controlform = new ControlFormController();
            permissiondt = new ds_Permission.UserPermissionDataTable();
            UsersDataBind();
            ControlFormDataBind();
            PermissionDataBind(0);
        }
        private UsersController _users;
        private UserPermissionController _permission;
        private ControlFormController _controlform;
        private int id = 0;

        ds_Permission.UserPermissionDataTable permissiondt;

        private void ControlFormDataBind()
        {
            cboControlForm.DataSource = _controlform.GetControlForm(0);
            cboControlForm.DisplayMember = "ControlForm";
            cboControlForm.ValueMember = "ControlId";
        }
        private void UsersDataBind()
        {
            cboUsers.DataSource = _users.GetUsers(0);
            cboUsers.DisplayMember = "UserName";
            cboUsers.ValueMember = "UserID";
        }
        private void PermissionDataBind(int userid)
        {
            dgvPermission.AutoGenerateColumns = false;
            dgvPermission.DataSource = _permission.GetUserPermissionList(userid);
        }
        private void ClearControl()
        {
            chkIsSave.Checked = false;
            chkIsUpdate.Checked = false;
            chkIsView.Checked = false;
            chkIsDelete.Checked = false;
            id = 0;
            btnSave.Text = "Save";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ds_Permission.UserPermissionRow per_row = permissiondt.NewUserPermissionRow();

            per_row.PermissionID = id;
            per_row.UserID = Convert.ToInt32(cboUsers.SelectedValue);
            per_row.ControlId = Convert.ToInt32(cboControlForm.SelectedValue);
            per_row.IsSave = chkIsSave.Checked;
            per_row.IsUpdate = chkIsUpdate.Checked;
            per_row.IsDelete = chkIsDelete.Checked;
            per_row.IsView = chkIsView.Checked;
            permissiondt.Rows.Add(per_row);

            switch (btnSave.Text)
            {
                case "Save":
                    _permission.Insert(per_row);
                    break;

                case "Update":
                    _permission.Update(per_row);
                    break;
            }
            
            PermissionDataBind(0);
            ClearControl();
        }

        private void cboUsers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PermissionDataBind(Convert.ToInt32(cboUsers.SelectedValue));
        }

        private void dgvPermission_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void dgvPermission_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvPermission.Columns[dgvPermission.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                id = Convert.ToInt32(dgvPermission.Rows[e.RowIndex].Cells["colPermissionId"].Value);
                cboUsers.SelectedValue = dgvPermission.Rows[e.RowIndex].Cells["colUserID"].Value.ToString();
                cboControlForm.SelectedValue = dgvPermission.Rows[e.RowIndex].Cells["colControlId"].Value != DBNull.Value ? Convert.ToString(dgvPermission.Rows[e.RowIndex].Cells["colControlId"].Value) : "";

                chkIsSave.Checked = dgvPermission.Rows[e.RowIndex].Cells["colIsSave"].Value != DBNull.Value ? Convert.ToBoolean(dgvPermission.Rows[e.RowIndex].Cells["colIsSave"].Value) : false;
                chkIsUpdate.Checked = dgvPermission.Rows[e.RowIndex].Cells["colIsUpdate"].Value != DBNull.Value ? Convert.ToBoolean(dgvPermission.Rows[e.RowIndex].Cells["colIsUpdate"].Value) : false;
                chkIsDelete.Checked = dgvPermission.Rows[e.RowIndex].Cells["colIsDelete"].Value != DBNull.Value ? Convert.ToBoolean(dgvPermission.Rows[e.RowIndex].Cells["colIsDelete"].Value) : false;
                chkIsView.Checked = dgvPermission.Rows[e.RowIndex].Cells["colIsView"].Value != DBNull.Value ? Convert.ToBoolean(dgvPermission.Rows[e.RowIndex].Cells["colIsView"].Value) : false;

                btnSave.Text = "Update";
            }
            else if (colName == "colDel")
            {
                id = Convert.ToInt32(dgvPermission.Rows[e.RowIndex].Cells["colPermissionId"].Value);
                if (DialogResult.Yes == MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo))
                {
                    _users.Delete(id);
                    ClearControl();
                    PermissionDataBind(0);
                }
            }
        }

        private void chkSearchByUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchByUser.Checked) PermissionDataBind(Convert.ToInt32(cboUsers.SelectedValue));
            else PermissionDataBind(0);
        }
    }
}
