namespace data_structure_algo.src.OOP.Encapsulation
{
    public class EnAccount
    {
        private int accountId;
        private decimal balance;
        public List<EnTransaction> transactions;

        public EnAccount(int accountId)
        {
            this.accountId = accountId;
            this.balance = 0;
            this.transactions = new List<EnTransaction>();
        }

        public int AccountId
        {
            get { return accountId; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Invalid amount.");
            }
            balance += amount;
            transactions.Add(new EnTransaction(TransactionType.Deposit, amount));
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > balance)
            {
                throw new ArgumentException("Invalid amount or insufficient balance.");
            }

            balance -= amount;
            transactions.Add(new EnTransaction(TransactionType.Withdrawal, amount));
        }
    }

    public class EnTransaction
    {
        public TransactionType? Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }

        public EnTransaction(TransactionType type, decimal amount)
        {
            Type = type;
            Amount = amount;
            Timestamp = DateTime.Now;
        }
    }

    public enum TransactionType
    {
        Deposit,
        Withdrawal
    }

    public class EnBankUsage
    {
        public void SampleOne()
        {
            EnAccount enAccount = new(12345);

            enAccount.Deposit(5000);
            enAccount.Withdraw(300);

            Console.WriteLine($"Account ID: {enAccount.AccountId}");
            Console.WriteLine($"Current Balance: {enAccount.Balance}");

            foreach (EnTransaction item in enAccount.transactions)
            {
                Console.WriteLine($"{item.Timestamp}: {item.Type} - Amount: {item.Amount}");

            }

        }
    }
}