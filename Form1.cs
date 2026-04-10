using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double f, x, y;
            bool rez1 = double.TryParse(textBox1.Text, out x);
            if (rez1 == false) 
            {                  
                MessageBox.Show("Неверный формат числа " + textBox1.Text + "!");
                return; 
            }

            bool rez2 = double.TryParse(textBox2.Text, out y);
            if (rez2 == false) 
            {                 
                MessageBox.Show("Неверный формат числа " + textBox2.Text + "!");
                return; 
            }
            f = (5 * Math.Sin(x) + 3 * y) * 2;
            string fStr = f.ToString();
            label13.Text = fStr;
            return; 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
