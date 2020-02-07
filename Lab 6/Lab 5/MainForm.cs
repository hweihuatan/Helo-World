// Programmer: Hwei Hua Tan 
// Project: Lab 5
// Date: 11/11/2019
// Description: Lab 5 practice exercise

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            PopulateBoxes();

            flavorsComboBox.SelectedIndex = 5;
        }

        private void PopulateBoxes()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Flavors.txt");
                while (!inputFile.EndOfStream)
                {
                    flavorsComboBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();

                inputFile = File.OpenText("Toppings.txt");
                while (!inputFile.EndOfStream)
                {
                    toppingsListBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Files were not loaded.");
                this.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText("Orders.txt");
                outputFile.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));

                if (sugarConeRadioButton.Checked)
                {
                    outputFile.WriteLine("Sugar Cone");
                }
                else
                {
                    outputFile.WriteLine("Waffle Cone");
                }

                outputFile.WriteLine(flavorsComboBox.SelectedItem.ToString());

                for (int count = 0; count < toppingsListBox.Items.Count; count++)
                {
                    if (toppingsListBox.GetSelected(count))
                    {
                        outputFile.WriteLine(toppingsListBox.Items[count]);
                    }
                }
                outputFile.WriteLine();
                outputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order was not saved.");
            }

            sugarConeRadioButton.Checked = true;
            flavorsComboBox.SelectedIndex = 5;
            toppingsListBox.ClearSelected();
            sugarConeRadioButton.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm myAboutForm = new AboutForm();
            myAboutForm.ShowDialog();
        }
    }
}
