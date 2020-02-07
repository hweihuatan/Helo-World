// Programmer: Hwei Hua Tan
// Project: Tan_3
// Date: 11.12.2019
// Description: Assignment #3

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

namespace Tan_3
{
    public partial class Form1 : Form
    {
        // Declare class-level constants
        private const decimal HOME_DELIVERY_FEE = 7.50m;
        private const decimal SINGLE_BUNDLE_PRICE = 9.95m;
        private const decimal HALF_DOZEN_PRICE = 35.95m;
        private const decimal DOZEN_PRICE = 65.95m;
        private const decimal EXTRAS_PRICE_EACH = 9.50m;
        private const decimal MESSAGE_CARD_PRICE = 2.50m;
        private const decimal TAX_RATE = 0.07m;

        //Declare class-level variables
        private string customerName;
        private string customerStreet;
        private string customerCityStateZip;
        private string customerPhone;
        private string deliveryDate;
        private string deliveryType;
        private string balloonBundleSize;
        private string specialOccasion;
        private string extras;
        private string messageCard;
        private decimal deliveryFee;
        private decimal balloonbundlePrice;
        private decimal extraPrice;
        private decimal messageCardPrice;
        private decimal subtotal = 0.00m;
        private decimal taxAmount = 0.00m;
        private decimal orderTotal = 0.00m;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display values in labels when form loads
            deliveryDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            deliveryPriceLabel.Text = HOME_DELIVERY_FEE.ToString("c");
            singlePriceLabel.Text = SINGLE_BUNDLE_PRICE.ToString("c");
            halfDozenPriceLabel.Text = HALF_DOZEN_PRICE.ToString("c");
            dozenPriceLabel.Text = DOZEN_PRICE.ToString("c");
            extraPriceLabel.Text = EXTRAS_PRICE_EACH.ToString("c");
            messageCardPriceLabel.Text = MESSAGE_CARD_PRICE.ToString("c");
            
            // Call Populate Boxes method
            PopulateBoxes();

            // Display order totals associated with the default settings of the form 
            UpdateTotals();
        }

