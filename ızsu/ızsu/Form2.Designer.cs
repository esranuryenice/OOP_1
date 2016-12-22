namespace ızsu
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
            this.label_aboneNo = new System.Windows.Forms.Label();
            this.textBoxAbone_No = new System.Windows.Forms.TextBox();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.textBoxtoplamodeme = new System.Windows.Forms.TextBox();
            this.labelsonodeme = new System.Windows.Forms.Label();
            this.labeltoplamodeme = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_aboneNo
            // 
            this.label_aboneNo.AutoSize = true;
            this.label_aboneNo.Location = new System.Drawing.Point(36, 29);
            this.label_aboneNo.Name = "label_aboneNo";
            this.label_aboneNo.Size = new System.Drawing.Size(57, 13);
            this.label_aboneNo.TabIndex = 0;
            this.label_aboneNo.Text = "Abone NO";
            // 
            // textBoxAbone_No
            // 
            this.textBoxAbone_No.Location = new System.Drawing.Point(90, 26);
            this.textBoxAbone_No.Name = "textBoxAbone_No";
            this.textBoxAbone_No.ReadOnly = true;
            this.textBoxAbone_No.Size = new System.Drawing.Size(182, 20);
            this.textBoxAbone_No.TabIndex = 1;
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(90, 52);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.ReadOnly = true;
            this.textBoxAdSoyad.Size = new System.Drawing.Size(182, 20);
            this.textBoxAdSoyad.TabIndex = 3;
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(36, 55);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.labelAdSoyad.TabIndex = 2;
            this.labelAdSoyad.Text = "Ad Soyad";
            // 
            // textBoxtoplamodeme
            // 
            this.textBoxtoplamodeme.Location = new System.Drawing.Point(90, 79);
            this.textBoxtoplamodeme.Name = "textBoxtoplamodeme";
            this.textBoxtoplamodeme.ReadOnly = true;
            this.textBoxtoplamodeme.Size = new System.Drawing.Size(182, 20);
            this.textBoxtoplamodeme.TabIndex = 5;
            // 
            // labelsonodeme
            // 
            this.labelsonodeme.AutoSize = true;
            this.labelsonodeme.Location = new System.Drawing.Point(10, 82);
            this.labelsonodeme.Name = "labelsonodeme";
            this.labelsonodeme.Size = new System.Drawing.Size(63, 13);
            this.labelsonodeme.TabIndex = 4;
            this.labelsonodeme.Text = "Son Ödeme";
            // 
            // labeltoplamodeme
            // 
            this.labeltoplamodeme.AutoSize = true;
            this.labeltoplamodeme.Location = new System.Drawing.Point(10, 112);
            this.labeltoplamodeme.Name = "labeltoplamodeme";
            this.labeltoplamodeme.Size = new System.Drawing.Size(79, 13);
            this.labeltoplamodeme.TabIndex = 6;
            this.labeltoplamodeme.Text = "Toplam Ödeme";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labeltoplamodeme);
            this.Controls.Add(this.textBoxtoplamodeme);
            this.Controls.Add(this.labelsonodeme);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.labelAdSoyad);
            this.Controls.Add(this.textBoxAbone_No);
            this.Controls.Add(this.label_aboneNo);
            this.Name = "Form2";
            this.Text = "Ödeme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_aboneNo;
        private System.Windows.Forms.TextBox textBoxAbone_No;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.TextBox textBoxtoplamodeme;
        private System.Windows.Forms.Label labelsonodeme;
        private System.Windows.Forms.Label labeltoplamodeme;
        private System.Windows.Forms.TextBox textBox1;
    }
}