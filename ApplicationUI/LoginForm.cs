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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please complete both fields!");
            }
            else
            {
                DataAccess db = new DataAccess();
                Account account = new Account();
                if ((account = db.GetAccountForLogin(usernameTextBox.Text, passwordTextBox.Text)) != null)
                {
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    BankAppForm bankAppForm = new BankAppForm(account);
                    this.Hide();
                    bankAppForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show($"Acount not found!");
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                }
            }
        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm form = new SignupForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm form = new ForgotPasswordForm();
            form.ShowDialog();
        }

    }
}
