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

namespace Lab_4
{
    public partial class Form1 : Form
    {
        //Declare class-level constants
        private const decimal STATE_SALES_TAX_RATE = 0.06m;
        private const decimal HILLSBOROUGH_SALES_TAX_RATE = 0.01m;
        private const decimal PASCO_SALES_TAX_RATE = 0m;
        private const decimal POLK_SALES_TAX_RATE = 0.005m;
        private const decimal RESIDENTIAL_COMMISSION_RATE = 0.06m;
        private const decimal COMMERCIAL_COMMISSION_RATE = 0.05m;

        //Declare class-level variables
        private decimal propertyPrice = 0m;
        private decimal stateSalesTax = 0m;
        private decimal countySalesTax = 0m;
        private decimal commission = 0m;
        private decimal totalPrice = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        //Execute immediately upon program startup
        private void Form1_Load(object sender, EventArgs e)
        {
            //Display current date
            saleDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            //Disable Save button until property price is updated
            saveButton.Enabled = false;

            //Show focus on property price
            propertyPriceTextBox.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile; //Declare object for use in writing file
                outputFile = File.AppendText("Properties.txt");
                //Write all data to file
                outputFile.WriteLine("Date: " + saleDateMaskedTextBox.Text);
                outputFile.WriteLine("Property Price: " + propertyPrice.ToString("c"));
                outputFile.WriteLine("State Sales Tax: " + stateSalesTax.ToString("c"));
                outputFile.WriteLine("County Sales Tax: " + countySalesTax.ToString("c"));
                outputFile.WriteLine("Commission: " + commission.ToString("c"));
                outputFile.WriteLine("Total Price: " + totalPrice.ToString("c"));
                outputFile.WriteLine();
                outputFile.Close();

                //Display confirmation message after saved
                MessageBox.Show("Data successfully saved to file.", "Confirmation", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch
            {
                //Display message if error occurs when attempting to write file
                MessageBox.Show("There was an error when attempting to write file.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void residentialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void hillsboroughRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void pascoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void propertyPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateTotals();
            saveButton.Focus();
        }

        //Custom method to update total fields
        private void UpdateTotals()
        {
            //Read the price entered by user
            if(decimal.TryParse(propertyPriceTextBox.Text,out propertyPrice))
            {
                

                stateSalesTax = propertyPrice * STATE_SALES_TAX_RATE;

                //Calculate county sales tax amount
                if (hillsboroughRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * HILLSBOROUGH_SALES_TAX_RATE;
                }
                else if(pascoRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * PASCO_SALES_TAX_RATE;
                }
                else if (polkRradioButton.Checked)
                {
                    countySalesTax = propertyPrice * POLK_SALES_TAX_RATE;
                }

                //Calculate commission
                if (residentialRadioButton.Checked)
                {
                    commission = propertyPrice * RESIDENTIAL_COMMISSION_RATE;
                }
                else
                {
                    commission = propertyPrice * COMMERCIAL_COMMISSION_RATE;
                }

                //Calculate total price
                totalPrice = propertyPrice + stateSalesTax + countySalesTax + commission;

                //Display values in currencies
                stateSalesTaxLabel.Text = stateSalesTax.ToString("c");
                countySalesTaxLabel.Text = countySalesTax.ToString("c");
                commissionLabel.Text = commission.ToString("c");
                totalPriceLabel.Text = totalPrice.ToString("c");

                //Verify that price greater than zero has been entered
                if (propertyPrice > 0)
                {
                    saveButton.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("You must enter a numeric value for Property Price." +
                    "\n" + "Enter digits only (no dollar sign) for Property Price.",
                    "Blank value or non-numeric character entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //Send focus to property price text box
                propertyPriceTextBox.Focus();
            }
        }

        //Custom method to clear form
        private void ClearForm()
        {
            //Clear controls and reset form to original state
            saleDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            residentialRadioButton.Checked = true;
            hillsboroughRadioButton.Checked = true;
            propertyPriceTextBox.Text = "0.00";
            stateSalesTaxLabel.Text ="$0.00";
            countySalesTaxLabel.Text = "$0.00";
            commissionLabel.Text = "$0.00";
            totalPriceLabel.Text = "$0.00";
            saveButton.Enabled = false;
            propertyPriceTextBox.Focus();
        }
    }
}
