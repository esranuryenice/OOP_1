using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace sınav
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument xmldoc;
        DateTime tarih;
        string USD;
        string EUR;
        string GBP;
        private string[] yemekler = { "Kuru Fasülye", "Tavuklu Pilav", "Kaşarlı Tost", "Lazanya" };
        private string[] icecekler = { "Su", "Kola", "Limonata", "Çay", "Kahve" };
        private masa m;

        private void Form1_Load(object sender, EventArgs e)
        {
           
            panelyemekler.Visible = false;
            int counter = 1;
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 6; j++)
                {

                    Button btn = new Button();
                    btn.Click += Button_Click;
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Text = counter + " ";
                    btn.Left = (btn.Width * j);
                    btn.Top = (btn.Height * i);
                    groupBoxmasalar.Controls.Add(btn);
                    counter++;



            }
                
            }
            var xmldoc = new XmlDocument();
            xmldoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            EUR = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            GBP = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            label6.Text = USD;
            label7.Text = EUR;
            label8.Text = GBP;

        }
        private void Button_Click(Object sender, EventArgs e)
        {
            Button secilenmasa = sender as Button;
            masa[] masalar = new masa[16];
            masa m = new masa();
            panelyemekler.Visible = true;
            if (masalar[int.Parse(secilenmasa.Text)] != null)
            {
                foreach (var item in masalar[int.Parse(secilenmasa.Text)].siparisler)
                {
                    listBoxodeme.Items.Add(item);
                }
            }
           
            label9.Text = secilenmasa.Text;


            comboBoxyemek.Items.AddRange(yemekler);
            comboBoxicecek.Items.AddRange(icecekler);


        }

        private void buttonsiparisver_Click(object sender, EventArgs e)
        {
            siparis s = new siparis();
            m = new masa();
            if (comboBoxyemek.SelectedItem != null && numericUpDownyemek.Value != 0)
            {
                s.siparisadi = comboBoxyemek.SelectedItem.ToString();
                s.adet = int.Parse(numericUpDownyemek.Value.ToString());
                s.adetucret = s.adet * s.ucret;
                m.hesapla += s.adetucret;
                m.siparisler.Add(s);
            }
            if (comboBoxicecek.SelectedItem != null && numericUpDowniçecek.Value != 0)
            {
                s = new siparis();
                s.siparisadi = comboBoxicecek.SelectedItem.ToString();
                s.adet = int.Parse(numericUpDowniçecek.Value.ToString());
                s.adetucret = s.adet * s.ucret;
                m.hesapla += s.adetucret;
                m.siparisler.Add(s);

            }
            foreach (var item in m.siparisler)
            {
                listBoxodeme.Items.Add(item);
            }

            masa _masa = new masa();
            masa[] masalar = new masa[16];
            if (masalar[int.Parse(label9.Text)] != null)
            {
                _masa = masalar[int.Parse(label9.Text)];
                foreach (var item in m.siparisler)
                {
                    _masa.hesapla += item.adetucret;
                    _masa.siparisler.Add(item);
                }
            }
            else
            {
                _masa = m;
                masalar[int.Parse(label9.Text)] = _masa;
            }
            //comboBoxyemek.SelectedIndex = -1;
            //comboBoxicecek.SelectedIndex = -1;
            //numericUpDownyemek.Value = 0;
            //numericUpDowniçecek.Value = 0;

        }

        private void buttonodemeyap_Click(object sender, EventArgs e)
        {
            masa[] masalar = new masa[16];
            if (parabirimi != null)
            {

                DialogResult result = MessageBox.Show("Tutar: " + parabirimi + " " +  "\nÖdeme yapmak ister misiniz?", "Ödeme Ekranı", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    masalar[int.Parse(label9.Text)] = null;
                    listBoxodeme.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Lütfen para birimi seçiniz.");
            }
        }
        string parabirimi;
        private double Hesapla(double value)
        {

            double total = 0;

            if (radioButton1.Checked == true)
            {
                total = value;
                parabirimi = "TL";
               
            }

            return total;
        }
         
    }

       
    }
 

