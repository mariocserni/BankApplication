using BankLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationUI
{
    public partial class BankAppForm : Form
    {
        private Account account1;

        private BankAppForm bankAppForm;
        public BankAppForm(Account account)
        {
            account1 = account;
            InitializeComponent();
            HideSubMenu();
            nameLabel.Text = $"{account.FirstName}!";
            UpdateBalance();
            bankAppForm = this;
        }

        private void UpdateBalance()
        {
            balanceLabel.Text = $"{account1.Money}$";
        }

        private void HideSubMenu()
        {
            paymentsPanel.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null) 
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                UpdateBalance();
            }
            HideSubMenu();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            openChildForm(new ProfileForm(account1,bankAppForm));
            HideSubMenu();
        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(paymentsPanel);
        }

        #region paymentsButtonRegion
        private void depositButton_Click(object sender, EventArgs e)
        {
            openChildForm(new DepositForm(account1));
            HideSubMenu();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            openChildForm(new WithdrawForm(account1));
            HideSubMenu();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            openChildForm(new TransferForm(account1));
            HideSubMenu();
        }
        #endregion

        private void logOutButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            this.Close();
        }

    }
}
