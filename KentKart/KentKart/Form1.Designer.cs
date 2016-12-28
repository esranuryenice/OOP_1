namespace KentKart
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonogrenci = new System.Windows.Forms.RadioButton();
            this.radioButtonogretmen = new System.Windows.Forms.RadioButton();
            this.buttonekle = new System.Windows.Forms.Button();
            this.radioButtonTam = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelyolcular = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOkuladi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBakiye = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(31, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kart Oluştur";
            // 
            // radioButtonogrenci
            // 
            this.radioButtonogrenci.AutoSize = true;
            this.radioButtonogrenci.Location = new System.Drawing.Point(45, 89);
            this.radioButtonogrenci.Name = "radioButtonogrenci";
            this.radioButtonogrenci.Size = new System.Drawing.Size(62, 17);
            this.radioButtonogrenci.TabIndex = 0;
            this.radioButtonogrenci.TabStop = true;
            this.radioButtonogrenci.Text = "Öğrenci";
            this.radioButtonogrenci.UseVisualStyleBackColor = true;
            this.radioButtonogrenci.CheckedChanged += new System.EventHandler(this.radioButtonogrenci_CheckedChanged);
            // 
            // radioButtonogretmen
            // 
            this.radioButtonogretmen.AutoSize = true;
            this.radioButtonogretmen.Location = new System.Drawing.Point(45, 112);
            this.radioButtonogretmen.Name = "radioButtonogretmen";
            this.radioButtonogretmen.Size = new System.Drawing.Size(71, 17);
            this.radioButtonogretmen.TabIndex = 1;
            this.radioButtonogretmen.TabStop = true;
            this.radioButtonogretmen.Text = "Öğretmen";
            this.radioButtonogretmen.UseVisualStyleBackColor = true;
            // 
            // buttonekle
            // 
            this.buttonekle.Location = new System.Drawing.Point(41, 135);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(75, 23);
            this.buttonekle.TabIndex = 2;
            this.buttonekle.Text = "Ekle";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // radioButtonTam
            // 
            this.radioButtonTam.AutoSize = true;
            this.radioButtonTam.Location = new System.Drawing.Point(45, 66);
            this.radioButtonTam.Name = "radioButtonTam";
            this.radioButtonTam.Size = new System.Drawing.Size(46, 17);
            this.radioButtonTam.TabIndex = 3;
            this.radioButtonTam.TabStop = true;
            this.radioButtonTam.Text = "Tam";
            this.radioButtonTam.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 108);
            this.listBox1.TabIndex = 1;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // labelyolcular
            // 
            this.labelyolcular.AutoSize = true;
            this.labelyolcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyolcular.Location = new System.Drawing.Point(34, 181);
            this.labelyolcular.Name = "labelyolcular";
            this.labelyolcular.Size = new System.Drawing.Size(59, 17);
            this.labelyolcular.TabIndex = 2;
            this.labelyolcular.Text = "Yolcular";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxOkuladi);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(139, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 63);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Okul Adı";
            // 
            // textBoxOkuladi
            // 
            this.textBoxOkuladi.Location = new System.Drawing.Point(0, 35);
            this.textBoxOkuladi.Name = "textBoxOkuladi";
            this.textBoxOkuladi.Size = new System.Drawing.Size(100, 20);
            this.textBoxOkuladi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(145, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bakiye";
            // 
            // textBoxBakiye
            // 
            this.textBoxBakiye.Location = new System.Drawing.Point(139, 64);
            this.textBoxBakiye.Name = "textBoxBakiye";
            this.textBoxBakiye.Size = new System.Drawing.Size(100, 20);
            this.textBoxBakiye.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBakiye);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.radioButtonTam);
            this.Controls.Add(this.labelyolcular);
            this.Controls.Add(this.radioButtonogrenci);
            this.Controls.Add(this.radioButtonogretmen);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTam;
        private System.Windows.Forms.RadioButton radioButtonogrenci;
        private System.Windows.Forms.RadioButton radioButtonogretmen;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelyolcular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOkuladi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBakiye;
    }
}

