namespace BasicExamples
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnFib = new DevExpress.XtraEditors.SimpleButton();
            this.btnIslem = new DevExpress.XtraEditors.SimpleButton();
            this.btnRandom = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnFib
            // 
            this.btnFib.Location = new System.Drawing.Point(30, 33);
            this.btnFib.Name = "btnFib";
            this.btnFib.Size = new System.Drawing.Size(94, 29);
            this.btnFib.TabIndex = 1;
            this.btnFib.Text = "Fibonacci";
            this.btnFib.Click += new System.EventHandler(this.btnFib_Click);
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(162, 33);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(94, 29);
            this.btnIslem.TabIndex = 2;
            this.btnIslem.Text = "Dört İşlem";
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(295, 33);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(137, 29);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Random Çarpma";
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 450);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.btnFib);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnFib;
        private DevExpress.XtraEditors.SimpleButton btnIslem;
        private DevExpress.XtraEditors.SimpleButton btnRandom;
    }
}

