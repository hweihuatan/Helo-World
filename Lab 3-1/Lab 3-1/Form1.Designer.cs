namespace Lab_3_1
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
            this.petOwnerGroupBox = new System.Windows.Forms.GroupBox();
            this.ownerPhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ownerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.petGroupBox = new System.Windows.Forms.GroupBox();
            this.typeIfOtherTextBox = new System.Windows.Forms.TextBox();
            this.typeIfOtherLabel = new System.Windows.Forms.Label();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.dogRadioButton = new System.Windows.Forms.RadioButton();
            this.catRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.petDOBMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.servicesGroupBox = new System.Windows.Forms.GroupBox();
            this.totalFeeLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.furTrimmingPriceLabel = new System.Windows.Forms.Label();
            this.shampooPriceLabel = new System.Windows.Forms.Label();
            this.furTrimmingCheckBox = new System.Windows.Forms.CheckBox();
            this.shampooCheckBox = new System.Windows.Forms.CheckBox();
            this.nailClippingPriceLabel = new System.Windows.Forms.Label();
            this.fleaRemovalPriceLabel = new System.Windows.Forms.Label();
            this.nailClippingCheckBox = new System.Windows.Forms.CheckBox();
            this.fleaRemovalCheckBox = new System.Windows.Forms.CheckBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.petOwnerGroupBox.SuspendLayout();
            this.petGroupBox.SuspendLayout();
            this.servicesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // petOwnerGroupBox
            // 
            this.petOwnerGroupBox.Controls.Add(this.ownerPhoneMaskedTextBox);
            this.petOwnerGroupBox.Controls.Add(this.ownerNameTextBox);
            this.petOwnerGroupBox.Controls.Add(this.label2);
            this.petOwnerGroupBox.Controls.Add(this.label1);
            this.petOwnerGroupBox.Location = new System.Drawing.Point(36, 35);
            this.petOwnerGroupBox.Name = "petOwnerGroupBox";
            this.petOwnerGroupBox.Size = new System.Drawing.Size(730, 157);
            this.petOwnerGroupBox.TabIndex = 0;
            this.petOwnerGroupBox.TabStop = false;
            this.petOwnerGroupBox.Text = "Pet Owner";
            // 
            // ownerPhoneMaskedTextBox
            // 
            this.ownerPhoneMaskedTextBox.Location = new System.Drawing.Point(303, 91);
            this.ownerPhoneMaskedTextBox.Mask = "(999) 000-0000";
            this.ownerPhoneMaskedTextBox.Name = "ownerPhoneMaskedTextBox";
            this.ownerPhoneMaskedTextBox.Size = new System.Drawing.Size(197, 38);
            this.ownerPhoneMaskedTextBox.TabIndex = 4;
            // 
            // ownerNameTextBox
            // 
            this.ownerNameTextBox.Location = new System.Drawing.Point(303, 46);
            this.ownerNameTextBox.Name = "ownerNameTextBox";
            this.ownerNameTextBox.Size = new System.Drawing.Size(276, 38);
            this.ownerNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "O&wner Phone :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Owner Name :";
            // 
            // petGroupBox
            // 
            this.petGroupBox.Controls.Add(this.typeIfOtherTextBox);
            this.petGroupBox.Controls.Add(this.typeIfOtherLabel);
            this.petGroupBox.Controls.Add(this.otherRadioButton);
            this.petGroupBox.Controls.Add(this.dogRadioButton);
            this.petGroupBox.Controls.Add(this.catRadioButton);
            this.petGroupBox.Controls.Add(this.label5);
            this.petGroupBox.Controls.Add(this.petDOBMaskedTextBox);
            this.petGroupBox.Controls.Add(this.petNameTextBox);
            this.petGroupBox.Controls.Add(this.label3);
            this.petGroupBox.Controls.Add(this.label4);
            this.petGroupBox.Location = new System.Drawing.Point(36, 214);
            this.petGroupBox.Name = "petGroupBox";
            this.petGroupBox.Size = new System.Drawing.Size(730, 250);
            this.petGroupBox.TabIndex = 5;
            this.petGroupBox.TabStop = false;
            this.petGroupBox.Text = "Pet Owner";
            // 
            // typeIfOtherTextBox
            // 
            this.typeIfOtherTextBox.Enabled = false;
            this.typeIfOtherTextBox.Location = new System.Drawing.Point(424, 189);
            this.typeIfOtherTextBox.Name = "typeIfOtherTextBox";
            this.typeIfOtherTextBox.Size = new System.Drawing.Size(276, 38);
            this.typeIfOtherTextBox.TabIndex = 10;
            // 
            // typeIfOtherLabel
            // 
            this.typeIfOtherLabel.AutoSize = true;
            this.typeIfOtherLabel.Enabled = false;
            this.typeIfOtherLabel.Location = new System.Drawing.Point(213, 192);
            this.typeIfOtherLabel.Name = "typeIfOtherLabel";
            this.typeIfOtherLabel.Size = new System.Drawing.Size(205, 32);
            this.typeIfOtherLabel.TabIndex = 9;
            this.typeIfOtherLabel.Text = "T&ype (If other) :";
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Location = new System.Drawing.Point(483, 138);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(123, 36);
            this.otherRadioButton.TabIndex = 7;
            this.otherRadioButton.Text = "Other";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            this.otherRadioButton.CheckedChanged += new System.EventHandler(this.otherRadioButton_CheckedChanged);
            // 
            // dogRadioButton
            // 
            this.dogRadioButton.AutoSize = true;
            this.dogRadioButton.Location = new System.Drawing.Point(353, 138);
            this.dogRadioButton.Name = "dogRadioButton";
            this.dogRadioButton.Size = new System.Drawing.Size(104, 36);
            this.dogRadioButton.TabIndex = 7;
            this.dogRadioButton.Text = "Dog";
            this.dogRadioButton.UseVisualStyleBackColor = true;
            // 
            // catRadioButton
            // 
            this.catRadioButton.AutoSize = true;
            this.catRadioButton.Checked = true;
            this.catRadioButton.Location = new System.Drawing.Point(219, 138);
            this.catRadioButton.Name = "catRadioButton";
            this.catRadioButton.Size = new System.Drawing.Size(96, 36);
            this.catRadioButton.TabIndex = 7;
            this.catRadioButton.TabStop = true;
            this.catRadioButton.Text = "Cat";
            this.catRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pe&t Type :";
            // 
            // petDOBMaskedTextBox
            // 
            this.petDOBMaskedTextBox.Location = new System.Drawing.Point(303, 91);
            this.petDOBMaskedTextBox.Mask = "00/00/0000";
            this.petDOBMaskedTextBox.Name = "petDOBMaskedTextBox";
            this.petDOBMaskedTextBox.Size = new System.Drawing.Size(146, 38);
            this.petDOBMaskedTextBox.TabIndex = 6;
            this.petDOBMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Location = new System.Drawing.Point(303, 46);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.Size = new System.Drawing.Size(276, 38);
            this.petNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "P&et Date of Birth :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "&Pet Name :";
            // 
            // servicesGroupBox
            // 
            this.servicesGroupBox.Controls.Add(this.totalFeeLabel);
            this.servicesGroupBox.Controls.Add(this.label11);
            this.servicesGroupBox.Controls.Add(this.furTrimmingPriceLabel);
            this.servicesGroupBox.Controls.Add(this.shampooPriceLabel);
            this.servicesGroupBox.Controls.Add(this.furTrimmingCheckBox);
            this.servicesGroupBox.Controls.Add(this.shampooCheckBox);
            this.servicesGroupBox.Controls.Add(this.nailClippingPriceLabel);
            this.servicesGroupBox.Controls.Add(this.fleaRemovalPriceLabel);
            this.servicesGroupBox.Controls.Add(this.nailClippingCheckBox);
            this.servicesGroupBox.Controls.Add(this.fleaRemovalCheckBox);
            this.servicesGroupBox.Location = new System.Drawing.Point(35, 489);
            this.servicesGroupBox.Name = "servicesGroupBox";
            this.servicesGroupBox.Size = new System.Drawing.Size(731, 215);
            this.servicesGroupBox.TabIndex = 11;
            this.servicesGroupBox.TabStop = false;
            this.servicesGroupBox.Text = "Services";
            // 
            // totalFeeLabel
            // 
            this.totalFeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalFeeLabel.Location = new System.Drawing.Point(329, 146);
            this.totalFeeLabel.Name = "totalFeeLabel";
            this.totalFeeLabel.Size = new System.Drawing.Size(141, 37);
            this.totalFeeLabel.TabIndex = 19;
            this.totalFeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 32);
            this.label11.TabIndex = 11;
            this.label11.Text = "Total Fee :";
            // 
            // furTrimmingPriceLabel
            // 
            this.furTrimmingPriceLabel.AutoSize = true;
            this.furTrimmingPriceLabel.Location = new System.Drawing.Point(614, 93);
            this.furTrimmingPriceLabel.Name = "furTrimmingPriceLabel";
            this.furTrimmingPriceLabel.Size = new System.Drawing.Size(100, 32);
            this.furTrimmingPriceLabel.TabIndex = 18;
            this.furTrimmingPriceLabel.Text = "PRICE";
            // 
            // shampooPriceLabel
            // 
            this.shampooPriceLabel.AutoSize = true;
            this.shampooPriceLabel.Location = new System.Drawing.Point(614, 51);
            this.shampooPriceLabel.Name = "shampooPriceLabel";
            this.shampooPriceLabel.Size = new System.Drawing.Size(100, 32);
            this.shampooPriceLabel.TabIndex = 15;
            this.shampooPriceLabel.Text = "PRICE";
            // 
            // furTrimmingCheckBox
            // 
            this.furTrimmingCheckBox.AutoSize = true;
            this.furTrimmingCheckBox.Location = new System.Drawing.Point(403, 91);
            this.furTrimmingCheckBox.Name = "furTrimmingCheckBox";
            this.furTrimmingCheckBox.Size = new System.Drawing.Size(220, 36);
            this.furTrimmingCheckBox.TabIndex = 17;
            this.furTrimmingCheckBox.Text = "F&ur Trimming";
            this.furTrimmingCheckBox.UseVisualStyleBackColor = true;
            // 
            // shampooCheckBox
            // 
            this.shampooCheckBox.AutoSize = true;
            this.shampooCheckBox.Location = new System.Drawing.Point(403, 49);
            this.shampooCheckBox.Name = "shampooCheckBox";
            this.shampooCheckBox.Size = new System.Drawing.Size(175, 36);
            this.shampooCheckBox.TabIndex = 16;
            this.shampooCheckBox.Text = "&Shampoo";
            this.shampooCheckBox.UseVisualStyleBackColor = true;
            // 
            // nailClippingPriceLabel
            // 
            this.nailClippingPriceLabel.AutoSize = true;
            this.nailClippingPriceLabel.Location = new System.Drawing.Point(280, 93);
            this.nailClippingPriceLabel.Name = "nailClippingPriceLabel";
            this.nailClippingPriceLabel.Size = new System.Drawing.Size(100, 32);
            this.nailClippingPriceLabel.TabIndex = 14;
            this.nailClippingPriceLabel.Text = "PRICE";
            // 
            // fleaRemovalPriceLabel
            // 
            this.fleaRemovalPriceLabel.AutoSize = true;
            this.fleaRemovalPriceLabel.Location = new System.Drawing.Point(280, 51);
            this.fleaRemovalPriceLabel.Name = "fleaRemovalPriceLabel";
            this.fleaRemovalPriceLabel.Size = new System.Drawing.Size(100, 32);
            this.fleaRemovalPriceLabel.TabIndex = 11;
            this.fleaRemovalPriceLabel.Text = "PRICE";
            // 
            // nailClippingCheckBox
            // 
            this.nailClippingCheckBox.AutoSize = true;
            this.nailClippingCheckBox.Location = new System.Drawing.Point(63, 91);
            this.nailClippingCheckBox.Name = "nailClippingCheckBox";
            this.nailClippingCheckBox.Size = new System.Drawing.Size(215, 36);
            this.nailClippingCheckBox.TabIndex = 13;
            this.nailClippingCheckBox.Text = "&Nail Clipping";
            this.nailClippingCheckBox.UseVisualStyleBackColor = true;
            // 
            // fleaRemovalCheckBox
            // 
            this.fleaRemovalCheckBox.AutoSize = true;
            this.fleaRemovalCheckBox.Location = new System.Drawing.Point(63, 49);
            this.fleaRemovalCheckBox.Name = "fleaRemovalCheckBox";
            this.fleaRemovalCheckBox.Size = new System.Drawing.Size(228, 36);
            this.fleaRemovalCheckBox.TabIndex = 12;
            this.fleaRemovalCheckBox.Text = "&Flea Removal";
            this.fleaRemovalCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(98, 724);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(163, 48);
            this.totalButton.TabIndex = 12;
            this.totalButton.Text = "T&otal";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(321, 724);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(163, 48);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(549, 724);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(163, 48);
            this.quitButton.TabIndex = 14;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 815);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.servicesGroupBox);
            this.Controls.Add(this.petGroupBox);
            this.Controls.Add(this.petOwnerGroupBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Boutique - Service Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.petOwnerGroupBox.ResumeLayout(false);
            this.petOwnerGroupBox.PerformLayout();
            this.petGroupBox.ResumeLayout(false);
            this.petGroupBox.PerformLayout();
            this.servicesGroupBox.ResumeLayout(false);
            this.servicesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox petOwnerGroupBox;
        private System.Windows.Forms.MaskedTextBox ownerPhoneMaskedTextBox;
        private System.Windows.Forms.TextBox ownerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox petGroupBox;
        private System.Windows.Forms.TextBox typeIfOtherTextBox;
        private System.Windows.Forms.Label typeIfOtherLabel;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.RadioButton dogRadioButton;
        private System.Windows.Forms.RadioButton catRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox petDOBMaskedTextBox;
        private System.Windows.Forms.TextBox petNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox servicesGroupBox;
        private System.Windows.Forms.CheckBox fleaRemovalCheckBox;
        private System.Windows.Forms.Label totalFeeLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label furTrimmingPriceLabel;
        private System.Windows.Forms.Label shampooPriceLabel;
        private System.Windows.Forms.CheckBox furTrimmingCheckBox;
        private System.Windows.Forms.CheckBox shampooCheckBox;
        private System.Windows.Forms.Label nailClippingPriceLabel;
        private System.Windows.Forms.Label fleaRemovalPriceLabel;
        private System.Windows.Forms.CheckBox nailClippingCheckBox;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button quitButton;
    }
}

