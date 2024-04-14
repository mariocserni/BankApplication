using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; } 
        public int Age { get; set; }
        public decimal Money { get; set; }

        public Account(string username, string firstName, string lastName, string password, string email, string age)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Email = email;
            this.Age = int.Parse(age);
        }

        public Account()
        {
            
        }
    }
}
