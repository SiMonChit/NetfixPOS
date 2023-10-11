
namespace NetfixPOS.Main
{
    partial class NetfixSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetfixSplash));
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.prg_Progress = new System.Windows.Forms.ProgressBar();
            this.lblProcessStatus = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblProcessing = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(738, 44);
            this.kryptonHeader1.TabIndex = 0;
            this.kryptonHeader1.Values.Description = "Bar and Restaurant";
            this.kryptonHeader1.Values.Heading = "Netfix POS";
            this.kryptonHeader1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonHeader1.Values.Image")));
            // 
            // prg_Progress
            // 
            this.prg_Progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.prg_Progress.Location = new System.Drawing.Point(12, 287);
            this.prg_Progress.Name = "prg_Progress";
            this.prg_Progress.Size = new System.Drawing.Size(714, 31);
            this.prg_Progress.TabIndex = 1;
            // 
            // lblProcessStatus
            // 
            this.lblProcessStatus.Location = new System.Drawing.Point(308, 252);
            this.lblProcessStatus.Name = "lblProcessStatus";
            this.lblProcessStatus.Size = new System.Drawing.Size(116, 29);
            this.lblProcessStatus.TabIndex = 2;
            this.lblProcessStatus.Values.Text = "Processing....";
            // 
            // lblProcessing
            // 
            this.lblProcessing.Location = new System.Drawing.Point(421, 252);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(38, 29);
            this.lblProcessing.TabIndex = 3;
            this.lblProcessing.Values.Text = "0%";
            // 
            // NetfixSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 330);
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.lblProcessStatus);
            this.Controls.Add(this.prg_Progress);
            this.Controls.Add(this.kryptonHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NetfixSplash";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetfixSplash";
            this.Load += new System.EventHandler(this.NetfixSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private System.Windows.Forms.ProgressBar prg_Progress;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProcessStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProcessing;
    }
}