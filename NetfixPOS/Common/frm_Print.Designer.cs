
namespace NetfixPOS.Common
{
    partial class frm_Print
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
            this.cboPrinter = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnPrint = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cboTemplate = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cboPrinter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPrinter
            // 
            this.cboPrinter.DropDownWidth = 188;
            this.cboPrinter.Location = new System.Drawing.Point(422, 51);
            this.cboPrinter.Name = "cboPrinter";
            this.cboPrinter.Size = new System.Drawing.Size(188, 29);
            this.cboPrinter.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(349, 51);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(67, 29);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Printer";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(422, 132);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 40);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Values.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(31, 51);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(89, 29);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Template";
            // 
            // cboTemplate
            // 
            this.cboTemplate.DropDownWidth = 188;
            this.cboTemplate.Location = new System.Drawing.Point(126, 51);
            this.cboTemplate.Name = "cboTemplate";
            this.cboTemplate.Size = new System.Drawing.Size(188, 29);
            this.cboTemplate.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(520, 132);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 40);
            this.btnClose.TabIndex = 5;
            this.btnClose.Values.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frm_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 213);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboTemplate);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.cboPrinter);
            this.Name = "frm_Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            ((System.ComponentModel.ISupportInitialize)(this.cboPrinter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTemplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboPrinter;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPrint;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboTemplate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
    }
}