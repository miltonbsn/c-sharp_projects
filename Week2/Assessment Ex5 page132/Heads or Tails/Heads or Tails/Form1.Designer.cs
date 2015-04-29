namespace Heads_or_Tails
{
    partial class HeadorTail
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
            this.showHeadsButton = new System.Windows.Forms.Button();
            this.showTailsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tailPictureBox = new System.Windows.Forms.PictureBox();
            this.headPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showHeadsButton
            // 
            this.showHeadsButton.Location = new System.Drawing.Point(27, 210);
            this.showHeadsButton.Name = "showHeadsButton";
            this.showHeadsButton.Size = new System.Drawing.Size(56, 40);
            this.showHeadsButton.TabIndex = 0;
            this.showHeadsButton.Text = "Show Heads";
            this.showHeadsButton.UseVisualStyleBackColor = true;
            this.showHeadsButton.Click += new System.EventHandler(this.showHeadsButton_Click);
            // 
            // showTailsButton
            // 
            this.showTailsButton.Location = new System.Drawing.Point(108, 210);
            this.showTailsButton.Name = "showTailsButton";
            this.showTailsButton.Size = new System.Drawing.Size(67, 40);
            this.showTailsButton.TabIndex = 1;
            this.showTailsButton.Text = "Show Tails";
            this.showTailsButton.UseVisualStyleBackColor = true;
            this.showTailsButton.Click += new System.EventHandler(this.showTailsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(192, 210);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(61, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tailPictureBox
            // 
            this.tailPictureBox.Image = global::Heads_or_Tails.Properties.Resources.Tail;
            this.tailPictureBox.Location = new System.Drawing.Point(153, 12);
            this.tailPictureBox.Name = "tailPictureBox";
            this.tailPictureBox.Size = new System.Drawing.Size(125, 143);
            this.tailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailPictureBox.TabIndex = 4;
            this.tailPictureBox.TabStop = false;
            this.tailPictureBox.Visible = false;
            // 
            // headPictureBox
            // 
            this.headPictureBox.Image = global::Heads_or_Tails.Properties.Resources.Head;
            this.headPictureBox.Location = new System.Drawing.Point(3, 12);
            this.headPictureBox.Name = "headPictureBox";
            this.headPictureBox.Size = new System.Drawing.Size(125, 143);
            this.headPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headPictureBox.TabIndex = 3;
            this.headPictureBox.TabStop = false;
            // 
            // HeadorTail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tailPictureBox);
            this.Controls.Add(this.headPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showTailsButton);
            this.Controls.Add(this.showHeadsButton);
            this.Name = "HeadorTail";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.tailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showHeadsButton;
        private System.Windows.Forms.Button showTailsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox headPictureBox;
        private System.Windows.Forms.PictureBox tailPictureBox;
    }
}

