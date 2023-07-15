namespace YemekOtomasyonu
{
    partial class Form2
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
            this.cmbYiyecekler = new System.Windows.Forms.ComboBox();
            this.cmbIcecekler = new System.Windows.Forms.ComboBox();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.btnCiro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbYiyecekler
            // 
            this.cmbYiyecekler.FormattingEnabled = true;
            this.cmbYiyecekler.Location = new System.Drawing.Point(62, 35);
            this.cmbYiyecekler.Name = "cmbYiyecekler";
            this.cmbYiyecekler.Size = new System.Drawing.Size(139, 21);
            this.cmbYiyecekler.TabIndex = 0;
            // 
            // cmbIcecekler
            // 
            this.cmbIcecekler.FormattingEnabled = true;
            this.cmbIcecekler.Location = new System.Drawing.Point(62, 81);
            this.cmbIcecekler.Name = "cmbIcecekler";
            this.cmbIcecekler.Size = new System.Drawing.Size(139, 21);
            this.cmbIcecekler.TabIndex = 1;
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(62, 129);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(139, 23);
            this.btnSatinAl.TabIndex = 2;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // btnCiro
            // 
            this.btnCiro.Location = new System.Drawing.Point(203, 228);
            this.btnCiro.Name = "btnCiro";
            this.btnCiro.Size = new System.Drawing.Size(75, 23);
            this.btnCiro.TabIndex = 3;
            this.btnCiro.Text = "Günlük Ciro";
            this.btnCiro.UseVisualStyleBackColor = true;
            this.btnCiro.Click += new System.EventHandler(this.btnCiro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tutar =";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(66, 235);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(0, 13);
            this.lblTutar.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 263);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCiro);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.cmbIcecekler);
            this.Controls.Add(this.cmbYiyecekler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYiyecekler;
        private System.Windows.Forms.ComboBox cmbIcecekler;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Button btnCiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTutar;
    }
}