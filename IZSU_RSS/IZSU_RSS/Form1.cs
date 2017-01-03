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

namespace IZSU_RSS
{
    public partial class Form1 : Form
    {
        XmlDocument xmlDoc = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttongetir_Click(object sender, EventArgs e)
        {
            XmlNodeList haberlertitleelist = xmlDoc.SelectNodes("//channel/item/title");
            
            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=1");
            for (int i = 0; i < haberlertitleelist.Count; i++)
            {
                Haberler h = new Haberler(haberlertitleelist[i].InnerText);
                listBox2.Items.Add(h);
            }
            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=3");
            XmlNodeList titlelist = xmlDoc.SelectNodes("//channel/item/title");
            XmlNodeList descriptionlist = xmlDoc.SelectNodes("//channel/item/description");
            XmlNodeList datelist = xmlDoc.SelectNodes("//channel/item/pubDate");
            baraj.tarih = Convert.ToDateTime(datelist[0].InnerText);
            label1.Text = "Tarih :" + datelist[0].InnerText;
            for (int i = 0; i < titlelist.Count; i++)
            {
                baraj b = new baraj(titlelist[i].InnerText,descriptionlist[i].InnerText);
                listBox1.Items.Add(b);
            }


            XmlNodeList sukesintilerititlelist = xmlDoc.SelectNodes("//channel/item/title");
            

            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=2");
            for (int i = 0; i < sukesintilerititlelist.Count; i++)
            {
                Su_Kesintileri s = new Su_Kesintileri(sukesintilerititlelist[i].InnerText);
                listBox3.Items.Add(s);
            }
          
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            XmlNodeList sukesintileridescritionlist = xmlDoc.SelectNodes("//channel/item/description");
            int i = listBox3.SelectedIndex;
            webBrowser1.DocumentText = sukesintileridescritionlist[i].InnerText;
        }
    }
}
