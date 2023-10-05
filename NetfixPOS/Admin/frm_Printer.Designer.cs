
namespace NetfixPOS.Admin
{
    partial class frm_Printer
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
            this.kto_cbo_Printer = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.liv_printer = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.kto_cbo_Printer)).BeginInit();
            this.SuspendLayout();
            // 
            // kto_cbo_Printer
            // 
            this.kto_cbo_Printer.DropDownWidth = 301;
            this.kto_cbo_Printer.Location = new System.Drawing.Point(196, 23);
            this.kto_cbo_Printer.Name = "kto_cbo_Printer";
            this.kto_cbo_Printer.Size = new System.Drawing.Size(301, 29);
            this.kto_cbo_Printer.TabIndex = 0;
            this.kto_cbo_Printer.Text = "kryptonComboBox1";
            // 
            // liv_printer
            // 
            this.liv_printer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.liv_printer.HideSelection = false;
            this.liv_printer.Location = new System.Drawing.Point(0, 76);
            this.liv_printer.Name = "liv_printer";
            this.liv_printer.Size = new System.Drawing.Size(535, 374);
            this.liv_printer.TabIndex = 1;
            this.liv_printer.UseCompatibleStateImageBehavior = false;
            this.liv_printer.View = System.Windows.Forms.View.List;
            // 
            // frm_Printer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.liv_printer);
            this.Controls.Add(this.kto_cbo_Printer);
            this.Name = "frm_Printer";
            this.Text = "Printer";
            ((System.ComponentModel.ISupportInitialize)(this.kto_cbo_Printer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kto_cbo_Printer;
        private System.Windows.Forms.ListView liv_printer;
    }
}