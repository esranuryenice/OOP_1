namespace odev
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
            this.listBoxseçilen = new System.Windows.Forms.ListBox();
            this.buttonoyna = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxseçilen
            // 
            this.listBoxseçilen.FormattingEnabled = true;
            this.listBoxseçilen.Items.AddRange(new object[] {
            "1.Esranur",
            "2.Çeyiz",
            "3.Halil",
            "4.Yankı",
            "5.Atakan",
            "6.Bengisu",
            "7.Çeyiz",
            "8.Ozan K",
            "9.Cemal",
            "10.Merve"});
            this.listBoxseçilen.Location = new System.Drawing.Point(138, 25);
            this.listBoxseçilen.Name = "listBoxseçilen";
            this.listBoxseçilen.Size = new System.Drawing.Size(120, 199);
            this.listBoxseçilen.TabIndex = 1;
            this.listBoxseçilen.DoubleClick += new System.EventHandler(this.listBoxseçilen_DoubleClick);
            // 
            // buttonoyna
            // 
            this.buttonoyna.Location = new System.Drawing.Point(12, 230);
            this.buttonoyna.Name = "buttonoyna";
            this.buttonoyna.Size = new System.Drawing.Size(246, 23);
            this.buttonoyna.TabIndex = 2;
            this.buttonoyna.Text = "OYNA";
            this.buttonoyna.UseVisualStyleBackColor = true;
            this.buttonoyna.Click += new System.EventHandler(this.buttonoyna_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "İsmini Gir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonoyna);
            this.Controls.Add(this.listBoxseçilen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxseçilen;
        private System.Windows.Forms.Button buttonoyna;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

