namespace rgbSelector
{
    partial class rgbForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.introTitle = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redTextbox = new System.Windows.Forms.TextBox();
            this.greenTextbox = new System.Windows.Forms.TextBox();
            this.blueTextbox = new System.Windows.Forms.TextBox();
            this.previewLabel = new System.Windows.Forms.Label();
            this.previewTexbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(29, 796);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(136, 63);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(643, 796);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(136, 63);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(334, 796);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(136, 63);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // introTitle
            // 
            this.introTitle.AutoSize = true;
            this.introTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.introTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.introTitle.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introTitle.Location = new System.Drawing.Point(222, 47);
            this.introTitle.Name = "introTitle";
            this.introTitle.Size = new System.Drawing.Size(390, 98);
            this.introTitle.TabIndex = 3;
            this.introTitle.Text = "Enter the RGB values below\r\nto see the color in the Preview \r\nbox:";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.BackColor = System.Drawing.Color.Salmon;
            this.redLabel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.Location = new System.Drawing.Point(111, 262);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(73, 32);
            this.redLabel.TabIndex = 4;
            this.redLabel.Text = "Red:";
            this.redLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.BackColor = System.Drawing.Color.PaleGreen;
            this.greenLabel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLabel.Location = new System.Drawing.Point(111, 370);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(98, 32);
            this.greenLabel.TabIndex = 5;
            this.greenLabel.Text = "Green:";
            this.greenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.blueLabel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.Location = new System.Drawing.Point(111, 485);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(77, 32);
            this.blueLabel.TabIndex = 6;
            this.blueLabel.Text = "Blue:";
            this.blueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redTextbox
            // 
            this.redTextbox.Location = new System.Drawing.Point(222, 262);
            this.redTextbox.Name = "redTextbox";
            this.redTextbox.Size = new System.Drawing.Size(100, 31);
            this.redTextbox.TabIndex = 7;
            // 
            // greenTextbox
            // 
            this.greenTextbox.Location = new System.Drawing.Point(222, 373);
            this.greenTextbox.Name = "greenTextbox";
            this.greenTextbox.Size = new System.Drawing.Size(100, 31);
            this.greenTextbox.TabIndex = 8;
            // 
            // blueTextbox
            // 
            this.blueTextbox.Location = new System.Drawing.Point(222, 488);
            this.blueTextbox.Name = "blueTextbox";
            this.blueTextbox.Size = new System.Drawing.Size(100, 31);
            this.blueTextbox.TabIndex = 9;
            // 
            // previewLabel
            // 
            this.previewLabel.AutoSize = true;
            this.previewLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.previewLabel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewLabel.Location = new System.Drawing.Point(591, 259);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(117, 32);
            this.previewLabel.TabIndex = 10;
            this.previewLabel.Text = "Preview:";
            // 
            // previewTexbox
            // 
            this.previewTexbox.Location = new System.Drawing.Point(564, 336);
            this.previewTexbox.Multiline = true;
            this.previewTexbox.Name = "previewTexbox";
            this.previewTexbox.Size = new System.Drawing.Size(168, 140);
            this.previewTexbox.TabIndex = 11;
            // 
            // rgbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 880);
            this.Controls.Add(this.previewTexbox);
            this.Controls.Add(this.previewLabel);
            this.Controls.Add(this.blueTextbox);
            this.Controls.Add(this.greenTextbox);
            this.Controls.Add(this.redTextbox);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.introTitle);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.exitButton);
            this.Name = "rgbForm";
            this.Text = "RGB Selector";
            this.Load += new System.EventHandler(this.rgbForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label introTitle;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.TextBox redTextbox;
        private System.Windows.Forms.TextBox greenTextbox;
        private System.Windows.Forms.TextBox blueTextbox;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.TextBox previewTexbox;
    }
}

