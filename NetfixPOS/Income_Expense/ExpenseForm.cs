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
    public partial class ExpenseForm : Form, IFormBase
    {
        public ExpenseForm()
        {
            InitializeComponent();
            _expense = new ExpenseController();
            expense = new ExpenseModel();
        }
        ExpenseController _expense;
        ExpenseModel expense;
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
            dgvExpnse.AutoGenerateColumns = false;
            dgvExpnse.DataSource = _expense.GetExpense_List(DateTime.Now);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            expense.ExpenseId = id;
            expense.Ex_Description = txtDescription.Text;
            expense.Ex_Date = dtpIn_date.Value;
            expense.Ex_Amount = Convert.ToDecimal(txtAmount.Text);
            expense.UserID = 1;
            switch (btnSave.Text)
            {
                case "Save":
                    _expense.Insert(expense);
                    break;

                case "Update":
                    _expense.Update(expense);
                    break;
            }
            ClearControl();
            DataBind();
        }
    }
}
