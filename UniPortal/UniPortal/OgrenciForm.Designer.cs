namespace UniPortal
{
    partial class OgrenciForm
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
            this.labelad = new System.Windows.Forms.Label();
            this.labelsoyad = new System.Windows.Forms.Label();
            this.labeltelefon = new System.Windows.Forms.Label();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxtelefon = new System.Windows.Forms.TextBox();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.dataGridViewbilgiler = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbilgiler)).BeginInit();
            this.SuspendLayout();
            // 
            // labelad
            // 
            this.labelad.AutoSize = true;
            this.labelad.Location = new System.Drawing.Point(37, 28);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(20, 13);
            this.labelad.TabIndex = 0;
            this.labelad.Text = "Ad";
            // 
            // labelsoyad
            // 
            this.labelsoyad.AutoSize = true;
            this.labelsoyad.Location = new System.Drawing.Point(37, 51);
            this.labelsoyad.Name = "labelsoyad";
            this.labelsoyad.Size = new System.Drawing.Size(37, 13);
            this.labelsoyad.TabIndex = 1;
            this.labelsoyad.Text = "Soyad";
            // 
            // labeltelefon
            // 
            this.labeltelefon.AutoSize = true;
            this.labeltelefon.Location = new System.Drawing.Point(37, 80);
            this.labeltelefon.Name = "labeltelefon";
            this.labeltelefon.Size = new System.Drawing.Size(43, 13);
            this.labeltelefon.TabIndex = 2;
            this.labeltelefon.Text = "Telefon";
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(92, 21);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(100, 20);
            this.textBoxad.TabIndex = 3;
            // 
            // textBoxtelefon
            // 
            this.textBoxtelefon.Location = new System.Drawing.Point(92, 77);
            this.textBoxtelefon.Name = "textBoxtelefon";
            this.textBoxtelefon.Size = new System.Drawing.Size(100, 20);
            this.textBoxtelefon.TabIndex = 4;
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(92, 51);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(100, 20);
            this.textBoxsoyad.TabIndex = 5;
            // 
            // dataGridViewbilgiler
            // 
            this.dataGridViewbilgiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbilgiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewbilgiler.Location = new System.Drawing.Point(21, 103);
            this.dataGridViewbilgiler.Name = "dataGridViewbilgiler";
            this.dataGridViewbilgiler.Size = new System.Drawing.Size(349, 150);
            this.dataGridViewbilgiler.TabIndex = 6;
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
            // buttonekle
            // 
            this.buttonekle.Location = new System.Drawing.Point(235, 41);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(75, 23);
            this.buttonekle.TabIndex = 7;
            this.buttonekle.Text = "Ekle";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // OgrenciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 289);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.dataGridViewbilgiler);
            this.Controls.Add(this.textBoxsoyad);
            this.Controls.Add(this.textBoxtelefon);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.labeltelefon);
            this.Controls.Add(this.labelsoyad);
            this.Controls.Add(this.labelad);
            this.Name = "OgrenciForm";
            this.Text = "OgrenciForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbilgiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelad;
        private System.Windows.Forms.Label labelsoyad;
        private System.Windows.Forms.Label labeltelefon;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.TextBox textBoxtelefon;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.DataGridView dataGridViewbilgiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button buttonekle;
    }
}