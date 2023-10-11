using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using NetfixPOS.Common;

namespace NetfixPOS.Main
{
    public partial class NetfixSplash : KryptonForm
    {
        public NetfixSplash()
        {
            InitializeComponent();
        }
        public Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    Thread.Sleep(10);
                }

            });
        }

        private async void NetfixSplash_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for(int i=0; i<1000; i++)
            {
                list.Add(i.ToString());
            }
            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
              {
                  lblProcessing.Text = string.Format("{0}%", report.PercentComplete);
                  prg_Progress.Value = report.PercentComplete;
                  prg_Progress.Update();
              };
            await ProcessData(list, progress);
            lblProcessStatus.Text = "Done !";
        }
    }
}
