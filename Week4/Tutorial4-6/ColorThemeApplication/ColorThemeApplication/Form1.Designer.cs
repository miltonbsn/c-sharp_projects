namespace ColorThemeApplication
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
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.yellowButton = new System.Windows.Forms.RadioButton();
            this.redButton = new System.Windows.Forms.RadioButton();
            this.whiteButton = new System.Windows.Forms.RadioButton();
            this.normalButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.colorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.normalButton);
            this.colorGroupBox.Controls.Add(this.whiteButton);
            this.colorGroupBox.Controls.Add(this.redButton);
            this.colorGroupBox.Controls.Add(this.yellowButton);
            this.colorGroupBox.Location = new System.Drawing.Point(12, 12);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(169, 165);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Select a Background Color";
            // 
            // yellowButton
            // 
            this.yellowButton.AutoSize = true;
            this.yellowButton.Location = new System.Drawing.Point(39, 29);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(56, 17);
            this.yellowButton.TabIndex = 0;
            this.yellowButton.TabStop = true;
            this.yellowButton.Text = "Yellow";
            this.yellowButton.UseVisualStyleBackColor = true;
            this.yellowButton.CheckedChanged += new System.EventHandler(this.yellowButton_CheckedChanged);
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Location = new System.Drawing.Point(39, 61);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(45, 17);
            this.redButton.TabIndex = 1;
            this.redButton.TabStop = true;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.CheckedChanged += new System.EventHandler(this.redButton_CheckedChanged);
            // 
            // whiteButton
            // 
            this.whiteButton.AutoSize = true;
            this.whiteButton.Location = new System.Drawing.Point(39, 93);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(53, 17);
            this.whiteButton.TabIndex = 2;
            this.whiteButton.TabStop = true;
            this.whiteButton.Text = "White";
            this.whiteButton.UseVisualStyleBackColor = true;
            this.whiteButton.CheckedChanged += new System.EventHandler(this.whiteButton_CheckedChanged);
            // 
            // normalButton
            // 
            this.normalButton.AutoSize = true;
            this.normalButton.Location = new System.Drawing.Point(39, 126);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(96, 17);
            this.normalButton.TabIndex = 3;
            this.normalButton.TabStop = true;
            this.normalButton.Text = "Back to normal";
            this.normalButton.UseVisualStyleBackColor = true;
            this.normalButton.CheckedChanged += new System.EventHandler(this.normalButton_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(61, 193);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 228);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.colorGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.RadioButton normalButton;
        private System.Windows.Forms.RadioButton whiteButton;
        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton yellowButton;
        private System.Windows.Forms.Button exitButton;
    }
}

