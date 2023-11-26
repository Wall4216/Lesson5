using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_5
{
    public class TransactionManager
    {
        public delegate void TransactionHandler(string message);
        public event TransactionHandler OnTransaction;

        public void ExecuteTransaction(BankAccount account, Action transaction)
        {
            transaction.Invoke();
            OnTransaction?.Invoke($"Transaction executed for account {account.AccountNumber}");
        }
    }
}
