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
    public partial class Room : Form, IFormBase
    {
        public Room()
        {
            InitializeComponent();
            _room = new RoomController();
            room = new RoomModel();

            ClearControl();
            DataBind();
        }
        RoomController _room;
        RoomModel room;
        int id = 0;
        public void ClearControl()
        {
            id = 0;
            txtRoomNo.Clear();
            txtRoomName.Clear();
            btnSave.Text = "Save";
        }

        public void DataBind()
        {
            dgvRoom.AutoGenerateColumns = false;
            dgvRoom.DataSource = _room.GetRoom(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomNo.Text)) return;

            room.RoomId = id;
            room.RoomNo = txtRoomNo.Text;
            room.RoomName = txtRoomName.Text;
            room.CompanyId = 1;
            room.ModifiedDate = DateTime.Now;
            room.IsDefault = chkIsDefault.Checked;

            switch (btnSave.Text)
            {
                case "Save":
                    _room.Insert(room);
                    break;

                case "Update":
                    _room.Update(room);
                    break;
            }
            ClearControl();
            DataBind();
        }

        private void dgvRoom_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GlobalFunction.GridView_DataBindingComplete(sender, e);
        }

        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvRoom.Columns[dgvRoom.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                id = Convert.ToInt32(dgvRoom.Rows[e.RowIndex].Cells["colRoomId"].Value);
                txtRoomName.Text = dgvRoom.Rows[e.RowIndex].Cells["colRoomName"].Value.ToString();
                txtRoomNo.Text = dgvRoom.Rows[e.RowIndex].Cells["colRoomNo"].Value.ToString();

                btnSave.Text = "Update";
            }
            else if (colName == "colDel")
            {
                id = Convert.ToInt32(dgvRoom.Rows[e.RowIndex].Cells["colRoomId"].Value);
                if (DialogResult.Yes == MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo))
                {
                    _room.Delete(id);
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
