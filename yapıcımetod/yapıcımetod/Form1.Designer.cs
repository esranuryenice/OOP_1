namespace yapıcımetod
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
            this.labelpozisyon = new System.Windows.Forms.Label();
            this.buttonolustur = new System.Windows.Forms.Button();
            this.comboBoxpozisyon = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelpozisyon
            // 
            this.labelpozisyon.AutoSize = true;
            this.labelpozisyon.Location = new System.Drawing.Point(36, 45);
            this.labelpozisyon.Name = "labelpozisyon";
            this.labelpozisyon.Size = new System.Drawing.Size(49, 13);
            this.labelpozisyon.TabIndex = 1;
            this.labelpozisyon.Text = "Pozisyon";
            // 
            // buttonolustur
            // 
            this.buttonolustur.Location = new System.Drawing.Point(52, 73);
            this.buttonolustur.Name = "buttonolustur";
            this.buttonolustur.Size = new System.Drawing.Size(160, 23);
            this.buttonolustur.TabIndex = 2;
            this.buttonolustur.Text = "Oluştur";
            this.buttonolustur.UseVisualStyleBackColor = true;
            this.buttonolustur.Click += new System.EventHandler(this.buttonolustur_Click);
            // 
            // comboBoxpozisyon
            // 
            this.comboBoxpozisyon.FormattingEnabled = true;
            this.comboBoxpozisyon.Items.AddRange(new object[] {
            "Kale",
            "Defans",
            "Orta Saha",
            "Forvet"});
            this.comboBoxpozisyon.Location = new System.Drawing.Point(91, 42);
            this.comboBoxpozisyon.Name = "comboBoxpozisyon";
            this.comboBoxpozisyon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxpozisyon.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBoxpozisyon);
            this.Controls.Add(this.buttonolustur);
            this.Controls.Add(this.labelpozisyon);
            this.Name = "Form1";
            this.Text = "Oyuncu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelpozisyon;
        private System.Windows.Forms.Button buttonolustur;
        private System.Windows.Forms.ComboBox comboBoxpozisyon;
    }
}

