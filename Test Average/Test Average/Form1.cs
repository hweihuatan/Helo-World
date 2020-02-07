using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Button1_Click(object sender, EventArgs e)

        {
            try
            {
                int test1score;
                int test2score;
                int test3score;
                double AverageTestScore;

                test1score = int.Parse(Test1TextBox.Text);
                test2score = int.Parse(Test2TextBox.Text);
                test3score = int.Parse(Test3TextBox.Text);

                AverageTestScore = (test1score + test2score + test3score) / 3;

                ResultTextBox.Text = AverageTestScore.ToString();
            }
            catch
            {
                MessageBox.Show("There was a data input error.");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            Test1TextBox.Text = "";
            Test2TextBox.Text = "";
            Test3TextBox.Text = "";
            Test1TextBox.Focus();

        }
    }
}
