namespace Quiz
{
    partial class Izsu
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
            this.lblAboneAdi = new System.Windows.Forms.Label();
            this.textBoxAboneAdi = new System.Windows.Forms.TextBox();
            this.groupBoxAboneTipi = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBoxIlkIndex = new System.Windows.Forms.TextBox();
            this.textBoxSonIndex = new System.Windows.Forms.TextBox();
            this.labelIlkIndex = new System.Windows.Forms.Label();
            this.labelSonIndex = new System.Windows.Forms.Label();
            this.listBoxOdemeListesi = new System.Windows.Forms.ListBox();
            this.listBoxOdenenler = new System.Windows.Forms.ListBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.groupBoxAboneTipi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAboneAdi
            // 
            this.lblAboneAdi.AutoSize = true;
            this.lblAboneAdi.Location = new System.Drawing.Point(71, 9);
            this.lblAboneAdi.Name = "lblAboneAdi";
            this.lblAboneAdi.Size = new System.Drawing.Size(56, 13);
            this.lblAboneAdi.TabIndex = 0;
            this.lblAboneAdi.Text = "Abone Adı";
            // 
            // textBoxAboneAdi
            // 
            this.textBoxAboneAdi.Location = new System.Drawing.Point(15, 25);
            this.textBoxAboneAdi.Name = "textBoxAboneAdi";
            this.textBoxAboneAdi.Size = new System.Drawing.Size(194, 20);
            this.textBoxAboneAdi.TabIndex = 1;
            // 
            // groupBoxAboneTipi
            // 
            this.groupBoxAboneTipi.Controls.Add(this.radioButton2);
            this.groupBoxAboneTipi.Controls.Add(this.radioButton1);
            this.groupBoxAboneTipi.Location = new System.Drawing.Point(15, 52);
            this.groupBoxAboneTipi.Name = "groupBoxAboneTipi";
            this.groupBoxAboneTipi.Size = new System.Drawing.Size(194, 70);
            this.groupBoxAboneTipi.TabIndex = 2;
            this.groupBoxAboneTipi.TabStop = false;
            this.groupBoxAboneTipi.Text = "Abone Tipi";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ŞİRKET/KURUM";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "EV";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxIlkIndex
            // 
            this.textBoxIlkIndex.Location = new System.Drawing.Point(15, 143);
            this.textBoxIlkIndex.Name = "textBoxIlkIndex";
            this.textBoxIlkIndex.Size = new System.Drawing.Size(194, 20);
            this.textBoxIlkIndex.TabIndex = 3;
            // 
            // textBoxSonIndex
            // 
            this.textBoxSonIndex.Location = new System.Drawing.Point(15, 186);
            this.textBoxSonIndex.Name = "textBoxSonIndex";
            this.textBoxSonIndex.Size = new System.Drawing.Size(194, 20);
            this.textBoxSonIndex.TabIndex = 4;
            // 
            // labelIlkIndex
            // 
            this.labelIlkIndex.AutoSize = true;
            this.labelIlkIndex.Location = new System.Drawing.Point(95, 127);
            this.labelIlkIndex.Name = "labelIlkIndex";
            this.labelIlkIndex.Size = new System.Drawing.Size(47, 13);
            this.labelIlkIndex.TabIndex = 5;
            this.labelIlkIndex.Text = "İlk İndex";
            // 
            // labelSonIndex
            // 
            this.labelSonIndex.AutoSize = true;
            this.labelSonIndex.Location = new System.Drawing.Point(87, 170);
            this.labelSonIndex.Name = "labelSonIndex";
            this.labelSonIndex.Size = new System.Drawing.Size(55, 13);
            this.labelSonIndex.TabIndex = 6;
            this.labelSonIndex.Text = "Son İndex";
            // 
            // listBoxOdemeListesi
            // 
            this.listBoxOdemeListesi.FormattingEnabled = true;
            this.listBoxOdemeListesi.Location = new System.Drawing.Point(15, 236);
            this.listBoxOdemeListesi.Name = "listBoxOdemeListesi";
            this.listBoxOdemeListesi.Size = new System.Drawing.Size(94, 108);
            this.listBoxOdemeListesi.TabIndex = 7;
            this.listBoxOdemeListesi.DoubleClick += new System.EventHandler(this.listBoxOdemeListesi_DoubleClick);
            // 
            // listBoxOdenenler
            // 
            this.listBoxOdenenler.FormattingEnabled = true;
            this.listBoxOdenenler.Location = new System.Drawing.Point(115, 236);
            this.listBoxOdenenler.Name = "listBoxOdenenler";
            this.listBoxOdenenler.Size = new System.Drawing.Size(94, 108);
            this.listBoxOdenenler.TabIndex = 8;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(15, 210);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(194, 23);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // Izsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 349);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.listBoxOdenenler);
            this.Controls.Add(this.listBoxOdemeListesi);
            this.Controls.Add(this.labelSonIndex);
            this.Controls.Add(this.labelIlkIndex);
            this.Controls.Add(this.textBoxSonIndex);
            this.Controls.Add(this.textBoxIlkIndex);
            this.Controls.Add(this.groupBoxAboneTipi);
            this.Controls.Add(this.textBoxAboneAdi);
            this.Controls.Add(this.lblAboneAdi);
            this.Name = "Izsu";
            this.Text = "İzsu";
            this.groupBoxAboneTipi.ResumeLayout(false);
            this.groupBoxAboneTipi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboneAdi;
        private System.Windows.Forms.TextBox textBoxAboneAdi;
        private System.Windows.Forms.GroupBox groupBoxAboneTipi;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBoxIlkIndex;
        private System.Windows.Forms.TextBox textBoxSonIndex;
        private System.Windows.Forms.Label labelIlkIndex;
        private System.Windows.Forms.Label labelSonIndex;
        private System.Windows.Forms.ListBox listBoxOdemeListesi;
        private System.Windows.Forms.ListBox listBoxOdenenler;
        private System.Windows.Forms.Button BtnKaydet;
    }
}

