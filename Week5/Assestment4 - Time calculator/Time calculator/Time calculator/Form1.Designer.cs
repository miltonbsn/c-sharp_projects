namespace Time_calculator
{
    partial class timeCalculatorForm
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
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.displayTotal = new System.Windows.Forms.Label();
            this.inputSecondsTextBox = new System.Windows.Forms.TextBox();
            this.displayMinutes = new System.Windows.Forms.Label();
            this.DisplayHours = new System.Windows.Forms.Label();
            this.displayDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(24, 208);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(116, 208);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(210, 208);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a number of seconds:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minutes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hours:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Days:";
            // 
            // displayTotal
            // 
            this.displayTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTotal.Location = new System.Drawing.Point(58, 166);
            this.displayTotal.Name = "displayTotal";
            this.displayTotal.Size = new System.Drawing.Size(178, 23);
            this.displayTotal.TabIndex = 8;
            this.displayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputSecondsTextBox
            // 
            this.inputSecondsTextBox.Location = new System.Drawing.Point(166, 15);
            this.inputSecondsTextBox.Name = "inputSecondsTextBox";
            this.inputSecondsTextBox.Size = new System.Drawing.Size(108, 20);
            this.inputSecondsTextBox.TabIndex = 12;
            // 
            // displayMinutes
            // 
            this.displayMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayMinutes.Location = new System.Drawing.Point(133, 55);
            this.displayMinutes.Name = "displayMinutes";
            this.displayMinutes.Size = new System.Drawing.Size(100, 23);
            this.displayMinutes.TabIndex = 13;
            this.displayMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayHours
            // 
            this.DisplayHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayHours.Location = new System.Drawing.Point(133, 88);
            this.DisplayHours.Name = "DisplayHours";
            this.DisplayHours.Size = new System.Drawing.Size(100, 23);
            this.DisplayHours.TabIndex = 14;
            this.DisplayHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayDays
            // 
            this.displayDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayDays.Location = new System.Drawing.Point(133, 121);
            this.displayDays.Name = "displayDays";
            this.displayDays.Size = new System.Drawing.Size(100, 23);
            this.displayDays.TabIndex = 15;
            this.displayDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 262);
            this.Controls.Add(this.displayDays);
            this.Controls.Add(this.DisplayHours);
            this.Controls.Add(this.displayMinutes);
            this.Controls.Add(this.inputSecondsTextBox);
            this.Controls.Add(this.displayTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Name = "timeCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label displayTotal;
        private System.Windows.Forms.TextBox inputSecondsTextBox;
        private System.Windows.Forms.Label displayMinutes;
        private System.Windows.Forms.Label DisplayHours;
        private System.Windows.Forms.Label displayDays;
    }
}

