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
using NetfixPOS.Admin;
using NetfixPOS.Common;
using NetfixPOS.Controller;
using NetfixPOS.Income_Expense;
using NetfixPOS.NewSetup;
using NetfixPOS.Purchase;
using NetfixPOS.Report;
using NetfixPOS.Sales;

namespace NetfixPOS.Main
{
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
            _user = new UsersController();
            DeleteLogFile();
        }
        private Form activeForm = null;
        UsersController _user;

        private void DeleteLogFile()
        {
            string tempfolder = GlobalFunction.ReadSetting("LogPath");
            string logfolder = tempfolder + "log";
            GlobalFunction.DeleteOldLogFiles(logfolder);
        }
        private void openChildForm(Form childForm)
        {
            try
            {
                if (activeForm != null)
                    activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.Dock = DockStyle.Fill;
                kt_panelChildForm.Controls.Add(childForm);
                kt_panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void rbo_category_Click(object sender, EventArgs e)
        {
            openChildForm(new Category());
        }

        private void rbo_Printer_Click(object sender, EventArgs e)
        {
            //openChildForm(new frm_Printer());
            frm_Printer printer = new frm_Printer();
            printer.ShowDialog();
        }

        private void rbo_stock_Click(object sender, EventArgs e)
        {
            openChildForm(new StockItem());
        }

        private void rbo_customer_Click(object sender, EventArgs e)
        {
            openChildForm(new Customer());
        }

        private void rbo_supplier_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Supplier());
        }

        private void rbo_Table_Click(object sender, EventArgs e)
        {
            openChildForm(new Table());
        }

        private void rbo_Room_Click(object sender, EventArgs e)
        {
            openChildForm(new Room());
        }

        private void rbo_SalePos_Click(object sender, EventArgs e)
        {
            openChildForm(new Sale_POS());
        }

        private void rbo_SaleInvoice_Click(object sender, EventArgs e)
        {
            openChildForm(new Sale_Transaction());
        }

        private void rbo_Purchase_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Purchase());
        }

        private void rbo_Income_Click(object sender, EventArgs e)
        {
            openChildForm(new IncomeForm());
        }

        private void rbo_Expense_Click(object sender, EventArgs e)
        {
            openChildForm(new ExpenseForm());
        }

        private void rbo_Damage_Click(object sender, EventArgs e)
        {
            openChildForm(new DamageForm());
        }

        private void kryptonRibbonGroupButton12_Click(object sender, EventArgs e)
        {
            openChildForm(new ShopInfo());
        }

        private void rbo_generateNo_Click(object sender, EventArgs e)
        {
            AutoGenerate generate = new AutoGenerate();
            generate.ShowDialog();
        }

        private void rbo_employee_Click(object sender, EventArgs e)
        {
            openChildForm(new Employee());
        }

        private void rbo_user_account_Click(object sender, EventArgs e)
        {
            openChildForm(new Users());
        }

        private void rbo_department_Click(object sender, EventArgs e)
        {
            //openChildForm(new Department());
            Department department = new Department();
            department.ShowDialog();
        }

        private void rbo_Currency_Click(object sender, EventArgs e)
        {
            //openChildForm(new Currency());
            Currency currency = new Currency();
            currency.ShowDialog();
        }

        private void rbo_Unit_Click(object sender, EventArgs e)
        {
            //openChildForm(new Unit());
            Unit unit = new Unit();
            unit.ShowDialog();
        }

        private void rbo_Permission_Click(object sender, EventArgs e)
        {
            openChildForm(new UserPermission());
        }

        private void rbo_Eventlogs_Click(object sender, EventArgs e)
        {
            openChildForm(new EventLogs());
        }

        private void rbo_ControlForm_Click(object sender, EventArgs e)
        {
            ControlForm controlform = new ControlForm();
            controlform.ShowDialog();
        }

        private void rbo_income_report_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_IncomeReport());
           
        }

        private void rbo_Expense_report_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_ExpenseReport());
        }

        private void rbo_damage_report_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_DamageReport());
        }

        private void rbo_purchase_report_Click(object sender, EventArgs e)
        {
            
        }

        private void rbo_saleInvoice_report_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_SaleHeaderReport());
        }

        private void rbo_SaleItem_report_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_SaleItemReport());
        }

        private void btnEndOfDay_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_EndOfDay());
        }
    }
}
