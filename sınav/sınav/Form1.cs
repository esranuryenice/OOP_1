using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav
{
    public partial class Form1 : Form
    {
        //private string masano;

        public Form1()
        {
            InitializeComponent();
        }

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

            if (comboBoxicecek.SelectedItem != null&& comboBoxyemek.SelectedItem != null)
            {
                listBoxodeme.Items.Add(comboBoxicecek.SelectedItem + "\t " + numericUpDowniçecek.Value + " Adet");
                listBoxodeme.Items.Add(comboBoxyemek.SelectedItem + " \t" + numericUpDownyemek.Value + " Adet");
            }
            else if (listBoxodeme.Items==null)
            {
                listBoxodeme.Items.Remove(-1);
            }
         
               
                
            
        }
    }
}
