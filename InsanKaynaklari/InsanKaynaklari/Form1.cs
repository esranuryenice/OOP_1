using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownSatisAdedi.Enabled = false;
            buttongüncelle.Enabled = false;
        }

        private void listBoxElemanEkle_DoubleClick(object sender, EventArgs e)
        {
            SatisTemsilcisi st = (SatisTemsilcisi)listBoxElemanEkle.SelectedItem;

            numericUpDownMaas.Enabled = false;
            numericUpDownSSKNo.Enabled = false;
            numericUpDownSatisAdedi.Enabled = true;
            buttongüncelle.Enabled = true;

            numericUpDownSSKNo.Value = st.sskNo;
            numericUpDownMaas.Value = Convert.ToDecimal(st.maas);
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SatisTemsilcisi st = new SatisTemsilcisi();

            st.SatisDepartmanı = comboBoxElemanTuru.SelectedItem.ToString();
            st.maas = Convert.ToDouble(numericUpDownMaas.Value);
            st.sskNo = Convert.ToInt32(numericUpDownSSKNo.Value);
            listBoxElemanEkle.Items.Add(st);
        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            SatisTemsilcisi st = (SatisTemsilcisi)listBoxElemanEkle.SelectedItem;
            int satisadedi =Convert.ToInt32(numericUpDownSatisAdedi.Value);
            numericUpDownMaas.Value = Convert.ToDecimal(st.ZamYap(satisadedi));
        }
    }
}
