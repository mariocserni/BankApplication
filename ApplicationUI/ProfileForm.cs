using BankLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationUI
{
    public partial class ProfileForm : Form
    {
        private Account account1 = new Account();

        private BankAppForm bankAppForm;

        public ProfileForm(Account account, BankAppForm bankAppForm)
        {
            InitializeComponent();
            usernameValue.Text = account.Username;
            firstNameValue.Text = account.FirstName;
            lastNameValue.Text = account.LastName;
            emailValue.Text = account.Email;
            ageValue.Text = $"{account.Age}";
            account1 = account;
            this.bankAppForm = bankAppForm;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(account1,bankAppForm);
            form.ShowDialog();
        }
    }
}
