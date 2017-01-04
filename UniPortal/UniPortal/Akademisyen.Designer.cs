namespace UniPortal
{
    partial class Akademisyen
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
            this.buttonekleaka = new System.Windows.Forms.Button();
            this.dataGridViewbilgileraka = new System.Windows.Forms.DataGridView();
            this.textBoxsoyadaka = new System.Windows.Forms.TextBox();
            this.textBoxtelefonaka = new System.Windows.Forms.TextBox();
            this.textBoxadaka = new System.Windows.Forms.TextBox();
            this.textBoxbolumaka = new System.Windows.Forms.TextBox();
            this.textBoxgorevaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbilgileraka)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonekleaka
            // 
            this.buttonekleaka.Location = new System.Drawing.Point(182, 34);
            this.buttonekleaka.Name = "buttonekleaka";
            this.buttonekleaka.Size = new System.Drawing.Size(75, 23);
            this.buttonekleaka.TabIndex = 12;
            this.buttonekleaka.Text = "Ekle";
            this.buttonekleaka.UseVisualStyleBackColor = true;
            this.buttonekleaka.Click += new System.EventHandler(this.buttonekleaka_Click);
            // 
            // dataGridViewbilgileraka
            // 
            this.dataGridViewbilgileraka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbilgileraka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewbilgileraka.Location = new System.Drawing.Point(2, 148);
            this.dataGridViewbilgileraka.Name = "dataGridViewbilgileraka";
            this.dataGridViewbilgileraka.Size = new System.Drawing.Size(544, 150);
            this.dataGridViewbilgileraka.TabIndex = 11;
            // 
            // textBoxsoyadaka
            // 
            this.textBoxsoyadaka.Location = new System.Drawing.Point(56, 40);
            this.textBoxsoyadaka.Name = "textBoxsoyadaka";
            this.textBoxsoyadaka.Size = new System.Drawing.Size(100, 20);
            this.textBoxsoyadaka.TabIndex = 10;
            // 
            // textBoxtelefonaka
            // 
            this.textBoxtelefonaka.Location = new System.Drawing.Point(56, 70);
            this.textBoxtelefonaka.Name = "textBoxtelefonaka";
            this.textBoxtelefonaka.Size = new System.Drawing.Size(100, 20);
            this.textBoxtelefonaka.TabIndex = 9;
            // 
            // textBoxadaka
            // 
            this.textBoxadaka.Location = new System.Drawing.Point(56, 14);
            this.textBoxadaka.Name = "textBoxadaka";
            this.textBoxadaka.Size = new System.Drawing.Size(100, 20);
            this.textBoxadaka.TabIndex = 8;
            // 
            // textBoxbolumaka
            // 
            this.textBoxbolumaka.Location = new System.Drawing.Point(56, 96);
            this.textBoxbolumaka.Name = "textBoxbolumaka";
            this.textBoxbolumaka.Size = new System.Drawing.Size(100, 20);
            this.textBoxbolumaka.TabIndex = 13;
            // 
            // textBoxgorevaka
            // 
            this.textBoxgorevaka.Location = new System.Drawing.Point(56, 122);
            this.textBoxgorevaka.Name = "textBoxgorevaka";
            this.textBoxgorevaka.Size = new System.Drawing.Size(100, 20);
            this.textBoxgorevaka.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bölüm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Görev";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ad";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Soyad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefon";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Bölüm";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Görevi";
            this.Column5.Name = "Column5";
            // 
            // Akademisyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 330);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxgorevaka);
            this.Controls.Add(this.textBoxbolumaka);
            this.Controls.Add(this.buttonekleaka);
            this.Controls.Add(this.dataGridViewbilgileraka);
            this.Controls.Add(this.textBoxsoyadaka);
            this.Controls.Add(this.textBoxtelefonaka);
            this.Controls.Add(this.textBoxadaka);
            this.Name = "Akademisyen";
            this.Text = "Akademisyen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbilgileraka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonekleaka;
        private System.Windows.Forms.DataGridView dataGridViewbilgileraka;
        private System.Windows.Forms.TextBox textBoxsoyadaka;
        private System.Windows.Forms.TextBox textBoxtelefonaka;
        private System.Windows.Forms.TextBox textBoxadaka;
        private System.Windows.Forms.TextBox textBoxbolumaka;
        private System.Windows.Forms.TextBox textBoxgorevaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}