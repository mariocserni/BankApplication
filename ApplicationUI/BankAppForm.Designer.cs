namespace ApplicationUI
{
    partial class BankAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAppForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.paymentsPanel = new System.Windows.Forms.Panel();
            this.transferButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.mazeBankLabel1 = new System.Windows.Forms.Label();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.yourBalanceIsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mazeBankLabel2 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.paymentsButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.mazeBankLogo = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.paymentsPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.childFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazeBankLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSideMenu.Controls.Add(this.logOutButton);
            this.panelSideMenu.Controls.Add(this.paymentsPanel);
            this.panelSideMenu.Controls.Add(this.paymentsButton);
            this.panelSideMenu.Controls.Add(this.profileButton);
            this.panelSideMenu.Controls.Add(this.homeButton);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 705);
            this.panelSideMenu.TabIndex = 0;
            // 
            // paymentsPanel
            // 
            this.paymentsPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.paymentsPanel.Controls.Add(this.transferButton);
            this.paymentsPanel.Controls.Add(this.withdrawButton);
            this.paymentsPanel.Controls.Add(this.depositButton);
            this.paymentsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentsPanel.Location = new System.Drawing.Point(0, 347);
            this.paymentsPanel.Name = "paymentsPanel";
            this.paymentsPanel.Size = new System.Drawing.Size(250, 154);
            this.paymentsPanel.TabIndex = 4;
            // 
            // transferButton
            // 
            this.transferButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.transferButton.FlatAppearance.BorderSize = 0;
            this.transferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.transferButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transferButton.Location = new System.Drawing.Point(0, 100);
            this.transferButton.Name = "transferButton";
            this.transferButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.transferButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.transferButton.Size = new System.Drawing.Size(250, 50);
            this.transferButton.TabIndex = 2;
            this.transferButton.Text = "Transfer";
            this.transferButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.withdrawButton.FlatAppearance.BorderSize = 0;
            this.withdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrawButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.withdrawButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.withdrawButton.Location = new System.Drawing.Point(0, 50);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.withdrawButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.withdrawButton.Size = new System.Drawing.Size(250, 50);
            this.withdrawButton.TabIndex = 1;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.depositButton.FlatAppearance.BorderSize = 0;
            this.depositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.depositButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.depositButton.Location = new System.Drawing.Point(0, 0);
            this.depositButton.Name = "depositButton";
            this.depositButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.depositButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.depositButton.Size = new System.Drawing.Size(250, 50);
            this.depositButton.TabIndex = 0;
            this.depositButton.Text = "Deposit";
            this.depositButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.mazeBankLabel1);
            this.panelLogo.Controls.Add(this.mazeBankLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 167);
            this.panelLogo.TabIndex = 0;
            // 
            // mazeBankLabel1
            // 
            this.mazeBankLabel1.AutoSize = true;
            this.mazeBankLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mazeBankLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.mazeBankLabel1.Location = new System.Drawing.Point(56, 122);
            this.mazeBankLabel1.Name = "mazeBankLabel1";
            this.mazeBankLabel1.Size = new System.Drawing.Size(138, 32);
            this.mazeBankLabel1.TabIndex = 1;
            this.mazeBankLabel1.Text = "Maze Bank";
            // 
            // childFormPanel
            // 
            this.childFormPanel.Controls.Add(this.balanceLabel);
            this.childFormPanel.Controls.Add(this.yourBalanceIsLabel);
            this.childFormPanel.Controls.Add(this.nameLabel);
            this.childFormPanel.Controls.Add(this.mazeBankLabel2);
            this.childFormPanel.Controls.Add(this.welcomeLabel);
            this.childFormPanel.Controls.Add(this.pictureBox1);
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(250, 0);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(982, 705);
            this.childFormPanel.TabIndex = 1;
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.balanceLabel.Location = new System.Drawing.Point(245, 101);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(154, 37);
            this.balanceLabel.TabIndex = 9;
            this.balanceLabel.Text = "<balance>";
            // 
            // yourBalanceIsLabel
            // 
            this.yourBalanceIsLabel.AutoSize = true;
            this.yourBalanceIsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourBalanceIsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.yourBalanceIsLabel.Location = new System.Drawing.Point(22, 101);
            this.yourBalanceIsLabel.Name = "yourBalanceIsLabel";
            this.yourBalanceIsLabel.Size = new System.Drawing.Size(229, 37);
            this.yourBalanceIsLabel.TabIndex = 8;
            this.yourBalanceIsLabel.Text = "Your balance is : ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.nameLabel.Location = new System.Drawing.Point(115, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(161, 47);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "<name>";
            // 
            // mazeBankLabel2
            // 
            this.mazeBankLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mazeBankLabel2.AutoSize = true;
            this.mazeBankLabel2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mazeBankLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.mazeBankLabel2.Location = new System.Drawing.Point(385, 589);
            this.mazeBankLabel2.Name = "mazeBankLabel2";
            this.mazeBankLabel2.Size = new System.Drawing.Size(212, 50);
            this.mazeBankLabel2.TabIndex = 2;
            this.mazeBankLabel2.Text = "Maze Bank";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.welcomeLabel.Location = new System.Drawing.Point(3, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(116, 47);
            this.welcomeLabel.TabIndex = 6;
            this.welcomeLabel.Text = "Hello,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ApplicationUI.Properties.Resources.BankLogo;
            this.pictureBox1.Location = new System.Drawing.Point(123, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logOutButton
            // 
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.logOutButton.Image = global::ApplicationUI.Properties.Resources.log_out;
            this.logOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutButton.Location = new System.Drawing.Point(0, 645);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logOutButton.Size = new System.Drawing.Size(250, 60);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // paymentsButton
            // 
            this.paymentsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paymentsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.paymentsButton.FlatAppearance.BorderSize = 0;
            this.paymentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.paymentsButton.Image = global::ApplicationUI.Properties.Resources.transactions_icon;
            this.paymentsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.paymentsButton.Location = new System.Drawing.Point(0, 287);
            this.paymentsButton.Name = "paymentsButton";
            this.paymentsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.paymentsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.paymentsButton.Size = new System.Drawing.Size(250, 60);
            this.paymentsButton.TabIndex = 3;
            this.paymentsButton.Text = "Transactions";
            this.paymentsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentsButton.UseVisualStyleBackColor = true;
            this.paymentsButton.Click += new System.EventHandler(this.paymentsButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.profileButton.Image = global::ApplicationUI.Properties.Resources.userId;
            this.profileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profileButton.Location = new System.Drawing.Point(0, 227);
            this.profileButton.Name = "profileButton";
            this.profileButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.profileButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.profileButton.Size = new System.Drawing.Size(250, 60);
            this.profileButton.TabIndex = 2;
            this.profileButton.Text = "Profile";
            this.profileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.homeButton.Image = global::ApplicationUI.Properties.Resources.home_icon;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.homeButton.Location = new System.Drawing.Point(0, 167);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.homeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeButton.Size = new System.Drawing.Size(250, 60);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // mazeBankLogo
            // 
            this.mazeBankLogo.Image = global::ApplicationUI.Properties.Resources.BankLogo;
            this.mazeBankLogo.Location = new System.Drawing.Point(0, -20);
            this.mazeBankLogo.Name = "mazeBankLogo";
            this.mazeBankLogo.Size = new System.Drawing.Size(250, 164);
            this.mazeBankLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mazeBankLogo.TabIndex = 0;
            this.mazeBankLogo.TabStop = false;
            // 
            // BankAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 705);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(889, 530);
            this.Name = "BankAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Account";
            this.panelSideMenu.ResumeLayout(false);
            this.paymentsPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.childFormPanel.ResumeLayout(false);
            this.childFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazeBankLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel paymentsPanel;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.PictureBox mazeBankLogo;
        private System.Windows.Forms.Label mazeBankLabel1;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Label mazeBankLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label yourBalanceIsLabel;
        private System.Windows.Forms.Button paymentsButton;
    }
}