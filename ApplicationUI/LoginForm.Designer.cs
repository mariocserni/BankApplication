namespace ApplicationUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.forgotPasswordLink = new System.Windows.Forms.LinkLabel();
            this.signupLabel = new System.Windows.Forms.Label();
            this.signupLink = new System.Windows.Forms.LinkLabel();
            this.userIdPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userIdPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(82, 234);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 21);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loginLabel.Location = new System.Drawing.Point(72, 143);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(413, 37);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = " Login To Your Account";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.Location = new System.Drawing.Point(86, 258);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(390, 29);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(86, 329);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(390, 29);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(82, 305);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 21);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(171, 419);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(207, 65);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // forgotPasswordLink
            // 
            this.forgotPasswordLink.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.forgotPasswordLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgotPasswordLink.AutoSize = true;
            this.forgotPasswordLink.LinkArea = new System.Windows.Forms.LinkArea(0, 16);
            this.forgotPasswordLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgotPasswordLink.LinkColor = System.Drawing.Color.DodgerBlue;
            this.forgotPasswordLink.Location = new System.Drawing.Point(343, 361);
            this.forgotPasswordLink.Name = "forgotPasswordLink";
            this.forgotPasswordLink.Size = new System.Drawing.Size(133, 21);
            this.forgotPasswordLink.TabIndex = 3;
            this.forgotPasswordLink.TabStop = true;
            this.forgotPasswordLink.Text = "Forgot Password?";
            this.forgotPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLink_LinkClicked);
            // 
            // signupLabel
            // 
            this.signupLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupLabel.AutoSize = true;
            this.signupLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLabel.Location = new System.Drawing.Point(117, 514);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(209, 25);
            this.signupLabel.TabIndex = 10;
            this.signupLabel.Text = "Don\'t have an account?";
            // 
            // signupLink
            // 
            this.signupLink.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.signupLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupLink.AutoSize = true;
            this.signupLink.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.signupLink.LinkColor = System.Drawing.Color.DodgerBlue;
            this.signupLink.Location = new System.Drawing.Point(327, 514);
            this.signupLink.Name = "signupLink";
            this.signupLink.Size = new System.Drawing.Size(112, 25);
            this.signupLink.TabIndex = 5;
            this.signupLink.TabStop = true;
            this.signupLink.Text = "Signup now";
            this.signupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLink_LinkClicked);
            // 
            // userIdPictureBox
            // 
            this.userIdPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userIdPictureBox.Image = global::ApplicationUI.Properties.Resources.userId1;
            this.userIdPictureBox.Location = new System.Drawing.Point(223, 25);
            this.userIdPictureBox.Name = "userIdPictureBox";
            this.userIdPictureBox.Size = new System.Drawing.Size(115, 115);
            this.userIdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userIdPictureBox.TabIndex = 5;
            this.userIdPictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 611);
            this.Controls.Add(this.signupLink);
            this.Controls.Add(this.signupLabel);
            this.Controls.Add(this.forgotPasswordLink);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userIdPictureBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(573, 650);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.userIdPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.PictureBox userIdPictureBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel forgotPasswordLink;
        private System.Windows.Forms.Label signupLabel;
        private System.Windows.Forms.LinkLabel signupLink;
    }
}

