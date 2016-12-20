using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzHakikiUlusoy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<musteri> MusteriListesi = new List<musteri>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            musteri mstri = new musteri();
            mstri.AdSoyad = TxtAdSoyad.Text;
            mstri.Cinsiyet = radioButtonErkek.Checked == false ? true : false;
            mstri.OtobusTuru = comboBoxOtobusTuru.SelectedItem.ToString();
            MusteriListesi.Add(mstri);
            listBoxmusteriler.Items.Add(mstri);
            TxtAdSoyad.Clear();
            TxtAdSoyad.Focus();// tekrardan imlecin orda olmasını sağlıyor.
        }

        private void listBoxmusteriler_DoubleClick(object sender, EventArgs e)
        {
            listBoxmusteriler.Items.RemoveAt(listBoxmusteriler.SelectedIndex);
        }
    }
}
