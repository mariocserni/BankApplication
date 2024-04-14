namespace ApplicationUI
{
    partial class SignupForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.signupLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPassTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.accountLabel = new System.Windows.Forms.Label();
            this.usernameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.firstNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ageError = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordError = new System.Windows.Forms.ErrorProvider(this.components);
            this.confirmPassError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usernameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameError)).BeginInit();
            this.SuspendLayout();
            // 
            // signupLabel
            // 
            this.signupLabel.AutoSize = true;
            this.signupLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.signupLabel.Location = new System.Drawing.Point(215, 49);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(143, 37);
            this.signupLabel.TabIndex = 0;
            this.signupLabel.Text = "Sign Up";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(91, 158);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(390, 29);
            this.usernameTextBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(87, 134);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 21);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(91, 326);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(390, 29);
            this.emailTextBox.TabIndex = 4;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(87, 302);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 21);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(91, 214);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(390, 29);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(87, 190);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 21);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(91, 382);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(390, 29);
            this.ageTextBox.TabIndex = 5;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(87, 358);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(37, 21);
            this.ageLabel.TabIndex = 8;
            this.ageLabel.Text = "Age";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(91, 438);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(390, 29);
            this.passTextBox.TabIndex = 6;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(87, 414);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 21);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password";
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.Location = new System.Drawing.Point(91, 494);
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.Size = new System.Drawing.Size(390, 29);
            this.confirmPassTextBox.TabIndex = 7;
            this.confirmPassTextBox.TextChanged += new System.EventHandler(this.confirmPassTextBox_TextChanged);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(87, 470);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(137, 21);
            this.confirmPasswordLabel.TabIndex = 12;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.createAccountButton.FlatAppearance.BorderSize = 0;
            this.createAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton.ForeColor = System.Drawing.Color.White;
            this.createAccountButton.Location = new System.Drawing.Point(183, 561);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(207, 65);
            this.createAccountButton.TabIndex = 8;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // loginLink
            // 
            this.loginLink.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.loginLink.AutoSize = true;
            this.loginLink.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.loginLink.LinkColor = System.Drawing.Color.DodgerBlue;
            this.loginLink.Location = new System.Drawing.Point(323, 642);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(154, 25);
            this.loginLink.TabIndex = 9;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Go back to Login";
            this.loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.Location = new System.Drawing.Point(96, 642);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(228, 25);
            this.accountLabel.TabIndex = 16;
            this.accountLabel.Text = "Already have an account?";
            // 
            // usernameError
            // 
            this.usernameError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.usernameError.ContainerControl = this;
            // 
            // firstNameError
            // 
            this.firstNameError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.firstNameError.ContainerControl = this;
            // 
            // emailError
            // 
            this.emailError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.emailError.ContainerControl = this;
            // 
            // ageError
            // 
            this.ageError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ageError.ContainerControl = this;
            // 
            // passwordError
            // 
            this.passwordError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.passwordError.ContainerControl = this;
            // 
            // confirmPassError
            // 
            this.confirmPassError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.confirmPassError.ContainerControl = this;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(91, 270);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(390, 29);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(87, 246);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 21);
            this.lastNameLabel.TabIndex = 18;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameError
            // 
            this.lastNameError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.lastNameError.ContainerControl = this;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 697);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.confirmPassTextBox);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.signupLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(588, 736);
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)(this.usernameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPassError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signupLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox confirmPassTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.LinkLabel loginLink;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.ErrorProvider usernameError;
        private System.Windows.Forms.ErrorProvider firstNameError;
        private System.Windows.Forms.ErrorProvider emailError;
        private System.Windows.Forms.ErrorProvider ageError;
        private System.Windows.Forms.ErrorProvider passwordError;
        private System.Windows.Forms.ErrorProvider confirmPassError;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.ErrorProvider lastNameError;
    }
}