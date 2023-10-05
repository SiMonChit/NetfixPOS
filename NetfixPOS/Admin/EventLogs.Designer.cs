
namespace NetfixPOS.Admin
{
    partial class EventLogs
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.rpv_EventLogs = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ds_EventLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_EventLogsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearLog);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpToDate);
            this.panel1.Controls.Add(this.dtpFromDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1462, 74);
            this.panel1.TabIndex = 0;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(743, 23);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(116, 37);
            this.btnClearLog.TabIndex = 5;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(602, 23);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 37);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ToDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(365, 28);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(148, 26);
            this.dtpToDate.TabIndex = 1;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(112, 28);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(148, 26);
            this.dtpFromDate.TabIndex = 0;
            // 
            // rpv_EventLogs
            // 
            this.rpv_EventLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dt_EventLogs";
            reportDataSource1.Value = this.ds_EventLogsBindingSource;
            this.rpv_EventLogs.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_EventLogs.LocalReport.ReportEmbeddedResource = "NetfixPOS.rdlc_File.rdlc_EventLogs.rdlc";
            this.rpv_EventLogs.Location = new System.Drawing.Point(0, 74);
            this.rpv_EventLogs.Name = "rpv_EventLogs";
            this.rpv_EventLogs.ServerReport.BearerToken = null;
            this.rpv_EventLogs.Size = new System.Drawing.Size(1462, 592);
            this.rpv_EventLogs.TabIndex = 1;
            // 
            // ds_EventLogsBindingSource
            // 
            this.ds_EventLogsBindingSource.DataMember = "EventLogs";
            this.ds_EventLogsBindingSource.DataSource = typeof(NetfixPOS.Models.DataSetFile.ds_EventLogs);
            // 
            // EventLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 666);
            this.Controls.Add(this.rpv_EventLogs);
            this.Controls.Add(this.panel1);
            this.Name = "EventLogs";
            this.Text = "EventLogs";
            this.Load += new System.EventHandler(this.EventLogs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_EventLogsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnRefresh;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_EventLogs;
        private System.Windows.Forms.BindingSource ds_EventLogsBindingSource;
    }
}