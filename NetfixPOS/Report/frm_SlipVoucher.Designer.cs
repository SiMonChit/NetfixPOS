
namespace NetfixPOS.Report
{
    partial class frm_SlipVoucher
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
            this.rpv_SlipVoucher = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ds_SaleSlipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds_SaleSlipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpv_SlipVoucher
            // 
            this.rpv_SlipVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dt_saleslip";
            reportDataSource1.Value = this.ds_SaleSlipBindingSource;
            this.rpv_SlipVoucher.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_SlipVoucher.LocalReport.ReportEmbeddedResource = "NetfixPOS.rdlc_File.Slip_SaleVoucher.rdlc";
            this.rpv_SlipVoucher.Location = new System.Drawing.Point(0, 0);
            this.rpv_SlipVoucher.Name = "rpv_SlipVoucher";
            this.rpv_SlipVoucher.ServerReport.BearerToken = null;
            this.rpv_SlipVoucher.ShowBackButton = false;
            this.rpv_SlipVoucher.ShowFindControls = false;
            this.rpv_SlipVoucher.ShowPageNavigationControls = false;
            this.rpv_SlipVoucher.ShowParameterPrompts = false;
            this.rpv_SlipVoucher.ShowRefreshButton = false;
            this.rpv_SlipVoucher.ShowStopButton = false;
            this.rpv_SlipVoucher.ShowZoomControl = false;
            this.rpv_SlipVoucher.Size = new System.Drawing.Size(572, 776);
            this.rpv_SlipVoucher.TabIndex = 0;
            // 
            // ds_SaleSlipBindingSource
            // 
            this.ds_SaleSlipBindingSource.DataMember = "tbl_SaleSlip";
            this.ds_SaleSlipBindingSource.DataSource = typeof(NetfixPOS.Models.DataSetFile.ds_SaleSlip);
            // 
            // frm_SlipVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 776);
            this.Controls.Add(this.rpv_SlipVoucher);
            this.Name = "frm_SlipVoucher";
            this.Text = "SlipVoucher";
            this.Load += new System.EventHandler(this.frm_SlipVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_SaleSlipBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_SlipVoucher;
        private System.Windows.Forms.BindingSource ds_SaleSlipBindingSource;
    }
}