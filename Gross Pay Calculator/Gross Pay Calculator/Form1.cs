using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gross_Pay_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            decimal hoursWorked, basePay, rate, otHours, hours, grossPay;
            hoursWorked = decimal.Parse(hoursTextbox.Text);

            if(hoursWorked>40)
            {


            }
        }
    }
}
