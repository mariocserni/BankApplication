using BankLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationUI
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Account account = new Account();
            if((account = db.GetAccountForForgotPassword(usernameTextBox.Text,emailTextBox.Text)) != null) 
            {
                MessageBox.Show($"Your account's password is : {account.Password}");
                this.Close();
            }
            else
            {
                MessageBox.Show($"Acount not found!");
                usernameTextBox.Text = "";
                emailTextBox.Text = "";
            }
        }
    }
}
