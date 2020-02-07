// Programmer: Hwei Hua Tan
// Project: Lab 3-1
// Date: Oct 4, 2019
// Description: Form for taking a pet care order

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_1
{
    public partial class Form1 : Form
    {
        // Declare class-level constants for later use in the program
        private const decimal FLEA_REMOVAL_PRICE = 5.00m;
        private const decimal NAIL_CLIPPING_PRICE = 4.50m;
        private const decimal SHAMPOO_PRICE = 4.00m;
        private const decimal FUR_TRIMMING_PRICE = 9.00m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Assign the service price values to labels on form
            fleaRemovalPriceLabel.Text = FLEA_REMOVAL_PRICE.ToString("c");
            nailClippingPriceLabel.Text = NAIL_CLIPPING_PRICE.ToString("c");
            shampooPriceLabel.Text = SHAMPOO_PRICE.ToString("c");
            furTrimmingPriceLabel.Text = FUR_TRIMMING_PRICE.ToString("c");
        }

        private void otherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Manage the situation when the "Other" radio button is selected
            if (otherRadioButton.Checked)
            {
                typeIfOtherLabel.Enabled = true;
                typeIfOtherTextBox.Enabled = true;
                typeIfOtherTextBox.Focus();
            }
            else
            {
                typeIfOtherLabel.Enabled = false;
                typeIfOtherTextBox.Enabled = false;
                typeIfOtherTextBox.Text = ""; //Clear contents of this text box
            }
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            // Declare and initialize local variable used to store total fee
            decimal totalFee = 0.00m;

            // Use if blocks to perform calculations necessary to determine the total fee
            if (fleaRemovalCheckBox.Checked)
            {
                totalFee += FLEA_REMOVAL_PRICE;
            }
            if(nailClippingCheckBox.Checked)
            {
                totalFee += NAIL_CLIPPING_PRICE;
            }
            if (shampooCheckBox.Checked) 
            {
                totalFee += SHAMPOO_PRICE;
            }
            if(furTrimmingCheckBox.Checked)
            {
                totalFee += FUR_TRIMMING_PRICE;
            }

            // Display total fee in label
            totalFeeLabel.Text = totalFee.ToString("c");

            // Send focus to Clear button
            clearButton.Focus();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear data entry controls and reset form to start-up appearance
            ownerNameTextBox.Text = "";
            ownerPhoneMaskedTextBox.Text = "";
            petNameTextBox.Text = "";
            petDOBMaskedTextBox.Text = "";
            catRadioButton.Checked = true;
            fleaRemovalCheckBox.Checked = false;
            nailClippingCheckBox.Checked = false;
            shampooCheckBox.Checked = false;
            furTrimmingCheckBox.Checked = false;
            totalFeeLabel.Text = "";

            // Send focus to first data entry control
            ownerNameTextBox.Focus();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            // Close form, end program
            this.Close();
        }
    }
}
