namespace Test_Average
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
            this.Test1TextBox = new System.Windows.Forms.TextBox();
            this.Test2TextBox = new System.Windows.Forms.TextBox();
            this.Test3TextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.Test1Label = new System.Windows.Forms.Label();
            this.Test2Label = new System.Windows.Forms.Label();
            this.Test3Label = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Test1TextBox
            // 
            this.Test1TextBox.Location = new System.Drawing.Point(315, 55);
            this.Test1TextBox.Name = "Test1TextBox";
            this.Test1TextBox.Size = new System.Drawing.Size(248, 38);
            this.Test1TextBox.TabIndex = 0;
            // 
            // Test2TextBox
            // 
            this.Test2TextBox.Location = new System.Drawing.Point(315, 110);
            this.Test2TextBox.Name = "Test2TextBox";
            this.Test2TextBox.Size = new System.Drawing.Size(248, 38);
            this.Test2TextBox.TabIndex = 1;
            // 
            // Test3TextBox
            // 
            this.Test3TextBox.Location = new System.Drawing.Point(315, 163);
            this.Test3TextBox.Name = "Test3TextBox";
            this.Test3TextBox.Size = new System.Drawing.Size(248, 38);
            this.Test3TextBox.TabIndex = 2;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(382, 239);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(262, 38);
            this.ResultTextBox.TabIndex = 3;
            // 
            // Test1Label
            // 
            this.Test1Label.AutoSize = true;
            this.Test1Label.Location = new System.Drawing.Point(164, 55);
            this.Test1Label.Name = "Test1Label";
            this.Test1Label.Size = new System.Drawing.Size(101, 32);
            this.Test1Label.TabIndex = 4;
            this.Test1Label.Text = "Test 1:";
            // 
            // Test2Label
            // 
            this.Test2Label.AutoSize = true;
            this.Test2Label.Location = new System.Drawing.Point(164, 110);
            this.Test2Label.Name = "Test2Label";
            this.Test2Label.Size = new System.Drawing.Size(101, 32);
            this.Test2Label.TabIndex = 5;
            this.Test2Label.Text = "Test 2:";
            // 
            // Test3Label
            // 
            this.Test3Label.AutoSize = true;
            this.Test3Label.Location = new System.Drawing.Point(164, 163);
            this.Test3Label.Name = "Test3Label";
            this.Test3Label.Size = new System.Drawing.Size(101, 32);
            this.Test3Label.TabIndex = 6;
            this.Test3Label.Text = "Test 3:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(90, 242);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(272, 32);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Average Test Score:";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(96, 302);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(149, 93);
            this.CalcButton.TabIndex = 8;
            this.CalcButton.Text = "Calculate Average";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(315, 302);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(149, 93);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(538, 302);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(149, 93);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Test3Label);
            this.Controls.Add(this.Test2Label);
            this.Controls.Add(this.Test1Label);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.Test3TextBox);
            this.Controls.Add(this.Test2TextBox);
            this.Controls.Add(this.Test1TextBox);
            this.Name = "Form1";
            this.Text = "Test Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Test1TextBox;
        private System.Windows.Forms.TextBox Test2TextBox;
        private System.Windows.Forms.TextBox Test3TextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label Test1Label;
        private System.Windows.Forms.Label Test2Label;
        private System.Windows.Forms.Label Test3Label;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

