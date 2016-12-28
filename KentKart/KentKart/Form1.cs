using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KentKart
{

  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Kart yolcu)
        {
            InitializeComponent();
        }
        OgrenciKart ogrenci = new OgrenciKart();
        OgretmenKart ogretmen = new OgretmenKart();
        Kart tam = new Kart();
        int kartid = 1;
       static List<string> yolcular = new List<string>();
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            if (radioButtonogrenci.Checked == true)
            {
                ogrenci.bakiye = Convert.ToDouble(textBoxBakiye.Text);
                ogrenci.KartID = kartid;
                kartid++;
                ogrenci.okulAdi = textBoxOkuladi.Text;
                ogrenci.kartturu = yolcutipi.ogrenci;
                listBox1.Items.Add(ogrenci);

                temizle();
            }
            else if (radioButtonogretmen.Checked==true)
            {
                ogretmen.bakiye = Convert.ToDouble(textBoxBakiye.Text);
                ogretmen.KartID = kartid;
                kartid++;
                ogretmen.kartturu = yolcutipi.ogretmen;
                listBox1.Items.Add(ogretmen);
                temizle();
            }
            else
            {
                tam.bakiye = Convert.ToDouble(textBoxBakiye.Text);
                tam.KartID = kartid;
                kartid++;
                tam.kartturu = yolcutipi.tam;
                listBox1.Items.Add(tam);
                temizle();
            }
        }

        private void radioButtonogrenci_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = radioButtonogrenci.Checked == true ? true : false;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
         Kart yolcu=(Kart)listBox1.SelectedItem;


                if (yolcu.kartturu == yolcutipi.ogrenci && (yolcu.bakiye - 1 >= 0))
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    ogrenci = (OgrenciKart)yolcu;
                    ogrenci.Okut();
                    listBox1.Items.Add(ogrenci);
                }
                else if (yolcu.kartturu == yolcutipi.ogretmen && (yolcu.bakiye - 2 >= 0))
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    ogretmen = (OgretmenKart)yolcu;
                    ogretmen.Okut();
                    listBox1.Items.Add(ogretmen);
                }
            else if (yolcu.kartturu==yolcutipi.tam &&(yolcu.bakiye-3>=0))
           
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    tam = (Kart)yolcu;
                    tam.Okut();
                    listBox1.Items.Add(tam);
                }
            else
            {
                MessageBox.Show("Yetersiz Bakiye!!");
                DialogResult result = MessageBox.Show("Bakiye Yüklemek İster Misin", "Bildirim Ekranı", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    Form2 frm2 = new Form2(yolcu);
                    frm2.Show();
                    this.Hide();
                    
                }
                else
                {

                }

            }


 }
        
        private void temizle()
        {
            textBoxBakiye.Clear();
            textBoxOkuladi.Clear();
        }
    }
}
