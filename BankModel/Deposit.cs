using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Deposit
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string DepositDate { get; set; }
        public int AccountId { get; set; }  
        public Deposit(string amount, int accountId)
        {
            Amount = decimal.Parse(amount);
            DateTime Date = DateTime.Now;
            DepositDate = Date.ToString("yyyy-MM-dd   HH:mm");
            AccountId = accountId;
        }

        public Deposit()
        {
            
        }
    }
}
