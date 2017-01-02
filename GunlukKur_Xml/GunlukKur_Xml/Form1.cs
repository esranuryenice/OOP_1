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

namespace GunlukKur_Xml
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




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (comboBox1.SelectedItem.ToString() == "Dolar" )
            {
                dataGridView1.Rows.Add("Dolar", tarih.ToString("dd/MM/yyyy"), USD);
            }
            else if (comboBox1.SelectedItem.ToString() == "Euro")
            {
                dataGridView1.Rows.Add("EURO", tarih.ToString("dd/MM/yyyy"), EUR);
            }
            else
            {
                dataGridView1.Rows.Add("POUND", tarih.ToString("dd/MM/yyyy"), GBP);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var xmldoc = new XmlDocument();
            xmldoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            USD = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
             EUR = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            GBP = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
        }
    }
}
