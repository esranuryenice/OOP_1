﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yapıcımetod
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void buttonolustur_Click(object sender, EventArgs e)
        {
            string yenipozisyon = comboBoxpozisyon.SelectedItem.ToString();
            Oyuncu _oyuncu = new Oyuncu("Şehmuz","Altay");
            MessageBox.Show(_oyuncu.adi+ " "+ _oyuncu.takim);


           
        }
    }
}
