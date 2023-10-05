
namespace NetfixPOS.Report
{
    partial class frmDailyAuditReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDateTimePicker2 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.rpv_dailyaudit = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnRefresh);
            this.kryptonPanel1.Controls.Add(this.kryptonDateTimePicker2);
            this.kryptonPanel1.Controls.Add(this.kryptonDateTimePicker1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1110, 78);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(582, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 33);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Values.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // kryptonDateTimePicker2
            // 
            this.kryptonDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker2.Location = new System.Drawing.Point(394, 23);
            this.kryptonDateTimePicker2.Name = "kryptonDateTimePicker2";
            this.kryptonDateTimePicker2.Size = new System.Drawing.Size(151, 30);
            this.kryptonDateTimePicker2.TabIndex = 3;
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(129, 21);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(151, 30);
            this.kryptonDateTimePicker1.TabIndex = 2;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(291, 24);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(86, 29);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "To Date :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(16, 22);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(107, 29);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "From Date :";
            // 
            // rpv_dailyaudit
            // 
            this.rpv_dailyaudit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_dailyaudit.Location = new System.Drawing.Point(0, 78);
            this.rpv_dailyaudit.Name = "rpv_dailyaudit";
            this.rpv_dailyaudit.ServerReport.BearerToken = null;
            this.rpv_dailyaudit.Size = new System.Drawing.Size(1110, 541);
            this.rpv_dailyaudit.TabIndex = 1;
            // 
            // frmDailyAuditReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 619);
            this.Controls.Add(this.rpv_dailyaudit);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "frmDailyAuditReport";
            this.Text = "DailyAuditReport";
            this.Load += new System.EventHandler(this.frmDailyAuditReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRefresh;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_dailyaudit;
    }
}