        // Handle event when Personalized Message Card checkbox is checked
        private void messageCardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (messageCardCheckBox.Checked == true)
            {
                messageTextBox.Enabled = true;
                limit30Label.Enabled = true;
            }
            else
            {
                messageTextBox.Enabled = false;
                limit30Label.Enabled = false;
            }
            UpdateTotals();
        }

        // Display all order content when user clicks on Display Summary button
        private void displayButton_Click(object sender, EventArgs e)
        {

            // Add extra items that are checked into the order summary
            for(int count = 0; count < extrasListBox.Items.Count; count++)
            {
                if (extrasListBox.GetSelected(count))
                {
                    extras += " " + extrasListBox.Items[count] + "\n";
                }
            }

            // Create strings for order content
            customerName = titleComboBox.Text + " " + firstNameTextBox.Text + " " + lastNameTextBox.Text;
            customerStreet = streetTextBox.Text;
            customerCityStateZip = cityTextBox.Text + ", " + stateMaskedTextBox.Text + " " + zipMaskedTextBox.Text;
            customerPhone = phoneMaskedTextBox.Text;
            deliveryDate = deliveryDateMaskedTextBox.Text;
            specialOccasion = occasionComboBox.Text;
            messageCard = messageTextBox.Text;

            // Display Order Summary only if customer names and phone are filled in
            if (phoneMaskedTextBox.MaskCompleted == false || firstNameTextBox.Text == "" || 
                lastNameTextBox.Text == "")
            {
                MessageBox.Show("The customer first name/last name fields have been left blank " +
                    "or the phone number entry is incomplete.", "Information Incomplete",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Bonnie’s Balloons Order Summary\n" + "\n" +
                    "Customer Name: " + customerName + "\n" +
                    "Street: " + customerStreet + "\n" +
                    "City, State, ZIP: " + customerCityStateZip + "\n" +
                    "Phone: " + customerPhone + "\n" +
                    "Delivery Date: " + deliveryDate + "\n" +
                    "Delivery Type: " + deliveryType + "\n" +
                    "Balloon Bundle Size: " + balloonBundleSize + "\n" +
                    "Special Occasion: " + specialOccasion + "\n" +
                    "Extras: " + extras + "\n" +
                    "Personalized Message: " + messageCard + "\n" +
                    "Order Subtotal: " + subtotalLabel.Text + "\n" +
                    "Sales Tax Amount: " + taxAmountLabel.Text + "\n" +
                    "Order Total: " + orderTotalLabel.Text + "\n"
                    , "Bonnie's Balloons Order Summary", MessageBoxButtons.OK,
                    MessageBoxIcon.Information) ; 
                ResetForm(); // Reset form to original state
            }
        }

        // Reset form to original state
        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Custom method to read in info from external files
        private void PopulateBoxes()
        {
            // Read in occasions to combo box
            StreamReader occasionFile;
            occasionFile = File.OpenText("Occasions.txt");
            while (occasionFile.EndOfStream == false)
            {
                // Read a line and save result as item in combo box
                string occasionName = occasionFile.ReadLine();
                occasionComboBox.Items.Add(occasionName);
            }
            occasionFile.Close();

            //Display Birthday as default occasion
            occasionComboBox.SelectedIndex = 1;

            //Read in extras to checked list box
            StreamReader extrasFile;
            extrasFile = File.OpenText("Extras.txt");
            while (extrasFile.EndOfStream == false)
            {
                //Read a line and save result as item in checked list box
                string extrasName = extrasFile.ReadLine();
                extrasListBox.Items.Add(extrasName);
            }
            extrasFile.Close();
        }

        // Custom method to reset form to original state
        private void ResetForm()
        {
            titleComboBox.SelectedItem = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            streetTextBox.Text = "";
            cityTextBox.Text = "";
            stateMaskedTextBox.Text = "";
            zipMaskedTextBox.Text = "";
            phoneMaskedTextBox.Text = "";
            deliveryDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            storePickUpRadioButton.Checked = true;
            singleRadioButton.Checked = true;
            occasionComboBox.SelectedIndex = 1;
            extrasListBox.ClearSelected();
            messageCardCheckBox.Checked = false;
            messageTextBox.Text = "";
            messageTextBox.Enabled = false;
            limit30Label.Enabled = false;
            titleComboBox.Focus();
        }

        // Custom method to update order total whenever user clicks on something
        private void UpdateTotals()
        {

            extraPrice = 0m;
            // Update Delivery Fee
            if (storePickUpRadioButton.Checked == true)
            {
                deliveryFee = 0m;
                deliveryType = storePickUpRadioButton.Text;
            }
            else
            {
                deliveryFee = HOME_DELIVERY_FEE;
                deliveryType = homeDeliveryRadioButton.Text;
            }

            // Update Balloon Bundle Price
            if (singleRadioButton.Checked)
            {
                balloonbundlePrice = SINGLE_BUNDLE_PRICE;
                balloonBundleSize = singleRadioButton.Text;
            }
            else if (halfDozenRadioButton.Checked)
            {
                balloonbundlePrice = HALF_DOZEN_PRICE;
                balloonBundleSize = halfDozenRadioButton.Text;
            }
            else
            {
                balloonbundlePrice = DOZEN_PRICE;
                balloonBundleSize = dozenRadioButton.Text;
            }

            // Update Extra Totals
            for(int count = 0; count<extrasListBox.Items.Count; count++)
            {
                if (extrasListBox.GetSelected(count))
                {
                    extraPrice += EXTRAS_PRICE_EACH;
                }
            }

            // Update Personalized Message Card Price
            if (messageCardCheckBox.Checked)
            {
                messageCardPrice = MESSAGE_CARD_PRICE;
                messageCard = messageTextBox.Text;
            }
            else
            {
                messageCardPrice = 0;
            }

            // Add up final amounts and show total amounts in labels
            subtotal = deliveryFee + balloonbundlePrice + extraPrice + messageCardPrice;
            taxAmount = subtotal * TAX_RATE;
            orderTotal = subtotal + taxAmount;
            subtotalLabel.Text = subtotal.ToString("c");
            taxAmountLabel.Text = taxAmount.ToString("c");
            orderTotalLabel.Text = orderTotal.ToString("c");
        }

        private void storePickUpRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void singleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }


        private void halfDozenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void extrasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        // Exit the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= MessageBox.Show("Are you sure you want to exit the program?","", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
