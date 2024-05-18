using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Withdraw
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string WithdrawDate { get; set; }
        public int AccountId { get; set; }
        public Withdraw(string amount, int accountId)
        {
            Amount = decimal.Parse(amount);
            DateTime Date = DateTime.Now;
            WithdrawDate = Date.ToString("yyyy-MM-dd HH:mm");
            AccountId = accountId;
        }

        public Withdraw()
        {

        }
    }
}
