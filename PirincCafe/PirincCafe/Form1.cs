﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PirincCafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxfrm1menu.Visible = false;
            labelmenu.Text = null;

        }

        private void buttongirisyap_Click(object sender, EventArgs e)
        {
            if (textBoxkullaniciadi.Text=="admin" && textBoxsifre.Text=="1234")
            {
                
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre Hatalı");
            }
        }
    }
}
