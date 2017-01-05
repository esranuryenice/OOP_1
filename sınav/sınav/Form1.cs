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
            panelyemekler.Visible = true;
            comboBoxyemek.Items.Add(" ");
            comboBoxyemek.Items.Add("KuruFasulye");
            comboBoxyemek.Items.Add("Tavuklu Pilav");
            comboBoxyemek.Items.Add("Simit Tost");
            comboBoxyemek.Items.Add("Lazanya");
            comboBoxicecek.Items.Add(" ");
            comboBoxicecek.Items.Add("Su");
            comboBoxicecek.Items.Add("Kola");
            comboBoxicecek.Items.Add("Limonata");
            comboBoxicecek.Items.Add("Çay");
            comboBoxicecek.Items.Add("Kahve");
            siparis s = new siparis();
            s.yemek = Convert.ToString(comboBoxyemek.SelectedItem);
            s.içecek = Convert.ToString(comboBoxicecek.SelectedItem);
            s.yemekadet = Convert.ToInt32(numericUpDownyemek.Value);
            s.icecekadet = Convert.ToInt32(numericUpDowniçecek.Value);
            Button secilenmasa = sender as Button;
            label9.Text = secilenmasa.Text;


        }

        private void buttonsiparisver_Click(object sender, EventArgs e)
        {
            List<double> siparişler = new List<double>();
            if (comboBoxicecek.SelectedItem != null&& comboBoxyemek.SelectedItem != null)
            {
                listBoxodeme.Items.Add(comboBoxicecek.SelectedItem + "\t " + numericUpDowniçecek.Value + " Adet");
                listBoxodeme.Items.Add(comboBoxyemek.SelectedItem + " \t" + numericUpDownyemek.Value + " Adet");
            }

            
               
                
            
        }

        private void buttonodemeyap_Click(object sender, EventArgs e)
        {

        }
    }
}
