using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISM6225_Class_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int remainder;

            number1 = int.Parse(textBox1.Text);
            number2 = int.Parse(textBox2.Text);

            remainder = number1 % number2;

            label4.Text = remainder.ToString();
        }
    }
}
