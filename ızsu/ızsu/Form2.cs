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
    public partial class Form2 : Form
    {
        public Form2 (musteribilgileri aboneForm2)
        {
            InitializeComponent();
            textBoxAbone_No.Text = aboneForm2.AboneNo;
            textBoxAdSoyad.Text = aboneForm2.AdSoyad;
            textBoxtoplamodeme.Text = aboneForm2.OdemeHesapla(aboneForm2.OncekiSayac, aboneForm2.SonrakiSayac, aboneForm2.AboneTuru).ToString();

        }
        
       
    }
}
