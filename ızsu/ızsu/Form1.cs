using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ızsu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            musteribilgileri _abone = new musteribilgileri();
            _abone.AboneNo = textBox1.Text;
            _abone.AdSoyad = textBox2.Text;
            _abone.OncekiSayac = int.Parse(textBox4.Text);
            _abone.SonrakiSayac =int.Parse( textBox3.Text);


            string aboneTuru = radioButton1.Checked == true ? "EV" : "KURUM";
            aboneTuru = radioButton2.Checked == true ? "KURUM" : "EV";
            _abone. AboneTuru = aboneTuru;
            listBox1.Items.Add(_abone);
          
                         
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            musteribilgileri _abone = (musteribilgileri)listBox1.SelectedItem;
            double odeme = _abone.OdemeHesapla(_abone.OncekiSayac, _abone.SonrakiSayac, _abone.AboneTuru);
            DialogResult result = MessageBox.Show("Ödeme Tutarı:" + odeme + "\nÖdeme Yapmak İstiyormusunuz", "Ödeme Ekranı", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                
                Form2 frm = new Form2(_abone);
                frm.Show();
                
                

            }
        }

    

        
    }
}
