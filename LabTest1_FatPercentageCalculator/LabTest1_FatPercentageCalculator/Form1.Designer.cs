namespace LabTest1_FatPercentageCalculator
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
            this.lowFatCheckBox = new System.Windows.Forms.CheckBox();
            this.totalCaloriesLabel = new System.Windows.Forms.Label();
            this.fatGramsLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.totalCaloriesTextBox = new System.Windows.Forms.TextBox();
            this.fatGramsTextBox = new System.Windows.Forms.TextBox();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lowFatCheckBox
            // 
            this.lowFatCheckBox.AutoSize = true;
            this.lowFatCheckBox.Location = new System.Drawing.Point(16, 102);
            this.lowFatCheckBox.Name = "lowFatCheckBox";
            this.lowFatCheckBox.Size = new System.Drawing.Size(238, 17);
            this.lowFatCheckBox.TabIndex = 0;
            this.lowFatCheckBox.Text = "Check if you want to know the food is low fat";
            this.lowFatCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalCaloriesLabel
            // 
            this.totalCaloriesLabel.AutoSize = true;
            this.totalCaloriesLabel.Location = new System.Drawing.Point(13, 25);
            this.totalCaloriesLabel.Name = "totalCaloriesLabel";
            this.totalCaloriesLabel.Size = new System.Drawing.Size(141, 13);
            this.totalCaloriesLabel.TabIndex = 1;
            this.totalCaloriesLabel.Text = "The total number of calories:";
            // 
            // fatGramsLabel
            // 
            this.fatGramsLabel.AutoSize = true;
            this.fatGramsLabel.Location = new System.Drawing.Point(13, 63);
            this.fatGramsLabel.Name = "fatGramsLabel";
            this.fatGramsLabel.Size = new System.Drawing.Size(125, 13);
            this.fatGramsLabel.TabIndex = 2;
            this.fatGramsLabel.Text = "The number of fat grams:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(16, 227);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(106, 227);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(197, 227);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // totalCaloriesTextBox
            // 
            this.totalCaloriesTextBox.Location = new System.Drawing.Point(172, 25);
            this.totalCaloriesTextBox.Name = "totalCaloriesTextBox";
            this.totalCaloriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalCaloriesTextBox.TabIndex = 6;
            // 
            // fatGramsTextBox
            // 
            this.fatGramsTextBox.Location = new System.Drawing.Point(172, 63);
            this.fatGramsTextBox.Name = "fatGramsTextBox";
            this.fatGramsTextBox.Size = new System.Drawing.Size(100, 20);
            this.fatGramsTextBox.TabIndex = 7;
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(16, 141);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(256, 64);
            this.outputRichTextBox.TabIndex = 8;
            this.outputRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 257);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.fatGramsTextBox);
            this.Controls.Add(this.totalCaloriesTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.fatGramsLabel);
            this.Controls.Add(this.totalCaloriesLabel);
            this.Controls.Add(this.lowFatCheckBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milton - 17881797";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox lowFatCheckBox;
        private System.Windows.Forms.Label totalCaloriesLabel;
        private System.Windows.Forms.Label fatGramsLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox totalCaloriesTextBox;
        private System.Windows.Forms.TextBox fatGramsTextBox;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
    }
}

