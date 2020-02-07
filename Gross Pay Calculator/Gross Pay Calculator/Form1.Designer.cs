namespace Gross_Pay_Calculator
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
            this.hoursTextbox = new System.Windows.Forms.TextBox();
            this.rateTextbox = new System.Windows.Forms.TextBox();
            this.grossLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursTextbox
            // 
            this.hoursTextbox.Location = new System.Drawing.Point(414, 98);
            this.hoursTextbox.Name = "hoursTextbox";
            this.hoursTextbox.Size = new System.Drawing.Size(214, 38);
            this.hoursTextbox.TabIndex = 0;
            // 
            // rateTextbox
            // 
            this.rateTextbox.Location = new System.Drawing.Point(414, 171);
            this.rateTextbox.Name = "rateTextbox";
            this.rateTextbox.Size = new System.Drawing.Size(214, 38);
            this.rateTextbox.TabIndex = 1;
            // 
            // grossLabel
            // 
            this.grossLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grossLabel.Location = new System.Drawing.Point(414, 247);
            this.grossLabel.Name = "grossLabel";
            this.grossLabel.Size = new System.Drawing.Size(214, 46);
            this.grossLabel.TabIndex = 2;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(79, 330);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(177, 85);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate Pay";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.grossLabel);
            this.Controls.Add(this.rateTextbox);
            this.Controls.Add(this.hoursTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hoursTextbox;
        private System.Windows.Forms.TextBox rateTextbox;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.Button calcButton;
    }
}

