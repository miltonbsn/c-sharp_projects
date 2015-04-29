namespace DistanceCover
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputDistancetextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.toGroupBox = new System.Windows.Forms.GroupBox();
            this.toListBox = new System.Windows.Forms.ListBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.distanceConvertedLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a distance to convert:";
            // 
            // inputDistancetextBox
            // 
            this.inputDistancetextBox.Location = new System.Drawing.Point(171, 20);
            this.inputDistancetextBox.Name = "inputDistancetextBox";
            this.inputDistancetextBox.Size = new System.Drawing.Size(135, 20);
            this.inputDistancetextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fromListBox);
            this.groupBox1.Location = new System.Drawing.Point(59, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // fromListBox
            // 
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.fromListBox.Location = new System.Drawing.Point(6, 19);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(71, 69);
            this.fromListBox.TabIndex = 0;
            // 
            // toGroupBox
            // 
            this.toGroupBox.Controls.Add(this.toListBox);
            this.toGroupBox.Location = new System.Drawing.Point(184, 61);
            this.toGroupBox.Name = "toGroupBox";
            this.toGroupBox.Size = new System.Drawing.Size(101, 97);
            this.toGroupBox.TabIndex = 3;
            this.toGroupBox.TabStop = false;
            this.toGroupBox.Text = "To";
            // 
            // toListBox
            // 
            this.toListBox.FormattingEnabled = true;
            this.toListBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.toListBox.Location = new System.Drawing.Point(6, 19);
            this.toListBox.Name = "toListBox";
            this.toListBox.Size = new System.Drawing.Size(78, 69);
            this.toListBox.TabIndex = 0;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(92, 233);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(184, 233);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Converted distance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // distanceConvertedLabel
            // 
            this.distanceConvertedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distanceConvertedLabel.Location = new System.Drawing.Point(171, 184);
            this.distanceConvertedLabel.Name = "distanceConvertedLabel";
            this.distanceConvertedLabel.Size = new System.Drawing.Size(105, 23);
            this.distanceConvertedLabel.TabIndex = 8;
            this.distanceConvertedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 284);
            this.Controls.Add(this.distanceConvertedLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.toGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputDistancetextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.toGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputDistancetextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.GroupBox toGroupBox;
        private System.Windows.Forms.ListBox toListBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label distanceConvertedLabel;
    }
}

