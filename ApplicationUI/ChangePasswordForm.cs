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
    public partial class ChangePasswordForm : Form
    {
        private Account account1 = new Account();

        private BankAppForm bankAppForm;

        public ChangePasswordForm(Account account, BankAppForm bankAppForm)
        {
            InitializeComponent();
            account1 = account;
            this.bankAppForm = bankAppForm;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                DataAccess db = new DataAccess();
                db.ChangePassword(newPasswordTextBox.Text, account1);

                MessageBox.Show("Your password has been changed!\nYou will now be logged out.");

                bankAppForm.Close();
                this.Close();
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int OK = 1;

            if(oldPasswordTextBox.Text != account1.Password)
            {
                output = false;
                oldPasswordError.SetError(oldPasswordTextBox, "Wrong password!");
                OK = 0;
            }
            if (OK == 1)
            {
                oldPasswordError.SetError(oldPasswordTextBox, "");
            }
            OK = 1;

            if (newPasswordTextBox.Text.Length < 6 || newPasswordTextBox.Text.Contains(" "))
            {
                output = false;
                newPasswordError.SetError(newPasswordTextBox, "The new password must contain more than\n6 characters and cannot contain whitespaces!");
                OK = 0;
            }
            if (OK == 1)
            {
                newPasswordError.SetError(newPasswordTextBox, "");
            }
            OK = 1;


            if (confirmNewPasswordTextBox.Text != newPasswordTextBox.Text)
            {
                output = false;
                confirmNewPasswordError.SetError(confirmNewPasswordTextBox, "The password needs to be the same\nas the new password!");
                OK = 0;
            }
            if (OK == 1)
            {
                confirmNewPasswordError.SetError(confirmNewPasswordTextBox, "");
            }

            return output;
        }

        private void oldPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            oldPasswordTextBox.PasswordChar = '*';
        }

        private void newPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            newPasswordTextBox.PasswordChar = '*';
        }

        private void confirmNewPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmNewPasswordTextBox.PasswordChar = '*';
        }
    }
}
