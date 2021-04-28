namespace BasicExamples
{
    partial class Form1
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
            this.btnFib = new DevExpress.XtraEditors.SimpleButton();
            this.lstFib = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnFib
            // 
            this.btnFib.Location = new System.Drawing.Point(905, 369);
            this.btnFib.Name = "btnFib";
            this.btnFib.Size = new System.Drawing.Size(94, 29);
            this.btnFib.TabIndex = 1;
            this.btnFib.Text = "Fibonacci";
            this.btnFib.Click += new System.EventHandler(this.btnFib_Click);
            // 
            // lstFib
            // 
            this.lstFib.HideSelection = false;
            this.lstFib.Location = new System.Drawing.Point(39, 96);
            this.lstFib.Name = "lstFib";
            this.lstFib.Size = new System.Drawing.Size(1089, 246);
            this.lstFib.TabIndex = 2;
            this.lstFib.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 450);
            this.Controls.Add(this.lstFib);
            this.Controls.Add(this.btnFib);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnFib;
        private System.Windows.Forms.ListView lstFib;
    }
}

