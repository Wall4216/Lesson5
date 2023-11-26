using Practic_5;

class Program
{
    static void Main(string[] args)
    {
        var account = new BankAccount("12345", 1000);
        var transactionManager = new TransactionManager();
        var statistics = new Statistics();

        // Подписываемся на события
        transactionManager.OnTransaction += Logger.Log;
        transactionManager.OnTransaction += statistics.UpdateStatistics;

        // Пример операций
        transactionManager.ExecuteTransaction(account, () => account.Deposit(500));
        transactionManager.ExecuteTransaction(account, () => account.Withdraw(200));

        Console.WriteLine($"Total Transactions: {statistics.GetTransactionCount()}");
    }
}
