namespace Paint_Job_Estimator
{
    partial class paintJobEstimatorForm
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.squareToBePaintedTextBox = new System.Windows.Forms.TextBox();
            this.pricePerGallonTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gallonsRequiredOutput = new System.Windows.Forms.Label();
            this.hoursLaborRequiredOutput = new System.Windows.Forms.Label();
            this.paintingCostOutput = new System.Windows.Forms.Label();
            this.laborChargeOutput = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(45, 332);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 30);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.Location = new System.Drawing.Point(173, 332);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(75, 30);
            this.eraseButton.TabIndex = 1;
            this.eraseButton.Text = "Erase";
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(286, 332);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 30);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the square feet of wall space to be painted:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter price of the paint per gallon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of gallons required:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hours of labor required:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cost of paiting:";
            // 
            // squareToBePaintedTextBox
            // 
            this.squareToBePaintedTextBox.Location = new System.Drawing.Point(253, 23);
            this.squareToBePaintedTextBox.Name = "squareToBePaintedTextBox";
            this.squareToBePaintedTextBox.Size = new System.Drawing.Size(138, 20);
            this.squareToBePaintedTextBox.TabIndex = 8;
            // 
            // pricePerGallonTextBox
            // 
            this.pricePerGallonTextBox.Location = new System.Drawing.Point(254, 60);
            this.pricePerGallonTextBox.Name = "pricePerGallonTextBox";
            this.pricePerGallonTextBox.Size = new System.Drawing.Size(137, 20);
            this.pricePerGallonTextBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pricePerGallonTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.squareToBePaintedTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Labour charges:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total cost:";
            // 
            // gallonsRequiredOutput
            // 
            this.gallonsRequiredOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsRequiredOutput.Location = new System.Drawing.Point(224, 124);
            this.gallonsRequiredOutput.Name = "gallonsRequiredOutput";
            this.gallonsRequiredOutput.Size = new System.Drawing.Size(100, 23);
            this.gallonsRequiredOutput.TabIndex = 13;
            this.gallonsRequiredOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursLaborRequiredOutput
            // 
            this.hoursLaborRequiredOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursLaborRequiredOutput.Location = new System.Drawing.Point(224, 160);
            this.hoursLaborRequiredOutput.Name = "hoursLaborRequiredOutput";
            this.hoursLaborRequiredOutput.Size = new System.Drawing.Size(100, 23);
            this.hoursLaborRequiredOutput.TabIndex = 14;
            this.hoursLaborRequiredOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paintingCostOutput
            // 
            this.paintingCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintingCostOutput.Location = new System.Drawing.Point(224, 198);
            this.paintingCostOutput.Name = "paintingCostOutput";
            this.paintingCostOutput.Size = new System.Drawing.Size(100, 23);
            this.paintingCostOutput.TabIndex = 15;
            this.paintingCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborChargeOutput
            // 
            this.laborChargeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborChargeOutput.Location = new System.Drawing.Point(224, 232);
            this.laborChargeOutput.Name = "laborChargeOutput";
            this.laborChargeOutput.Size = new System.Drawing.Size(100, 23);
            this.laborChargeOutput.TabIndex = 16;
            this.laborChargeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCost
            // 
            this.totalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCost.Location = new System.Drawing.Point(224, 269);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(100, 23);
            this.totalCost.TabIndex = 17;
            this.totalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paintJobEstimatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 374);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.laborChargeOutput);
            this.Controls.Add(this.paintingCostOutput);
            this.Controls.Add(this.hoursLaborRequiredOutput);
            this.Controls.Add(this.gallonsRequiredOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "paintJobEstimatorForm";
            this.Text = "Paint Job Estimator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox squareToBePaintedTextBox;
        private System.Windows.Forms.TextBox pricePerGallonTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label gallonsRequiredOutput;
        private System.Windows.Forms.Label hoursLaborRequiredOutput;
        private System.Windows.Forms.Label paintingCostOutput;
        private System.Windows.Forms.Label laborChargeOutput;
        private System.Windows.Forms.Label totalCost;
    }
}

