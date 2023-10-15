
namespace NetfixPOS.Purchase
{
    partial class frm_ImportPurchase
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
            this.btnOpenExcelFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCreateExcelFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnImport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvPurchaseItem = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItem)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnOpenExcelFile);
            this.kryptonPanel1.Controls.Add(this.btnCreateExcelFile);
            this.kryptonPanel1.Controls.Add(this.btnImport);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kryptonPanel1.Size = new System.Drawing.Size(1145, 71);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btnOpenExcelFile
            // 
            this.btnOpenExcelFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOpenExcelFile.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnOpenExcelFile.Location = new System.Drawing.Point(868, 14);
            this.btnOpenExcelFile.Name = "btnOpenExcelFile";
            this.btnOpenExcelFile.Size = new System.Drawing.Size(98, 38);
            this.btnOpenExcelFile.TabIndex = 3;
            this.btnOpenExcelFile.Values.Text = "Open File";
            this.btnOpenExcelFile.Click += new System.EventHandler(this.btnOpenExcelFile_Click);
            // 
            // btnCreateExcelFile
            // 
            this.btnCreateExcelFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCreateExcelFile.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnCreateExcelFile.Location = new System.Drawing.Point(711, 14);
            this.btnCreateExcelFile.Name = "btnCreateExcelFile";
            this.btnCreateExcelFile.Size = new System.Drawing.Size(110, 38);
            this.btnCreateExcelFile.TabIndex = 2;
            this.btnCreateExcelFile.Values.Text = "Create File";
            this.btnCreateExcelFile.Click += new System.EventHandler(this.btnCreateExcelFile_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnImport.Location = new System.Drawing.Point(1021, 14);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(98, 38);
            this.btnImport.TabIndex = 0;
            this.btnImport.Values.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dgvPurchaseItem
            // 
            this.dgvPurchaseItem.AllowUserToAddRows = false;
            this.dgvPurchaseItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseItem.Location = new System.Drawing.Point(0, 71);
            this.dgvPurchaseItem.Name = "dgvPurchaseItem";
            this.dgvPurchaseItem.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.dgvPurchaseItem.RowHeadersWidth = 50;
            this.dgvPurchaseItem.RowTemplate.Height = 28;
            this.dgvPurchaseItem.Size = new System.Drawing.Size(1145, 689);
            this.dgvPurchaseItem.TabIndex = 1;
            this.dgvPurchaseItem.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPurchaseItem_DataBindingComplete);
            // 
            // frm_ImportPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 760);
            this.Controls.Add(this.dgvPurchaseItem);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_ImportPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnImport;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCreateExcelFile;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOpenExcelFile;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvPurchaseItem;
    }
}