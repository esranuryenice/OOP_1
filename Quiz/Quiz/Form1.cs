using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Izsu : Form
    {
        public Izsu()
        {
            InitializeComponent();
        }
        
        musteri mstri = new musteri();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            mstri.AdSoyad = textBoxAboneAdi.Text;
            if (radioButton1.Checked)
            {
                mstri.abonetipi= radioButton1.Checked;
            }
            else
            {
                mstri.abonetipi = radioButton2.Checked;
            }
            mstri.ilkindex = int.Parse(textBoxIlkIndex.Text);
            mstri.sonindex = int.Parse(textBoxSonIndex.Text);
            
            
            double carpim;
            if (mstri.abonetipi==false)
            {
                carpim = (mstri.sonindex - mstri.ilkindex) * 0.3;
            }
            else
            {
                carpim = (mstri.sonindex - mstri.ilkindex) * 0.5;
            }
            listBoxOdemeListesi.Items.Add(mstri.AdSoyad + " " + carpim);

        }

        private void listBoxOdemeListesi_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ödemek İstiyormusunuz", " Onay Ekranı", MessageBoxButtons.OKCancel);
            if (result==DialogResult.OK)
            {
                listBoxOdemeListesi.Items.Clear();
                listBoxOdenenler.Items.Add(mstri);
            }
        }
    }
}
