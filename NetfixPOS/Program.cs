using NetfixPOS.Database;
using NetfixPOS.Main;
using NetfixPOS.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetfixPOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new POS_MainForm());
            Application.Run(new MainForm());
            //Application.Run(new MainFormSkin());
            //Application.Run(new NetfixSplash());

            //Application.Run(new SaleDashboard());
        }
    }
}
