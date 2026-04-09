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
            // описываем переменные
            
            double f, x, y;
            // пытаем преобразовать строку из textBox1.Text в целое число
            bool rez1 = double.TryParse(textBox1.Text, out x);
            if (rez1 == false) // если возникла ли ошибка преобразования
            {                  // то выводим сообщение и заканчиваем работу метода
                MessageBox.Show("Неверный формат числа " + textBox1.Text + "!");
                return; // заканчиваем работу метода
            }
            // пытаем преобразовать строку из textBox2.Text в целое число
            bool rez2 = double.TryParse(textBox2.Text, out y);
            if (rez2 == false) // если возникла ли ошибка преобразования
            {                  // то выводим сообщение и заканчиваем работу метода
                MessageBox.Show("Неверный формат числа " + textBox2.Text + "!");
                return; // заканчиваем работу метода
            }
            f = (5 * Math.Sin(x) + 3 * y) * 2;
            string cStr = f.ToString();
            label13.Text = cStr;
            return; // заканчиваем работу метода

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
