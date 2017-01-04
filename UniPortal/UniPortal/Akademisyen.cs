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
    public partial class Akademisyen : Form
    {
        public Akademisyen()
        {
            InitializeComponent();
        }

        private void buttonekleaka_Click(object sender, EventArgs e)
        {
            OgretimGorevlisi ogr = new OgretimGorevlisi();
            ogr.ad = textBoxadaka.Text;
            ogr.soyad = textBoxsoyadaka.Text;
            ogr.telefon = textBoxtelefonaka.Text;
            ogr.gorevi = textBoxgorevaka.Text;
            ogr.bolumu = textBoxbolumaka.Text;
            dataGridViewbilgileraka.Rows.Add(ogr.ad,ogr.soyad,ogr.telefon,ogr.gorevi,ogr.bolumu);
           
        }
    }
}
