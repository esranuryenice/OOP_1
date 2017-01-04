using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniPortal
{
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.ad = textBoxad.Text;
            o.soyad = textBoxsoyad.Text;
            o.telefon = textBoxtelefon.Text;
            dataGridViewbilgiler.Rows.Add(o.ad, o.soyad, o.telefon);
        }
    }
}
