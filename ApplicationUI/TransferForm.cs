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
    public partial class TransferForm : Form
    {
        private DataAccess db = new DataAccess();

        private Account account;

        public TransferForm(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            int accountId;
            if ((accountId = ValidateTransfer()) != 0)
            {
                decimal amount = decimal.Parse(amountTextBox.Text);
                if (account.Money >= amount)
                {
                    DataAccess db = new DataAccess();
                    db.TransferMoney(accountId, account.Id, decimal.Parse(amountTextBox.Text));
                    account.Money -= amount;

                    MessageBox.Show("Transfer Succesful!");
                }
                else
                {
                    MessageBox.Show("You don't have enough balance for this action!");
                }
            }
        }

        private int ValidateTransfer()
        {
            bool output = true;
            int OK = 1;
            int accountId = 0;

            Account accountTaken = db.VerifyUsername(usernameTextBox.Text);
            if (accountTaken == null)
            {
                output = false;
                MessageBox.Show("Account not found!");
            }
            else if (accountTaken.Username == account.Username)
            {
                output = false;
                MessageBox.Show("You cannot transfer money to yourself!");
            }
            else
            {
                accountId = accountTaken.Id;
            }

            decimal amountNumber;
            if (decimal.TryParse(amountTextBox.Text, out amountNumber))
            {
                if (amountNumber < 0 || amountNumber > 100000)
                {
                    output = false;
                    transferAmountError.SetError(amountTextBox, "The transferred amount must\nbe between 0$ and 100000$!");
                    OK = 0;
                }
            }
            else
            {
                output = false;
                transferAmountError.SetError(amountTextBox, "The transferred amount must\nbe between 0$ and 100000$!");
                OK = 0;
            }
            if (OK == 1)
            {
                transferAmountError.SetError(amountTextBox, "");
            }
            OK = 1;

            if (output == true && accountId != 0)
            {
                return accountId;
            }
            else
            {
                return 0;
            }
        }
    }
}
