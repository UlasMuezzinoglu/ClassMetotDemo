using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Customer
    {
        private static int balance;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public short BirthYear { get; set; }
        public int Balance { get { return balance; } set { balance = value; } }
        public int AccountNumber { get; set; } //Like IBAN

    }
}
