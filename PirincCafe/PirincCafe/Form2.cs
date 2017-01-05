using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PirincCafe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                listBoxanayemekler.Items.Add(textBox1.Text);
                textBox1.Text = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                listBoxsalatalar.Items.Add(textBox2.Text);
                textBox2.Text = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                listBoxtatlilar.Items.Add(textBox3.Text);
                textBox3.Text = null;


        }
    }
}
