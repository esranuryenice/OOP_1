using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba__OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Araba.yakitFİyat = 5;
            numericUpDown3.Enabled = false;
            numericUpDown3.Value = Convert.ToDecimal(Araba.yakitFİyat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cap = Convert.ToInt32(numericUpDown1.Value);
            double ortalama100km = Convert.ToDouble(numericUpDown2.Value);
            Araba a = new Araba(cap, ortalama100km);

           // a.yakitFİyat = Convert.ToDouble(numericUpDown3.Value);

            MessageBox.Show("Kapasite :" + a.yakitDepoKapasite + "\nOrtalama Tüketim :" + a.ortamalaTuketim100km + "\nYakit Fiyati :" + /*a.yakitFİyat +*/ "\nMaxMesafe :" + a.ToplamYol);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cap = Convert.ToInt32(numericUpDown1.Value);
            double ortalama100km = Convert.ToDouble(numericUpDown2.Value);
            Araba a = new Araba(cap, ortalama100km);

           // a.yakitFİyat = Convert.ToDouble(numericUpDown3.Value);




            double km = Convert.ToDouble(numericUpDown4.Value);
            labelUcret.Text = km + " km" + a.UcretHesaplama(km) + "₺ dir.";


        }

        
    }
}
