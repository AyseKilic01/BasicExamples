namespace BasicExamples.Forms
{
    partial class Fibonacci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fibonacci));
            this.lstFib = new System.Windows.Forms.ListView();
            this.btnFib = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lstFib
            // 
            this.lstFib.HideSelection = false;
            this.lstFib.Location = new System.Drawing.Point(14, 74);
            this.lstFib.Name = "lstFib";
            this.lstFib.Size = new System.Drawing.Size(1089, 246);
            this.lstFib.TabIndex = 4;
            this.lstFib.UseCompatibleStateImageBehavior = false;
            // 
            // btnFib
            // 
            this.btnFib.Location = new System.Drawing.Point(880, 347);
            this.btnFib.Name = "btnFib";
            this.btnFib.Size = new System.Drawing.Size(94, 29);
            this.btnFib.TabIndex = 3;
            this.btnFib.Text = "Fibonacci";
            this.btnFib.Click += new System.EventHandler(this.btnFib_Click);
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 450);
            this.Controls.Add(this.lstFib);
            this.Controls.Add(this.btnFib);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fibonacci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fibonacci";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstFib;
        private DevExpress.XtraEditors.SimpleButton btnFib;
    }
}