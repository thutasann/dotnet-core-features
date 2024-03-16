using Microsoft.VisualBasic;

namespace data_structure_algo.src.OOP.Abstraction
{
    /// <summary>
    /// Abstract class for Bank Entities
    /// </summary>
    public abstract class BankEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public enum AccountType
    {
        Checking,
        Savings
    }

    public class Customer : BankEntity
    {
        public string? Address { get; set; }
        public string? Email { get; set; }
        public List<Account>? Accounts { get; set; }
    }

    public class Transaction : BankEntity
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public Account? Account { get; set; }
        public string? Type { get; set; }
    }

    public class Account : BankEntity
    {
        public AccountType Type { get; set; }
        public decimal Balance { get; set; }
        public Customer? Owner { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void WithDraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Funds.");
            }
        }

        public void Transfer(Account recipient, decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                recipient.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }

    /// <summary>
    /// BankingSystem class representing the banking system
    /// </summary>
    public class BankingSystem
    {
        private readonly List<Customer> _customers;
        private readonly List<Account> _accounts;
        private readonly List<Transaction> _transactions;

        public BankingSystem()
        {
            _customers = new();
            _accounts = new();
            _transactions = new();
        }

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public void PerformTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }
    }

    public class BankingSystemUsage
    {
        public void SampleOne()
        {
            Customer customer1 = new() { Id = 1, Name = "John Doe", Address = "123 Main st", Email = "john@example.com" };
            Account account1 = new() { Id = 1, Type = AccountType.Checking, Balance = 1000, Owner = customer1 };

            BankingSystem bankingSystem = new();
            bankingSystem.AddCustomer(customer1);
            bankingSystem.AddAccount(account1);

            account1.Deposit(5000);
            account1.WithDraw(200);
            account1.Transfer(account1, 200);

            Console.WriteLine($"Account balance : {account1.Balance:C}");
        }
    }
}