namespace ApplicationUI
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.oldPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.confirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.oldPasswordError = new System.Windows.Forms.ErrorProvider(this.components);
            this.newPasswordError = new System.Windows.Forms.ErrorProvider(this.components);
            this.confirmNewPasswordError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.oldPasswordError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmNewPasswordError)).BeginInit();
            this.SuspendLayout();
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldPasswordTextBox.Location = new System.Drawing.Point(225, 53);
            this.oldPasswordTextBox.MinimumSize = new System.Drawing.Size(241, 29);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(241, 29);
            this.oldPasswordTextBox.TabIndex = 3;
            this.oldPasswordTextBox.TextChanged += new System.EventHandler(this.oldPasswordTextBox_TextChanged);
            // 
            // oldPasswordLabel
            // 
            this.oldPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldPasswordLabel.AutoSize = true;
            this.oldPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPasswordLabel.Location = new System.Drawing.Point(38, 49);
            this.oldPasswordLabel.Name = "oldPasswordLabel";
            this.oldPasswordLabel.Size = new System.Drawing.Size(138, 30);
            this.oldPasswordLabel.TabIndex = 2;
            this.oldPasswordLabel.Text = "Old Password";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPasswordTextBox.Location = new System.Drawing.Point(225, 112);
            this.newPasswordTextBox.MinimumSize = new System.Drawing.Size(241, 29);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(241, 29);
            this.newPasswordTextBox.TabIndex = 5;
            this.newPasswordTextBox.TextChanged += new System.EventHandler(this.newPasswordTextBox_TextChanged);
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(38, 108);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(147, 30);
            this.newPasswordLabel.TabIndex = 4;
            this.newPasswordLabel.Text = "New Password";
            // 
            // confirmNewPasswordTextBox
            // 
            this.confirmNewPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(225, 171);
            this.confirmNewPasswordTextBox.MinimumSize = new System.Drawing.Size(241, 29);
            this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(241, 29);
            this.confirmNewPasswordTextBox.TabIndex = 7;
            this.confirmNewPasswordTextBox.TextChanged += new System.EventHandler(this.confirmNewPasswordTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirm Password";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changePasswordButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.changePasswordButton.FlatAppearance.BorderSize = 0;
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.ForeColor = System.Drawing.Color.White;
            this.changePasswordButton.Location = new System.Drawing.Point(144, 237);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(217, 56);
            this.changePasswordButton.TabIndex = 8;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // oldPasswordError
            // 
            this.oldPasswordError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.oldPasswordError.ContainerControl = this;
            // 
            // newPasswordError
            // 
            this.newPasswordError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.newPasswordError.ContainerControl = this;
            // 
            // confirmNewPasswordError
            // 
            this.confirmNewPasswordError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.confirmNewPasswordError.ContainerControl = this;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 322);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.confirmNewPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.oldPasswordTextBox);
            this.Controls.Add(this.oldPasswordLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(521, 361);
            this.MinimumSize = new System.Drawing.Size(521, 361);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangePasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.oldPasswordError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmNewPasswordError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.Label oldPasswordLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox confirmNewPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.ErrorProvider oldPasswordError;
        private System.Windows.Forms.ErrorProvider newPasswordError;
        private System.Windows.Forms.ErrorProvider confirmNewPasswordError;
    }
}