using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_5
{
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        private decimal balance;

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            balance = initialBalance;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public bool Transfer(BankAccount toAccount, decimal amount)
        {
            if (Withdraw(amount))
            {
                toAccount.Deposit(amount);
                return true;
            }
            return false;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }

}
