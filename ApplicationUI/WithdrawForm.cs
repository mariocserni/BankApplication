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
    public partial class WithdrawForm : Form
    {
        private Account account1 = new Account();

        private DataAccess db = new DataAccess();

        public WithdrawForm(Account account)
        {
            InitializeComponent();
            account1 = account;
            UpdateWithdraw();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if(ValidateWithdraw()) 
            {
                if (account1.Money >= decimal.Parse(amountTextBox.Text))
                {
                    Withdraw newWithdraw = new Withdraw(amountTextBox.Text, account1.Id);
                    db.CreateWithdraw(newWithdraw);
                    db.WithdrawMoney(newWithdraw);
                    account1.Money -= newWithdraw.Amount;

                    withdrawsTable.Rows.Add($"{newWithdraw.Amount}$", newWithdraw.WithdrawDate);

                    amountTextBox.Text = "";
                    MessageBox.Show("Withdraw succesful!");
                }
                else
                {
                    MessageBox.Show("You don't have enough balance for this action!");
                }

                
            }
        }

        private void UpdateWithdraw()
        {
            List<Withdraw> withdraws = db.GetAllWithdraws(account1);

            foreach (Withdraw withdraw in withdraws)
            {
                withdrawsTable.Rows.Add($"{withdraw.Amount}$", withdraw.WithdrawDate);
            }
        }

        private bool ValidateWithdraw()
        {
            bool output = true;
            int OK = 1;
            decimal amountNumber;
            if (decimal.TryParse(amountTextBox.Text, out amountNumber))
            {
                if (amountNumber < 0 || amountNumber > 100000)
                {
                    output = false;
                    withdrawAmountError.SetError(amountTextBox, "The withdrawn amount must\nbe between 0$ and 100000$!");
                    OK = 0;
                }
            }
            else
            {
                output = false;
                withdrawAmountError.SetError(amountTextBox, "The withdrawn amount must\nbe between 0$ and 100000$!");
                OK = 0;
            }
            if (OK == 1)
            {
                withdrawAmountError.SetError(amountTextBox, "");
            }
            OK = 1;
            return output;
        }
    }
}
