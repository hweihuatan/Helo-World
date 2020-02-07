// Programmer: Hwei Hua Tan
// Project: Tan_2
// Description: Individual Assignment #2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tan_2
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        // Declare class-level constants
        private const decimal IN_STATE_CHARGE = 59.00m;
        private const decimal OUT_OF_STATE_CHARGE = 109.00m;

        // Declare class-level variables
        private string registrationterm, residencestatus, creditcardtype;
        private int totalcourses;
        private decimal pricepercourse, totalprice;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Assign the course price values to labels on form
            inStatePriceLabel.Text = IN_STATE_CHARGE.ToString("c");
            outOfStatePriceLabel.Text = OUT_OF_STATE_CHARGE.ToString("c");
        }

        private void inStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (inStateRadioButton.Checked)
            {
                pricepercourse = IN_STATE_CHARGE;
                residencestatus = inStateRadioButton.Text;
            }
            else
            {
                pricepercourse = OUT_OF_STATE_CHARGE;
                residencestatus = outOfStateRadioButton.Text;
            }
        }

        private void selection_changed(object sender, EventArgs e)
        {
            totalcourses = 0;
            totalprice = 0.00m;

            if (frenchCheckBox.Checked)
            {
                totalcourses += 1;
                totalprice = pricepercourse * totalcourses;
            }
            if (germanCheckBox.Checked)
            {
                totalcourses += 1;
                totalprice = pricepercourse * totalcourses;
            }
            if (italianCheckBox.Checked)
            {
                totalcourses += 1;
                totalprice = pricepercourse * totalcourses;
            }
            if (russianCheckBox.Checked)
            {
                totalcourses += 1;
                totalprice = pricepercourse * totalcourses;
            }
            if (spanishCheckBox.Checked)
            {
                totalcourses += 1;
                totalprice = pricepercourse * totalcourses;
            }

            // Display values on labels
            numberOfCoursesLabel.Text = totalcourses.ToString();
            totalPriceLabel.Text = totalprice.ToString("c");
        }


        private void saveButton_Click(object sender, EventArgs e)
        {

            if (totalcourses >= 1 && totalcourses <= 3)
            {

                // Identify registration term
                if (fallRadioButton.Checked)
                {
                    registrationterm = fallRadioButton.Text + " " + yearComboBox.Text;
                }
                if (springRadioButton.Checked)
                {
                    registrationterm = springRadioButton.Text + " " + yearComboBox.Text;
                }

                // Identify credit card type
                if (mastercardRadioButton.Checked)
                {
                    creditcardtype = mastercardRadioButton.Text;
                }
                if (visaRadioButton.Checked)
                {
                    creditcardtype = visaRadioButton.Text;
                }

                // Display result box
                MessageBox.Show("Registration Term: " + registrationterm + "\n" +
                "Student ID: " + studentIDMaskedTextBox.Text + "\n" +
                "Student Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                "Email Address: " + emailTextBox.Text + "\n" +
                "Residence Status: " + residencestatus + "\n" +
                "Total Courses Puchased: " + totalcourses.ToString("n0") + "\n" +
                "Price per Course: " + pricepercourse.ToString("c") + "\n" +
                "Total Order Price: " + totalprice.ToString("c") + "\n" +
                "Credit Card Type: " + creditcardtype + "\n" +
                "Card Number: " + cardNoMaskedTextBox.Text + "\n" +
                "Card Expiration Date: " + expDateMaskedTextBox.Text,
                "Purchase Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A course order must contain at least 1 course but no more than 3 courses",
                    "Input Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fallRadioButton.Checked = true;
            yearComboBox.SelectedIndex = -1;
            studentIDMaskedTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            inStateRadioButton.Checked = true;
            frenchCheckBox.Checked = false;
            germanCheckBox.Checked = false;
            italianCheckBox.Checked = false;
            russianCheckBox.Checked = false;
            spanishCheckBox.Checked = false;
            mastercardRadioButton.Checked = true;
            cardNoMaskedTextBox.Text = "";
            expDateMaskedTextBox.Text = "";
            // Send focus to first data entry box
            studentIDMaskedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Declare message variables
            string message = "Are you sure you wish to quit?";
            string caption = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;            
            DialogResult result;

            // Display message box
            result = MessageBox.Show(message, caption, buttons, icon);            
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
