namespace PirincCafe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxanayemekler = new System.Windows.Forms.ListBox();
            this.listBoxsalatalar = new System.Windows.Forms.ListBox();
            this.listBoxtatlilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ana Yemekler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salatalar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tatlılar";
            // 
            // listBoxanayemekler
            // 
            this.listBoxanayemekler.FormattingEnabled = true;
            this.listBoxanayemekler.Location = new System.Drawing.Point(12, 29);
            this.listBoxanayemekler.Name = "listBoxanayemekler";
            this.listBoxanayemekler.Size = new System.Drawing.Size(120, 277);
            this.listBoxanayemekler.TabIndex = 3;
            // 
            // listBoxsalatalar
            // 
            this.listBoxsalatalar.FormattingEnabled = true;
            this.listBoxsalatalar.Location = new System.Drawing.Point(262, 25);
            this.listBoxsalatalar.Name = "listBoxsalatalar";
            this.listBoxsalatalar.Size = new System.Drawing.Size(120, 277);
            this.listBoxsalatalar.TabIndex = 4;
            // 
            // listBoxtatlilar
            // 
            this.listBoxtatlilar.FormattingEnabled = true;
            this.listBoxtatlilar.Location = new System.Drawing.Point(509, 25);
            this.listBoxtatlilar.Name = "listBoxtatlilar";
            this.listBoxtatlilar.Size = new System.Drawing.Size(120, 277);
            this.listBoxtatlilar.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 352);
            this.Controls.Add(this.listBoxtatlilar);
            this.Controls.Add(this.listBoxsalatalar);
            this.Controls.Add(this.listBoxanayemekler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxanayemekler;
        private System.Windows.Forms.ListBox listBoxsalatalar;
        private System.Windows.Forms.ListBox listBoxtatlilar;
    }
}