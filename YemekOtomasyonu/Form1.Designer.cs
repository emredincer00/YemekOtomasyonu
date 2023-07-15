namespace YemekOtomasyonu
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
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGiris
            // 
            this.txtGiris.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtGiris.Location = new System.Drawing.Point(121, 104);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(266, 20);
            this.txtGiris.TabIndex = 0;
            this.txtGiris.Text = "Kart Numaranızı Girin";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(200, 130);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(91, 23);
            this.btnGiris.TabIndex = 1;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 249);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtGiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.Button btnGiris;
    }
}

