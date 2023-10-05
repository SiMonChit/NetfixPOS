using NetfixPOS.Admin;
using NetfixPOS.Common;
using NetfixPOS.Controller;
using NetfixPOS.NewSetup;
using NetfixPOS.Report;
using NetfixPOS.Sales;
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

namespace NetfixPOS
{
    public partial class POS_MainForm : KryptonForm
    {
        public POS_MainForm()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        UsersController _user;
        private void MenuPermission()
        {
            if (GlobalFunction.LoginUser_Permission != null)
            {
                bool AuditMenu, AdminMenu, ReportMenu, StoreMenu;

                AuditMenu = GlobalFunction.LoginUser_Permission.Where(permission => permission.ControlForm == "AuditMenu").Select(permission => permission.IsView)
                    .FirstOrDefault();
                AdminMenu = GlobalFunction.LoginUser_Permission.Where(permission => permission.ControlForm == "AdminMenu").Select(permission => permission.IsView)
                    .FirstOrDefault();
                ReportMenu = GlobalFunction.LoginUser_Permission.Where(permission => permission.ControlForm == "ReportMenu").Select(permission => permission.IsView)
                    .FirstOrDefault();
                StoreMenu = GlobalFunction.LoginUser_Permission.Where(permission => permission.ControlForm == "StoreMenu").Select(permission => permission.IsView)
                    .FirstOrDefault();

                if (AuditMenu) auditToolStripMenuItem.Enabled = true;
                if (AdminMenu)
                {
                    newSetupToolStripMenuItem.Enabled = true;
                    saleTransactionToolStripMenuItem.Enabled = true;
                    adminToolStripMenuItem.Enabled = true;
                }
                if (ReportMenu) reportToolStripMenuItem.Enabled = true;
                if (StoreMenu) storeToolStripMenuItem.Enabled = true;
            }
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
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Currency currency = new Currency();
            currency.ShowDialog();
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unit unit = new Unit();
            unit.ShowDialog();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockItem stock = new StockItem();
            stock.ShowDialog();

            //StockMaster stockMaster = new StockMaster();
            //stockMaster.ShowDialog();

            //openChildForm(new StockMaster());
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.ShowDialog();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.ShowDialog();
        }

        private void POS_MainForm_Load(object sender, EventArgs e)
        {
            int IsRegister = GlobalFunction.Check_IsRegister();
            if (IsRegister == 0)
            {
                ShopInfo shopInfo = new ShopInfo();
                shopInfo.ShowDialog();
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ShowDialog();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin.Users users = new Admin.Users();
            users.ShowDialog();
        }

        private void saleTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleType saleType = new SaleType();
            saleType.ShowDialog();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Sale_Transaction());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TouchPOS touchPOS = new TouchPOS();
            touchPOS.ShowDialog();
        }

        private void generateNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoGenerate generate = new AutoGenerate();
            generate.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openChildForm(new Sale_POS());
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Employee());
        }

        private void damageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new DamageForm());
        }

        private void eventLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new EventLogs());
        }

        private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Income_Expense.IncomeForm());
        }

        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Income_Expense.ExpenseForm());
        }

        private void incomeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_IncomeReport());
        }

        private void expenseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_ExpenseReport());
        }

        private void saleInvoiceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_SaleHeaderReport());
        }

        private void saleItemReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_SaleItemReport());
        }

        private void damageReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_DamageReport());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _user = new UsersController();
            _user.UsersLogout(GlobalFunction.LoginUser.UserID);
            Application.Exit();
        }
        private void ActivateFormData()
        {
            if(GlobalFunction.LoginUser !=null)
            lblLoginUser.Text = GlobalFunction.LoginUser.UserName;
            if (GlobalFunction.LoginUser_Permission != null) MenuPermission();
        }
        private void POS_MainForm_Activated(object sender, EventArgs e)
        {
            ActivateFormData();
        }

        private void permissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ControlForm());
        }

        private void userPermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new UserPermission());
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shopInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ShopInfo());
        }

        private void POS_MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (GlobalFunction.LoginUser != null)
                {
                    _user = new UsersController();
                    _user.UsersLogout(GlobalFunction.LoginUser.UserID); _user = new UsersController();
                    _user.UsersLogout(GlobalFunction.LoginUser.UserID);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        private void saleAuditReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDailyAuditReport());
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
