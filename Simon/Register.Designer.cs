namespace Simon
{
    partial class Register
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
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Pass1Label = new System.Windows.Forms.Label();
            this.Pass2Label = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.Pass1TextBox = new System.Windows.Forms.TextBox();
            this.Pass2TextBox = new System.Windows.Forms.TextBox();
            this.SignupButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(156, 27);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(214, 22);
            this.UserTextBox.TabIndex = 0;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserLabel.Location = new System.Drawing.Point(12, 29);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(86, 20);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Username";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailLabel.Location = new System.Drawing.Point(12, 63);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 20);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email";
            // 
            // Pass1Label
            // 
            this.Pass1Label.AutoSize = true;
            this.Pass1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pass1Label.Location = new System.Drawing.Point(12, 92);
            this.Pass1Label.Name = "Pass1Label";
            this.Pass1Label.Size = new System.Drawing.Size(83, 20);
            this.Pass1Label.TabIndex = 3;
            this.Pass1Label.Text = "Password";
            // 
            // Pass2Label
            // 
            this.Pass2Label.AutoSize = true;
            this.Pass2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pass2Label.Location = new System.Drawing.Point(12, 126);
            this.Pass2Label.Name = "Pass2Label";
            this.Pass2Label.Size = new System.Drawing.Size(117, 20);
            this.Pass2Label.TabIndex = 4;
            this.Pass2Label.Text = "Ponovno vnesi";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(156, 61);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(214, 22);
            this.EmailTextBox.TabIndex = 5;
            // 
            // Pass1TextBox
            // 
            this.Pass1TextBox.Location = new System.Drawing.Point(155, 92);
            this.Pass1TextBox.Name = "Pass1TextBox";
            this.Pass1TextBox.Size = new System.Drawing.Size(215, 22);
            this.Pass1TextBox.TabIndex = 6;
            // 
            // Pass2TextBox
            // 
            this.Pass2TextBox.Location = new System.Drawing.Point(156, 126);
            this.Pass2TextBox.Name = "Pass2TextBox";
            this.Pass2TextBox.Size = new System.Drawing.Size(214, 22);
            this.Pass2TextBox.TabIndex = 7;
            // 
            // SignupButton
            // 
            this.SignupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SignupButton.Location = new System.Drawing.Point(57, 186);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(100, 35);
            this.SignupButton.TabIndex = 8;
            this.SignupButton.Text = "Sign up";
            this.SignupButton.UseVisualStyleBackColor = true;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginButton.Location = new System.Drawing.Point(213, 186);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 35);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.Location = new System.Drawing.Point(57, 238);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 35);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeButton.Location = new System.Drawing.Point(213, 238);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(100, 35);
            this.HomeButton.TabIndex = 11;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(388, 303);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.Pass2TextBox);
            this.Controls.Add(this.Pass1TextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.Pass2Label);
            this.Controls.Add(this.Pass1Label);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.UserTextBox);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label Pass1Label;
        private System.Windows.Forms.Label Pass2Label;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox Pass1TextBox;
        private System.Windows.Forms.TextBox Pass2TextBox;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button HomeButton;
    }
}