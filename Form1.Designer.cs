namespace assignment8_PavelGolovan
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
            this.boyLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.girlLabel = new System.Windows.Forms.Label();
            this.boyTextBox = new System.Windows.Forms.TextBox();
            this.girlTextBox = new System.Windows.Forms.TextBox();
            this.boyResultLabel = new System.Windows.Forms.Label();
            this.girlResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boyLabel
            // 
            this.boyLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boyLabel.ForeColor = System.Drawing.Color.DimGray;
            this.boyLabel.Location = new System.Drawing.Point(162, 18);
            this.boyLabel.Name = "boyLabel";
            this.boyLabel.Size = new System.Drawing.Size(237, 54);
            this.boyLabel.TabIndex = 0;
            this.boyLabel.Text = "Boy Names";
            this.boyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.Location = new System.Drawing.Point(12, 318);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(92, 38);
            this.helpButton.TabIndex = 1;
            this.helpButton.Text = "Help";
            this.helpButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(900, 318);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 38);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkButton.Location = new System.Drawing.Point(456, 279);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(92, 38);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Check";
            this.checkButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // girlLabel
            // 
            this.girlLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.girlLabel.ForeColor = System.Drawing.Color.DimGray;
            this.girlLabel.Location = new System.Drawing.Point(605, 18);
            this.girlLabel.Name = "girlLabel";
            this.girlLabel.Size = new System.Drawing.Size(237, 54);
            this.girlLabel.TabIndex = 4;
            this.girlLabel.Text = "Girl Names";
            this.girlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // boyTextBox
            // 
            this.boyTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boyTextBox.Location = new System.Drawing.Point(171, 84);
            this.boyTextBox.Name = "boyTextBox";
            this.boyTextBox.Size = new System.Drawing.Size(228, 34);
            this.boyTextBox.TabIndex = 5;
            // 
            // girlTextBox
            // 
            this.girlTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.girlTextBox.Location = new System.Drawing.Point(614, 84);
            this.girlTextBox.Name = "girlTextBox";
            this.girlTextBox.Size = new System.Drawing.Size(228, 34);
            this.girlTextBox.TabIndex = 6;
            // 
            // boyResultLabel
            // 
            this.boyResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boyResultLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boyResultLabel.Location = new System.Drawing.Point(171, 130);
            this.boyResultLabel.Name = "boyResultLabel";
            this.boyResultLabel.Size = new System.Drawing.Size(228, 130);
            this.boyResultLabel.TabIndex = 7;
            // 
            // girlResultLabel
            // 
            this.girlResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.girlResultLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.girlResultLabel.Location = new System.Drawing.Point(614, 130);
            this.girlResultLabel.Name = "girlResultLabel";
            this.girlResultLabel.Size = new System.Drawing.Size(228, 130);
            this.girlResultLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 368);
            this.Controls.Add(this.girlResultLabel);
            this.Controls.Add(this.boyResultLabel);
            this.Controls.Add(this.girlTextBox);
            this.Controls.Add(this.boyTextBox);
            this.Controls.Add(this.girlLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.boyLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Name Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label boyLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label girlLabel;
        private System.Windows.Forms.TextBox boyTextBox;
        private System.Windows.Forms.TextBox girlTextBox;
        private System.Windows.Forms.Label boyResultLabel;
        private System.Windows.Forms.Label girlResultLabel;
    }
}

