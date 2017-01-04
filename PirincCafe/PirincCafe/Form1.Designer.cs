namespace PirincCafe
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
            this.textBoxkullaniciadi = new System.Windows.Forms.TextBox();
            this.textBoxsifre = new System.Windows.Forms.TextBox();
            this.labelsifre = new System.Windows.Forms.Label();
            this.buttongirisyap = new System.Windows.Forms.Button();
            this.labelmenu = new System.Windows.Forms.Label();
            this.listBoxfrm1menu = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // textBoxkullaniciadi
            // 
            this.textBoxkullaniciadi.Location = new System.Drawing.Point(82, 37);
            this.textBoxkullaniciadi.Name = "textBoxkullaniciadi";
            this.textBoxkullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.textBoxkullaniciadi.TabIndex = 1;
            // 
            // textBoxsifre
            // 
            this.textBoxsifre.Location = new System.Drawing.Point(82, 76);
            this.textBoxsifre.Name = "textBoxsifre";
            this.textBoxsifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxsifre.TabIndex = 3;
            // 
            // labelsifre
            // 
            this.labelsifre.AutoSize = true;
            this.labelsifre.Location = new System.Drawing.Point(28, 83);
            this.labelsifre.Name = "labelsifre";
            this.labelsifre.Size = new System.Drawing.Size(28, 13);
            this.labelsifre.TabIndex = 2;
            this.labelsifre.Text = "Şifre";
            // 
            // buttongirisyap
            // 
            this.buttongirisyap.Location = new System.Drawing.Point(91, 122);
            this.buttongirisyap.Name = "buttongirisyap";
            this.buttongirisyap.Size = new System.Drawing.Size(75, 23);
            this.buttongirisyap.TabIndex = 4;
            this.buttongirisyap.Text = "Giriş Yap";
            this.buttongirisyap.UseVisualStyleBackColor = true;
            this.buttongirisyap.Click += new System.EventHandler(this.buttongirisyap_Click);
            // 
            // labelmenu
            // 
            this.labelmenu.AutoSize = true;
            this.labelmenu.Location = new System.Drawing.Point(356, 9);
            this.labelmenu.Name = "labelmenu";
            this.labelmenu.Size = new System.Drawing.Size(34, 13);
            this.labelmenu.TabIndex = 5;
            this.labelmenu.Text = "Menü";
            // 
            // listBoxfrm1menu
            // 
            this.listBoxfrm1menu.FormattingEnabled = true;
            this.listBoxfrm1menu.Location = new System.Drawing.Point(266, 25);
            this.listBoxfrm1menu.Name = "listBoxfrm1menu";
            this.listBoxfrm1menu.Size = new System.Drawing.Size(220, 264);
            this.listBoxfrm1menu.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Menü Eklemek İçin Giriş Yapmalısınız!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxfrm1menu);
            this.Controls.Add(this.labelmenu);
            this.Controls.Add(this.buttongirisyap);
            this.Controls.Add(this.textBoxsifre);
            this.Controls.Add(this.labelsifre);
            this.Controls.Add(this.textBoxkullaniciadi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxkullaniciadi;
        private System.Windows.Forms.TextBox textBoxsifre;
        private System.Windows.Forms.Label labelsifre;
        private System.Windows.Forms.Button buttongirisyap;
        private System.Windows.Forms.Label labelmenu;
        private System.Windows.Forms.ListBox listBoxfrm1menu;
        private System.Windows.Forms.Label label2;
    }
}

