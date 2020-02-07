namespace Lab_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.saleDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.commercialRadioButton = new System.Windows.Forms.RadioButton();
            this.residentialRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.polkRradioButton = new System.Windows.Forms.RadioButton();
            this.pascoRadioButton = new System.Windows.Forms.RadioButton();
            this.hillsboroughRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.propertyPriceTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stateSalesTaxLabel = new System.Windows.Forms.Label();
            this.countySalesTaxLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.commissionLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale Date :";
            // 
            // saleDateMaskedTextBox
            // 
            this.saleDateMaskedTextBox.Location = new System.Drawing.Point(383, 50);
            this.saleDateMaskedTextBox.Mask = "00/00/0000";
            this.saleDateMaskedTextBox.Name = "saleDateMaskedTextBox";
            this.saleDateMaskedTextBox.Size = new System.Drawing.Size(166, 38);
            this.saleDateMaskedTextBox.TabIndex = 1;
            this.saleDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saleDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.commercialRadioButton);
            this.groupBox1.Controls.Add(this.residentialRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(235, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Type";
            // 
            // commercialRadioButton
            // 
            this.commercialRadioButton.AutoSize = true;
            this.commercialRadioButton.Location = new System.Drawing.Point(52, 102);
            this.commercialRadioButton.Name = "commercialRadioButton";
            this.commercialRadioButton.Size = new System.Drawing.Size(203, 36);
            this.commercialRadioButton.TabIndex = 1;
            this.commercialRadioButton.TabStop = true;
            this.commercialRadioButton.Text = "Commercial";
            this.commercialRadioButton.UseVisualStyleBackColor = true;
            // 
            // residentialRadioButton
            // 
            this.residentialRadioButton.AutoSize = true;
            this.residentialRadioButton.Checked = true;
            this.residentialRadioButton.Location = new System.Drawing.Point(52, 51);
            this.residentialRadioButton.Name = "residentialRadioButton";
            this.residentialRadioButton.Size = new System.Drawing.Size(195, 36);
            this.residentialRadioButton.TabIndex = 0;
            this.residentialRadioButton.TabStop = true;
            this.residentialRadioButton.Text = "Residential";
            this.residentialRadioButton.UseVisualStyleBackColor = true;
            this.residentialRadioButton.CheckedChanged += new System.EventHandler(this.residentialRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.polkRradioButton);
            this.groupBox2.Controls.Add(this.pascoRadioButton);
            this.groupBox2.Controls.Add(this.hillsboroughRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(235, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 205);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Property Type";
            // 
            // polkRradioButton
            // 
            this.polkRradioButton.AutoSize = true;
            this.polkRradioButton.Location = new System.Drawing.Point(52, 153);
            this.polkRradioButton.Name = "polkRradioButton";
            this.polkRradioButton.Size = new System.Drawing.Size(108, 36);
            this.polkRradioButton.TabIndex = 2;
            this.polkRradioButton.TabStop = true;
            this.polkRradioButton.Text = "Polk";
            this.polkRradioButton.UseVisualStyleBackColor = true;
            // 
            // pascoRadioButton
            // 
            this.pascoRadioButton.AutoSize = true;
            this.pascoRadioButton.Location = new System.Drawing.Point(52, 102);
            this.pascoRadioButton.Name = "pascoRadioButton";
            this.pascoRadioButton.Size = new System.Drawing.Size(131, 36);
            this.pascoRadioButton.TabIndex = 1;
            this.pascoRadioButton.Text = "Pasco";
            this.pascoRadioButton.UseVisualStyleBackColor = true;
            this.pascoRadioButton.CheckedChanged += new System.EventHandler(this.pascoRadioButton_CheckedChanged);
            // 
            // hillsboroughRadioButton
            // 
            this.hillsboroughRadioButton.AutoSize = true;
            this.hillsboroughRadioButton.Checked = true;
            this.hillsboroughRadioButton.Location = new System.Drawing.Point(52, 51);
            this.hillsboroughRadioButton.Name = "hillsboroughRadioButton";
            this.hillsboroughRadioButton.Size = new System.Drawing.Size(212, 36);
            this.hillsboroughRadioButton.TabIndex = 0;
            this.hillsboroughRadioButton.TabStop = true;
            this.hillsboroughRadioButton.Text = "Hillsborough";
            this.hillsboroughRadioButton.UseVisualStyleBackColor = true;
            this.hillsboroughRadioButton.CheckedChanged += new System.EventHandler(this.hillsboroughRadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Property Price : ";
            // 
            // propertyPriceTextBox
            // 
            this.propertyPriceTextBox.Location = new System.Drawing.Point(368, 533);
            this.propertyPriceTextBox.Name = "propertyPriceTextBox";
            this.propertyPriceTextBox.Size = new System.Drawing.Size(264, 38);
            this.propertyPriceTextBox.TabIndex = 0;
            this.propertyPriceTextBox.Text = "0.00";
            this.propertyPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.propertyPriceTextBox.TextChanged += new System.EventHandler(this.propertyPriceTextBox_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(189, 606);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(389, 55);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "&Update Property Price";
            this.toolTip4.SetToolTip(this.updateButton, "This button will update the total price.");
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 692);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "State Sales Tax :";
            // 
            // stateSalesTaxLabel
            // 
            this.stateSalesTaxLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.stateSalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateSalesTaxLabel.Location = new System.Drawing.Point(415, 686);
            this.stateSalesTaxLabel.Name = "stateSalesTaxLabel";
            this.stateSalesTaxLabel.Size = new System.Drawing.Size(243, 42);
            this.stateSalesTaxLabel.TabIndex = 8;
            this.stateSalesTaxLabel.Text = "$0.00";
            this.stateSalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countySalesTaxLabel
            // 
            this.countySalesTaxLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.countySalesTaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countySalesTaxLabel.Location = new System.Drawing.Point(415, 740);
            this.countySalesTaxLabel.Name = "countySalesTaxLabel";
            this.countySalesTaxLabel.Size = new System.Drawing.Size(243, 42);
            this.countySalesTaxLabel.TabIndex = 10;
            this.countySalesTaxLabel.Text = "$0.00";
            this.countySalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 746);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "County Sales Tax :";
            // 
            // commissionLabel
            // 
            this.commissionLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.commissionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commissionLabel.Location = new System.Drawing.Point(415, 794);
            this.commissionLabel.Name = "commissionLabel";
            this.commissionLabel.Size = new System.Drawing.Size(243, 42);
            this.commissionLabel.TabIndex = 12;
            this.commissionLabel.Text = "$0.00";
            this.commissionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 800);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "Commission :";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(363, 849);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 3);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceLabel.Location = new System.Drawing.Point(364, 864);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(295, 42);
            this.totalPriceLabel.TabIndex = 15;
            this.totalPriceLabel.Text = "$0.00";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 870);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 32);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total Price :";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(45, 964);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(189, 54);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "&Save";
            this.toolTip1.SetToolTip(this.saveButton, "This button will save these information to a text file.");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(298, 964);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(189, 54);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "&Clear";
            this.toolTip2.SetToolTip(this.clearButton, "This button will clear all controls and reset the form to its original state.");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(555, 964);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(189, 54);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "E&xit";
            this.toolTip3.SetToolTip(this.exitButton, "This button will exit the program.");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1049);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.commissionLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.countySalesTaxLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stateSalesTaxLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.propertyPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saleDateMaskedTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox saleDateMaskedTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton commercialRadioButton;
        private System.Windows.Forms.RadioButton residentialRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton polkRradioButton;
        private System.Windows.Forms.RadioButton pascoRadioButton;
        private System.Windows.Forms.RadioButton hillsboroughRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox propertyPriceTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label stateSalesTaxLabel;
        private System.Windows.Forms.Label countySalesTaxLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label commissionLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}

