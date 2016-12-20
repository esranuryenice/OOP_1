namespace OzHakikiUlusoy
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.GboxCinsiyet = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.comboBoxOtobusTuru = new System.Windows.Forms.ComboBox();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.radioButton1Kadın = new System.Windows.Forms.RadioButton();
            this.labelOtobusTuru = new System.Windows.Forms.Label();
            this.listBoxmusteriler = new System.Windows.Forms.ListBox();
            this.GboxCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 189);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // GboxCinsiyet
            // 
            this.GboxCinsiyet.Controls.Add(this.radioButton1Kadın);
            this.GboxCinsiyet.Controls.Add(this.radioButtonErkek);
            this.GboxCinsiyet.Location = new System.Drawing.Point(12, 55);
            this.GboxCinsiyet.Name = "GboxCinsiyet";
            this.GboxCinsiyet.Size = new System.Drawing.Size(100, 88);
            this.GboxCinsiyet.TabIndex = 5;
            this.GboxCinsiyet.TabStop = false;
            this.GboxCinsiyet.Text = "Cinsiyet";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(12, 9);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.LblAdSoyad.TabIndex = 4;
            this.LblAdSoyad.Text = "Ad-Soyad";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(12, 31);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.TxtAdSoyad.TabIndex = 3;
            // 
            // comboBoxOtobusTuru
            // 
            this.comboBoxOtobusTuru.FormattingEnabled = true;
            this.comboBoxOtobusTuru.Items.AddRange(new object[] {
            "Setra",
            "Travego",
            "403"});
            this.comboBoxOtobusTuru.Location = new System.Drawing.Point(12, 149);
            this.comboBoxOtobusTuru.Name = "comboBoxOtobusTuru";
            this.comboBoxOtobusTuru.Size = new System.Drawing.Size(100, 21);
            this.comboBoxOtobusTuru.TabIndex = 6;
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Location = new System.Drawing.Point(7, 20);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(53, 17);
            this.radioButtonErkek.TabIndex = 0;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // radioButton1Kadın
            // 
            this.radioButton1Kadın.AutoSize = true;
            this.radioButton1Kadın.Location = new System.Drawing.Point(7, 54);
            this.radioButton1Kadın.Name = "radioButton1Kadın";
            this.radioButton1Kadın.Size = new System.Drawing.Size(52, 17);
            this.radioButton1Kadın.TabIndex = 1;
            this.radioButton1Kadın.TabStop = true;
            this.radioButton1Kadın.Text = "Kadın";
            this.radioButton1Kadın.UseVisualStyleBackColor = true;
            // 
            // labelOtobusTuru
            // 
            this.labelOtobusTuru.AutoSize = true;
            this.labelOtobusTuru.Location = new System.Drawing.Point(15, 173);
            this.labelOtobusTuru.Name = "labelOtobusTuru";
            this.labelOtobusTuru.Size = new System.Drawing.Size(66, 13);
            this.labelOtobusTuru.TabIndex = 7;
            this.labelOtobusTuru.Text = "Otobüs Türü";
            // 
            // listBoxmusteriler
            // 
            this.listBoxmusteriler.FormattingEnabled = true;
            this.listBoxmusteriler.Location = new System.Drawing.Point(143, 31);
            this.listBoxmusteriler.Name = "listBoxmusteriler";
            this.listBoxmusteriler.Size = new System.Drawing.Size(154, 173);
            this.listBoxmusteriler.TabIndex = 8;
            this.listBoxmusteriler.DoubleClick += new System.EventHandler(this.listBoxmusteriler_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 230);
            this.Controls.Add(this.listBoxmusteriler);
            this.Controls.Add(this.labelOtobusTuru);
            this.Controls.Add(this.comboBoxOtobusTuru);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.GboxCinsiyet);
            this.Controls.Add(this.btnKaydet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GboxCinsiyet.ResumeLayout(false);
            this.GboxCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox GboxCinsiyet;
        private System.Windows.Forms.RadioButton radioButton1Kadın;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.ComboBox comboBoxOtobusTuru;
        private System.Windows.Forms.Label labelOtobusTuru;
        private System.Windows.Forms.ListBox listBoxmusteriler;
    }
}

