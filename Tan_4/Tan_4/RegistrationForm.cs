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

namespace Tan_4
{
    public partial class RegistrationForm : Form
    {
        private int MAX_NUMBER_CLASSES = 4;
        private decimal LIVE_CLASS_PRICE = 79.95m;
        private decimal ANIMATION_CLASS_PRICE = 99.95m;

        private decimal numberClassesSelected = 0.00m;
        private decimal pricePerClass = 0.00m;
        private decimal totalPrice = 0.00m;
        private string classes;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create an array to hold items and read them to ComboBox
            string[] statusArray = {"Actor", "Producer", "Director", "Animator",
            "Cinematographer", "Drama Teacher", "Light Technician", "Sound Technician"};
            // Adding items from array to ComboBox
            foreach (string value in statusArray)
            {
                statusComboBox.Items.Add(value);
            }

            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            maxClassNumberLabel.Text = MAX_NUMBER_CLASSES.ToString("n0");
            PopulateList();
            statusComboBox.Text = "";
            maxClassNumberLabel.Text = MAX_NUMBER_CLASSES.ToString("n0");
            UpdateTotals();
        }

        private void liveRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList();
            UpdateTotals();
        }
        private void classListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string paymentType;
            string emailReceipt;

            for (int count = 0; count < classListBox.Items.Count; count++)
            {
                if (classListBox.GetSelected(count))
                {
                    classes += " " + classListBox.Items[count] + "\n";
                }
            }

            if (cashRadioButton.Checked)
            {
                paymentType = cashRadioButton.Text;
            }
            else
            {
                paymentType = checkRadioButton.Text;
            }
            if (emailReceiptCheckBox.Checked)
            {
                emailReceipt = "Yes";
            }
            else
            {
                emailReceipt = "No";
            }
            
            if (dobMaskedTextBox.MaskCompleted == false || firstNameTextBox.Text == "" ||
                lastNameTextBox.Text == "" || emailTextBox.Text == "")
            {
                MessageBox.Show("The registrant information is incomplete.", "Information Incomplete",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numberClassesSelected > MAX_NUMBER_CLASSES)
            {
                MessageBox.Show("Number of classes selected should be between 1-4.", "Number of Classes",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    MessageBox.Show("Registration Summary\n" +
                    "Registration Date: " + dateMaskedTextBox.Text + "\n" +
                    "Registrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                    "Email Address: " + emailTextBox.Text + "\n" +
                    "Date of Birth: " + dobMaskedTextBox.Text + "\n" +
                    "Status: " + statusComboBox.Text + "\n" +
                    "Classes Selected: " + classes + "\n" +
                    "Number of Classes Selected: " + totalClassLabel.Text + "\n" +
                    "Price Per Class: " + pricePerClassLabel.Text + "\n" +
                    "Total Registration Price: " + totalPriceLabel.Text + "\n" +
                    "Payment Type: " + paymentType + "\n" +
                    "Email Receipt Requested: " + emailReceipt,
                    "Registration Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    StreamWriter outputFile; //Declare object for use in writing file
                    outputFile = File.AppendText("RegistrationData.txt");
                    //Write all data to file
                    outputFile.WriteLine("Registration Date: " + dateMaskedTextBox.Text);
                    outputFile.WriteLine("Registrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text);
                    outputFile.WriteLine();
                    outputFile.Close();

                    //Display confirmation message after saved
                    MessageBox.Show("Data successfully saved to file.", "Confirmation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetForm();
                }
                catch
                {
                    //Display message if error occurs when attempting to write file
                    MessageBox.Show("There was an error when attempting to display the summary.");
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the program?",
                "Exit Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm myAboutForm = new AboutForm();
            myAboutForm.ShowDialog();
        }

        private void PopulateList()
        {
            classListBox.Items.Clear();

            if (liveRadioButton.Checked)
            {
                StreamReader liveActionFile;
                liveActionFile = File.OpenText("LiveActionClasses.txt");
                while (liveActionFile.EndOfStream == false)
                {
                    // Read a line and save result as item in combo box
                    string liveActionName = liveActionFile.ReadLine();
                    classListBox.Items.Add(liveActionName);
                }
                liveActionFile.Close();
            }
            else
            {
                StreamReader animationFile;
                animationFile = File.OpenText("AnimationClasses.txt");
                while (animationFile.EndOfStream == false)
                {
                    string animationName = animationFile.ReadLine();
                    classListBox.Items.Add(animationName);
                }
                animationFile.Close();
            }
        }

        private void UpdateTotals()
        {
            numberClassesSelected = 0;

            if (liveRadioButton.Checked)
            {
                pricePerClass = LIVE_CLASS_PRICE;
            }
            else
            {
                pricePerClass = ANIMATION_CLASS_PRICE;
            }
            numberClassesSelected = classListBox.SelectedItems.Count;
            totalPrice = numberClassesSelected * pricePerClass;

            totalClassLabel.Text = numberClassesSelected.ToString("n0");
            pricePerClassLabel.Text = pricePerClass.ToString("c");
            totalPriceLabel.Text = totalPrice.ToString("c");
        }

        private void ResetForm()
        {
            PopulateList();
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            dobMaskedTextBox.Text = "";
            statusComboBox.Text = "";
            liveRadioButton.Checked = true;
            classListBox.ClearSelected();
            totalClassLabel.Text = numberClassesSelected.ToString("n0");
            pricePerClassLabel.Text = LIVE_CLASS_PRICE.ToString("c");
            totalPriceLabel.Text = totalPrice.ToString("c");
            cashRadioButton.Checked = true;
            emailReceiptCheckBox.Checked = false;
        }
    }
}
