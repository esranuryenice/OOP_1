namespace InsanKaynaklari
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxElemanTuru = new System.Windows.Forms.ComboBox();
            this.numericUpDownSSKNo = new System.Windows.Forms.NumericUpDown();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.listBoxElemanEkle = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMaas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSatisAdedi = new System.Windows.Forms.NumericUpDown();
            this.buttongüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSSKNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSatisAdedi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eleman Türü";
            // 
            // comboBoxElemanTuru
            // 
            this.comboBoxElemanTuru.FormattingEnabled = true;
            this.comboBoxElemanTuru.Location = new System.Drawing.Point(85, 21);
            this.comboBoxElemanTuru.Name = "comboBoxElemanTuru";
            this.comboBoxElemanTuru.Size = new System.Drawing.Size(121, 21);
            this.comboBoxElemanTuru.TabIndex = 1;
            // 
            // numericUpDownSSKNo
            // 
            this.numericUpDownSSKNo.Location = new System.Drawing.Point(85, 60);
            this.numericUpDownSSKNo.Name = "numericUpDownSSKNo";
            this.numericUpDownSSKNo.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSSKNo.TabIndex = 2;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(16, 174);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(190, 23);
            this.buttonEkle.TabIndex = 3;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // listBoxElemanEkle
            // 
            this.listBoxElemanEkle.FormattingEnabled = true;
            this.listBoxElemanEkle.Location = new System.Drawing.Point(237, 21);
            this.listBoxElemanEkle.Name = "listBoxElemanEkle";
            this.listBoxElemanEkle.Size = new System.Drawing.Size(176, 147);
            this.listBoxElemanEkle.TabIndex = 4;
            this.listBoxElemanEkle.DoubleClick += new System.EventHandler(this.listBoxElemanEkle_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SSK No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maaş";
            // 
            // numericUpDownMaas
            // 
            this.numericUpDownMaas.Location = new System.Drawing.Point(86, 99);
            this.numericUpDownMaas.Name = "numericUpDownMaas";
            this.numericUpDownMaas.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaas.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Satış Adedi";
            // 
            // numericUpDownSatisAdedi
            // 
            this.numericUpDownSatisAdedi.Location = new System.Drawing.Point(86, 136);
            this.numericUpDownSatisAdedi.Name = "numericUpDownSatisAdedi";
            this.numericUpDownSatisAdedi.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownSatisAdedi.TabIndex = 8;
            // 
            // buttongüncelle
            // 
            this.buttongüncelle.Location = new System.Drawing.Point(174, 133);
            this.buttongüncelle.Name = "buttongüncelle";
            this.buttongüncelle.Size = new System.Drawing.Size(32, 23);
            this.buttongüncelle.TabIndex = 10;
            this.buttongüncelle.Text = "G";
            this.buttongüncelle.UseVisualStyleBackColor = true;
            this.buttongüncelle.Click += new System.EventHandler(this.buttongüncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 261);
            this.Controls.Add(this.buttongüncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownSatisAdedi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownMaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxElemanEkle);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.numericUpDownSSKNo);
            this.Controls.Add(this.comboBoxElemanTuru);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSSKNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSatisAdedi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxElemanTuru;
        private System.Windows.Forms.NumericUpDown numericUpDownSSKNo;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.ListBox listBoxElemanEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMaas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSatisAdedi;
        private System.Windows.Forms.Button buttongüncelle;
    }
}

