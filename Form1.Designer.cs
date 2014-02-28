namespace Population
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
            this.numberOfOrganismsTxt = new System.Windows.Forms.TextBox();
            this.amountOfIncreaseTxt = new System.Windows.Forms.TextBox();
            this.daysToMultiplyTxt = new System.Windows.Forms.TextBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.numberOfOrganismsLabel = new System.Windows.Forms.Label();
            this.amountOfIncreaseLabel = new System.Windows.Forms.Label();
            this.daysToMultipleLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberOfOrganismsTxt
            // 
            this.numberOfOrganismsTxt.Location = new System.Drawing.Point(153, 47);
            this.numberOfOrganismsTxt.Name = "numberOfOrganismsTxt";
            this.numberOfOrganismsTxt.Size = new System.Drawing.Size(100, 20);
            this.numberOfOrganismsTxt.TabIndex = 0;
            // 
            // amountOfIncreaseTxt
            // 
            this.amountOfIncreaseTxt.Location = new System.Drawing.Point(153, 94);
            this.amountOfIncreaseTxt.Name = "amountOfIncreaseTxt";
            this.amountOfIncreaseTxt.Size = new System.Drawing.Size(100, 20);
            this.amountOfIncreaseTxt.TabIndex = 1;
            // 
            // daysToMultiplyTxt
            // 
            this.daysToMultiplyTxt.Location = new System.Drawing.Point(153, 141);
            this.daysToMultiplyTxt.Name = "daysToMultiplyTxt";
            this.daysToMultiplyTxt.Size = new System.Drawing.Size(100, 20);
            this.daysToMultiplyTxt.TabIndex = 2;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(287, 12);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(185, 238);
            this.outputListBox.TabIndex = 3;
            this.outputListBox.TabStop = false;
            // 
            // numberOfOrganismsLabel
            // 
            this.numberOfOrganismsLabel.AutoSize = true;
            this.numberOfOrganismsLabel.Location = new System.Drawing.Point(12, 50);
            this.numberOfOrganismsLabel.Name = "numberOfOrganismsLabel";
            this.numberOfOrganismsLabel.Size = new System.Drawing.Size(107, 13);
            this.numberOfOrganismsLabel.TabIndex = 4;
            this.numberOfOrganismsLabel.Text = "Amount of Organisms";
            // 
            // amountOfIncreaseLabel
            // 
            this.amountOfIncreaseLabel.AutoSize = true;
            this.amountOfIncreaseLabel.Location = new System.Drawing.Point(12, 97);
            this.amountOfIncreaseLabel.Name = "amountOfIncreaseLabel";
            this.amountOfIncreaseLabel.Size = new System.Drawing.Size(131, 13);
            this.amountOfIncreaseLabel.TabIndex = 5;
            this.amountOfIncreaseLabel.Text = "Average Daily Increase(%)";
            // 
            // daysToMultipleLabel
            // 
            this.daysToMultipleLabel.AutoSize = true;
            this.daysToMultipleLabel.Location = new System.Drawing.Point(12, 144);
            this.daysToMultipleLabel.Name = "daysToMultipleLabel";
            this.daysToMultipleLabel.Size = new System.Drawing.Size(87, 13);
            this.daysToMultipleLabel.TabIndex = 6;
            this.daysToMultipleLabel.Text = "Days of Increase";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(16, 227);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(97, 227);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(178, 227);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.daysToMultipleLabel);
            this.Controls.Add(this.amountOfIncreaseLabel);
            this.Controls.Add(this.numberOfOrganismsLabel);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.daysToMultiplyTxt);
            this.Controls.Add(this.amountOfIncreaseTxt);
            this.Controls.Add(this.numberOfOrganismsTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberOfOrganismsTxt;
        private System.Windows.Forms.TextBox amountOfIncreaseTxt;
        private System.Windows.Forms.TextBox daysToMultiplyTxt;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Label numberOfOrganismsLabel;
        private System.Windows.Forms.Label amountOfIncreaseLabel;
        private System.Windows.Forms.Label daysToMultipleLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

