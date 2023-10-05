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

namespace NetfixPOS.Income_Expense
{
    public partial class IncomeForm : Form,IFormBase
    {
        public IncomeForm()
        {
            InitializeComponent();
            _income = new IncomeController();
            income = new IncomeModel();

            DataBind();
            ClearControl();
        }
        IncomeController _income;
        IncomeModel income;
        int id = 0;
        public void ClearControl()
        {
            id = 0;
            txtDescription.Clear();
            txtAmount.Clear();
            btnSave.Text = "Save";
        }

        public void DataBind()
        {
            dgvIncome.AutoGenerateColumns = false;
            dgvIncome.DataSource = _income.GetIncome_List(DateTime.Now);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            income.IncomeId = id;
            income.In_Description = txtDescription.Text;
            income.In_Date = dtpIn_date.Value;
            income.In_Amount = Convert.ToDecimal(txtAmount.Text);
            income.UserID = 1;
            switch (btnSave.Text)
            {
                case "Save":
                    _income.Insert(income);
                    break;

                case "Update":
                    _income.Update(income);
                    break;
            }
            ClearControl();
            DataBind();
        }
    }
}
