using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonoyna_Click(object sender, EventArgs e)
        {

            Random rastgelesayi = new Random();
           int sayi= rastgelesayi.Next(0,9 );
            MessageBox.Show(textBox1.Text +" " + sayi.ToString()+" "+"numaralı kişiyle eşleştin...");
            
          




        }

        private void listBoxseçilen_DoubleClick(object sender, EventArgs e)
        {

           

           listBoxseçilen.Items.Remove(listBoxseçilen.SelectedItem);
            
        }
    }
}
