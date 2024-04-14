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
    public partial class DepositForm : Form
    {
        private Account account1 = new Account();

        private DataAccess db = new DataAccess();

        public DepositForm(Account account)
        {
            InitializeComponent();
            account1 = account;
            UpdateDepositTable();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if(ValidateDeposit())
            {
                Deposit newDeposit = new Deposit(amountTextBox.Text,account1.Id);

                db.CreateDeposit(newDeposit);
                db.DepositMoney(newDeposit);
                account1.Money += newDeposit.Amount;

                depositsTable.Rows.Add($"{newDeposit.Amount}$", newDeposit.DepositDate);

                amountTextBox.Text = "";
                MessageBox.Show("Deposit succesfull");
            }
        }

        private bool ValidateDeposit()
        {
            bool output = true;
            int OK = 1;
            decimal amountNumber;
            if (decimal.TryParse(amountTextBox.Text, out amountNumber))
            {
                if (amountNumber < 0 || amountNumber > 100000)
                {
                    output = false;
                    depositAmountError.SetError(amountTextBox, "The deposited amount must\nbe between 0$ and 100000$!");
                    OK = 0;
                }
            }
            else
            {
                output = false;
                depositAmountError.SetError(amountTextBox, "The deposited amount must\nbe between 0$ and 100000$!");
                OK = 0;
            }
            if (OK == 1)
            {
                depositAmountError.SetError(amountTextBox, "");
            }
            OK = 1;
            return output;
        }

        private void UpdateDepositTable()
        {
            List<Deposit> depositList = db.GetAllDeposits(account1);
            foreach (Deposit deposit in depositList)
            {
                depositsTable.Rows.Add($"{deposit.Amount}$", deposit.DepositDate);
            }
        }

    }
}
