
namespace NetfixPOS.Report
{
    partial class frm_SaleHeaderReport
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
            this.panel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.rpv_SaleHeader = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboFilter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Controls.Add(this.cboFilter);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpToDate);
            this.panel1.Controls.Add(this.dtpFromDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.panel1.Size = new System.Drawing.Size(1419, 74);
            this.panel1.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(872, 22);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 37);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Values.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(621, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 29);
            this.label2.TabIndex = 3;
            this.label2.Values.Text = "ToDate";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(343, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 2;
            this.label1.Values.Text = "From Date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(698, 26);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(148, 26);
            this.dtpToDate.TabIndex = 1;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(448, 26);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(148, 26);
            this.dtpFromDate.TabIndex = 0;
            // 
            // rpv_SaleHeader
            // 
            this.rpv_SaleHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_SaleHeader.LocalReport.ReportEmbeddedResource = "NetfixPOS.rdlc_File.rdlc_SaleHeader.rdlc";
            this.rpv_SaleHeader.Location = new System.Drawing.Point(0, 74);
            this.rpv_SaleHeader.Name = "rpv_SaleHeader";
            this.rpv_SaleHeader.ServerReport.BearerToken = null;
            this.rpv_SaleHeader.Size = new System.Drawing.Size(1419, 618);
            this.rpv_SaleHeader.TabIndex = 4;
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownWidth = 220;
            this.cboFilter.Items.AddRange(new object[] {
            "All SaleInvoice (By Date)",
            "Weekly SaleInvoice",
            "Monthly SaleInvoice",
            "Yearly SaleInvoice"});
            this.cboFilter.Location = new System.Drawing.Point(110, 26);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(220, 29);
            this.cboFilter.TabIndex = 5;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(55, 26);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(53, 29);
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Filter";
            // 
            // frm_SaleHeaderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 692);
            this.Controls.Add(this.rpv_SaleHeader);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_SaleHeaderReport";
            this.Text = "Sale Report";
            this.Load += new System.EventHandler(this.frm_SaleHeaderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_SaleHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}