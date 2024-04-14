using BankLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ApplicationUI
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Account account = new Account(usernameTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text, passTextBox.Text, emailTextBox.Text, ageTextBox.Text);

                DataAccess db = new DataAccess();
                db.CreateAccount(account);

                MessageBox.Show("Your account has been created!");
                this.Close();
            }

        }

        private bool ValidateForm()
        {
            bool output = true;
            int OK = 1;

            if (usernameTextBox.Text.Length < 3 || usernameTextBox.Text.Length > 20 || usernameTextBox.Text.Contains(" "))
            {
                output = false;
                usernameError.SetError(usernameTextBox, "The username must be between 3 and 20 characters, without spaces or special characters!");
                OK = 0;
            }
            else 
            { 
                for (int i = 0; i < usernameTextBox.Text.Length; i++)
                {
                    if (Char.IsLetterOrDigit(usernameTextBox.Text[i]) == false)
                    {
                        output = false;
                        usernameError.SetError(usernameTextBox, "The username must be between 3 and 20 characters, without spaces or special characters!");
                        OK = 0;
                        break;
                    }
                }
            }
            if(OK == 1)
            {
                usernameError.SetError(usernameTextBox, "");
            }
            OK = 1;


            if (firstNameTextBox.Text.Length < 2 || firstNameTextBox.Text.Length > 20)
            {
                output = false;
                firstNameError.SetError(firstNameTextBox, "The name must be between 2 and 20 characters, without special characters!");
                OK = 0;
            }
            else
            {
                for (int i = 0; i < firstNameTextBox.Text.Length; i++)
                {
                    if (Char.IsLetterOrDigit(firstNameTextBox.Text[i]) || firstNameTextBox.Text[i] == ' ')
                        continue;
                    else
                    {
                        output = false;
                        firstNameError.SetError(firstNameTextBox, "The name must be between 2 and 20 characters, without special characters!");
                        OK = 0;
                        break;
                    }
                }
            }
            if(OK == 1)
            {
                firstNameError.SetError(firstNameTextBox, "");
            }
            OK = 1;


            if (lastNameTextBox.Text.Length < 2 || lastNameTextBox.Text.Length > 20)
            {
                output = false;
                lastNameError.SetError(lastNameTextBox, "The name must be between 2 and 20 characters, without special characters!");
                OK = 0;
            }
            else
            {
                for (int i = 0; i < lastNameTextBox.Text.Length; i++)
                {
                    if (Char.IsLetterOrDigit(lastNameTextBox.Text[i]) || lastNameTextBox.Text[i] == ' ')
                        continue;
                    else
                    {
                        output = false;
                        lastNameError.SetError(lastNameTextBox, "The name must be between 2 and 20 characters, without special characters!");
                        OK = 0;
                        break;
                    }
                }
            }
            if (OK == 1)
            {
                lastNameError.SetError(lastNameTextBox, "");
            }
            OK = 1;


            if (emailTextBox.Text.Length < 1 ||  emailTextBox.Text.Length > 30 || !emailTextBox.Text.Contains("@") || !emailTextBox.Text.Contains(".") || emailTextBox.Text.Contains(" "))
            {
                output = false;
                emailError.SetError(emailTextBox, "Invalid email!");
                OK = 0;
            }
            if (OK == 1)
            {
                emailError.SetError(emailTextBox, "");
            }
            OK = 1;


            int ageNumber;
            if(int.TryParse(ageTextBox.Text, out ageNumber))
            {
                if(ageNumber < 16 || ageNumber > 100) 
                {
                    output = false;
                    ageError.SetError(ageTextBox, "Invalid age!");
                    OK = 0;
                }
            }
            else
            {
                output = false;
                ageError.SetError(ageTextBox, "Invalid age!");
                OK = 0;
            }
            if (OK == 1)
            {
                ageError.SetError(ageTextBox, "");
            }
            OK = 1;


            if(passTextBox.Text.Length < 6 || passTextBox.Text.Contains(" "))
            {
                output = false;
                passwordError.SetError(passTextBox, "The password must contain more then 6 characters and cannot contain whitespaces!");
                OK = 0;
            }
            if (OK == 1)
            {
                passwordError.SetError(passTextBox, "");
            }
            OK = 1;


            if(confirmPassTextBox.Text != passTextBox.Text) 
            {
                output = false;
                confirmPassError.SetError(confirmPassTextBox, "The password needs to be the same!");
                OK = 0;
            }
            if (OK == 1)
            {
                confirmPassError.SetError(passTextBox, "");
            }

            return output;
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            passTextBox.PasswordChar = '*';
        }

        private void confirmPassTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmPassTextBox.PasswordChar = '*';
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
