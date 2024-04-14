using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankLibrary
{
    public class DataAccess
    {
        private readonly IDbConnection _connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BankDB"));

        public Account CreateAccount(Account account)
        {
            using (_connection)
            {
                var p = new DynamicParameters();
                p.Add("@Username",account.Username);
                p.Add("@FirstName", account.FirstName);
                p.Add("@LastName", account.LastName);
                p.Add("@Password", account.Password);
                p.Add("@Email", account.Email);
                p.Add("@Age", account.Age);
                p.Add("@Money", 0);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                _connection.Execute("dbo.Accounts_Insert", p, commandType: CommandType.StoredProcedure);
                account.Id = p.Get<int>("@id");

                return account;
            }
        }

        public Account GetAccountForLogin(string username, string password) 
        {
            using (_connection)
            {
                Account account = _connection.Query<Account>($"dbo.GetAccountForLogin {username},{password}").FirstOrDefault();

                return account;
            }
        }

        public Account GetAccountForForgotPassword(string username, string email)
        {
            using (_connection)
            {
                Account account = _connection.Query<Account>("dbo.GetAccountForForgotPassword", new { username, email }, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return account;
            }
        }

        public Deposit CreateDeposit(Deposit deposit)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BankDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Amount", deposit.Amount);
                p.Add("@DepositDate", deposit.DepositDate);
                p.Add("@AccountId", deposit.AccountId);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                _connection.Execute("dbo.Deposit_Insert", p, commandType: CommandType.StoredProcedure);
                deposit.Id = p.Get<int>("@id");

                return deposit;
            }
        }

        public Withdraw CreateWithdraw(Withdraw withdraw) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BankDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Amount", withdraw.Amount);
                p.Add("@WithdrawDate", withdraw.WithdrawDate);
                p.Add("@AccountId", withdraw.AccountId);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                _connection.Execute("dbo.Withdraw_Insert", p, commandType: CommandType.StoredProcedure);
                withdraw.Id = p.Get<int>("@id");

                return withdraw;
            }
        }

        public void DepositMoney(Deposit deposit)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BankDB")))
            {
                var p = new DynamicParameters();
                p.Add("@AccountId", deposit.AccountId);
                p.Add("@Amount", deposit.Amount);

                connection.Execute("dbo.Deposit_Money", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void WithdrawMoney(Withdraw withdraw)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BankDB")))
            {
                var p = new DynamicParameters();
                p.Add("@AccountId", withdraw.AccountId);
                p.Add("@Amount", withdraw.Amount);

                connection.Execute("dbo.Withdraw_Money", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void TransferMoney(int accountThatReceivesMoneyId, int accountThatSendsMoneyId, decimal amount)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BankDB")))
            {
                var p = new DynamicParameters();
                p.Add("@AccountThatReceivesMoneyId", accountThatReceivesMoneyId);
                p.Add("@AccountThatSendsMoney", accountThatSendsMoneyId);
                p.Add("@Amount", amount);

                connection.Execute("dbo.Transfer_Money", p, commandType: CommandType.StoredProcedure);

            }
        }

        public List<Deposit> GetAllDeposits(Account account)
        {
            List<Deposit> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BankDB")))
            {
                output = connection.Query<Deposit>($"dbo.GetAllDeposits {account.Id}").ToList();
                return output;
            }
        }

        public List<Withdraw> GetAllWithdraws(Account account) 
        {
            List<Withdraw> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BankDB")))
            {
                output = connection.Query<Withdraw>($"dbo.GetAllWithdraws {account.Id}").ToList();
                return output;
            }
        }

        public void ChangePassword(string newPassword,Account account) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BankDB")))
            {
                var p = new DynamicParameters();
                p.Add("@NewPassword", newPassword);
                p.Add("@Id", account.Id);

                connection.Execute("dbo.ChangePassword", p, commandType: CommandType.StoredProcedure);
            }
        }

        public Account VerifyUsername(string username)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BankDB")))
            {
                Account account = connection.Query<Account>($"dbo.VerifyNameForTransfer {username}").FirstOrDefault();
                return account;
            }
        }
    }
}
