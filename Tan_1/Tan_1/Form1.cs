// Programmer: Hwei Hua Tan
// Project: Tan_1
// Due date: Oct 1, 2019
// Description: Individual Assignment 1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tan_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare local constant
                const decimal TAX_RATE = 0.07m;

                // Declare local variables
                int lengthstay;
                decimal nightlyrate, roomcharges, minibar, telephone, misc, addcharges, subtotal, taxamount, total;

                // Get values from text box
                lengthstay = int.Parse(lengthStayTextBox.Text);
                nightlyrate = decimal.Parse(nightlyRateTextBox.Text);
                minibar = decimal.Parse(miniBarTextBox.Text);
                telephone = decimal.Parse(telephoneTextBox.Text);
                misc = decimal.Parse(miscTextBox.Text);

                // Calculate billing summary
                roomcharges = lengthstay * nightlyrate;
                addcharges = minibar + telephone + misc;
                subtotal = roomcharges + addcharges;
                taxamount = subtotal * TAX_RATE;
                total = subtotal + taxamount;

                // Display billing summary
                roomChargesLabel.Text = roomcharges.ToString("c");
                addChargesLabel.Text = addcharges.ToString("c");
                subtotalLabel.Text = subtotal.ToString("c");
                taxLabel.Text = taxamount.ToString("c");
                totalLabel.Text = total.ToString("c");

                // Send focus to Clear button
                clearButton.Focus();
            }
            catch
            {
                // Display error message
                MessageBox.Show("There is one or more data input error.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear all data entry boxes and labels
            checkoutTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            roomNoTextBox.Text = "";
            lengthStayTextBox.Text = "";
            nightlyRateTextBox.Text = "";
            miniBarTextBox.Text = "";
            telephoneTextBox.Text = "";
            miscTextBox.Text = "";
            roomChargesLabel.Text = "";
            addChargesLabel.Text = "";
            subtotalLabel.Text = "";
            taxLabel.Text = "";
            totalLabel.Text = "";

            // Send focus to first data entry box
            checkoutTextBox.Focus();

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions:\n" +
                "\n" +
                "1. Enter the guest's check-out date in mm/dd/yyyy format.\n" +
                "2. Enter guest's first and last name.\n" +
                "3. Room No. should always be 3 digits in length (eg.205).\n" +
                "4. Enter the number of nights the guest has stayed at the motel.\n" +
                "5. Enter the nightly dollar rate charged for the room.\n" +
                "6. Enter any optional charges to Mini bar, Telephone, and Miscellaneous(in dollar amount).\n" +
                "7. Click the Total button to generate the Billing Summary.\n" +
                "8. Click the Clear button to clear all data entry.\n" +
                "9. Click Exit to close the form.");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit form
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
