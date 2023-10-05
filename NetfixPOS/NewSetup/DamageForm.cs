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
    public partial class DamageForm : Form, IFormBase
    {
        public DamageForm()
        {
            InitializeComponent();
            _damage = new DamageController();
            damage = new DamageModel();
            DataBind();
            ClearControl();
        }
        DamageController _damage;
        DamageModel damage;
        int id = 0;

        private DamageModel BindToModel()
        {
            damage.TableOrRoom = txtTableOrRoom.Text;
            damage.Dmg_Description = txtDmg_Desc.Text;
            damage.Dmg_Charges = Convert.ToDecimal(txtCharges.Text);
            damage.Dmg_Approver = txtApproverName.Text;
            damage.Dmg_Date = dtpDmg_Date.Value;
            damage.UserID = 1;
            return damage;
        }
        private bool CheckRequireFill()
        {
            if (string.IsNullOrEmpty(txtCharges.Text))
            {
                MessageBox.Show("Fill in Charges amount", "Damage Form", MessageBoxButtons.OK);
                return false;
            }
            else if (string.IsNullOrEmpty(txtDmg_Desc.Text))
            {
                MessageBox.Show("Fill in Remark", "Damage Form", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckRequireFill())
            {
                _damage.Insert(BindToModel());
                GlobalFunction.WriteLog("Damage SaveButton Click " + txtDmg_Desc.Text);
                ClearControl();
                DataBind();
            }
           
        }

        public void ClearControl()
        {
            txtApproverName.Clear();
            txtCharges.Clear();
            txtDmg_Desc.Clear();
            txtTableOrRoom.Clear();
            id = 0;

        }

        public void DataBind()
        {
            dgvDamage.AutoGenerateColumns = false;
            dgvDamage.DataSource = _damage.GetDamageList(DateTime.Now);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _damage.Update(BindToModel());
            GlobalFunction.WriteLog("Damage UpdateButton Click " + txtDmg_Desc.Text);
            ClearControl();
            DataBind();
        }

        private void dgvDamage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvDamage.Columns[dgvDamage.CurrentCell.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                id = Convert.ToInt32(dgvDamage.Rows[e.RowIndex].Cells["colDamageId"].Value);
                txtDmg_Desc.Text = dgvDamage.Rows[e.RowIndex].Cells["colDmg_Desc"].Value.ToString();
                txtCharges.Text = dgvDamage.Rows[e.RowIndex].Cells["colDmg_Charges"].Value.ToString();

                //txtDRNo.Text = dgvDamage.Rows[e.RowIndex].Cells["colCategoryName"].Value.ToString();

                txtTableOrRoom.Text = dgvDamage.Rows[e.RowIndex].Cells["colTableOrRoom"].Value.ToString();
                txtApproverName.Text = dgvDamage.Rows[e.RowIndex].Cells["colDmg_Approver"].Value.ToString();
                dtpDmg_Date.Value = Convert.ToDateTime(dgvDamage.Rows[e.RowIndex].Cells["colDmg_Date"].Value);
                btnSave.Text = "Update";
                GlobalFunction.WriteLog("Damage EditButton Click ");
            }
            else if (colName == "colDel")
            {
                id = Convert.ToInt32(dgvDamage.Rows[e.RowIndex].Cells["colDamageId"].Value);
                txtDmg_Desc.Text = dgvDamage.Rows[e.RowIndex].Cells["colDmg_Desc"].Value.ToString();
                if (DialogResult.Yes == MessageBox.Show("Are you sure to delete", "Delete", MessageBoxButtons.YesNo))
                {
                    _damage.Delete(id);
                    GlobalFunction.WriteLog("Damage DeleteButton Click " + txtDmg_Desc.Text);
                    ClearControl();
                    DataBind();
                }
            }
        }
    }
}
