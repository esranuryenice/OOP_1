﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ogrenci ogr1 = new ogrenci();
        ogrenci ogr2 = new ogrenci();


        private void Form1_Load(object sender, EventArgs e)
        {
            ogr1.ogrenciAdiSoyadi = "esranur yenice";
            ogr1.ogrenciNo = 1;
            ogr2.ogrenciAdiSoyadi = "enes yılmaz";
            ogr2.ogrenciNo = 2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ogr1.ogrenciAdiSoyadi+ " "+ ogr1.ogrenciNo);
            MessageBox.Show(ogr2.ogrenciAdiSoyadi + " " + ogr2.ogrenciNo);

        }

       
    }
}
