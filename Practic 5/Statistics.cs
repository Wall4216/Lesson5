using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_5
{
    public class Statistics
    {
        private int transactionCount = 0;

        public void UpdateStatistics(string message)
        {
            transactionCount++;
            Logger.Log($"Updated statistics: {transactionCount} transactions so far.");
        }

        public int GetTransactionCount()
        {
            return transactionCount;
        }
    }
}
