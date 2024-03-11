namespace data_structure_algo.src.OOP.Abstraction
{
    /// <summary>
    /// # Banking Sample
    /// -  In this application, you have different types of accounts such as Savings Account, Checking Account, and Loan Account.
    /// -  Each account type has common functionalities like deposit, withdrawal, and account information retrieval
    /// -  but they may have different rules and calculations for interest rates, fees, and overdraft limits.
    /// - To abstract away these differences and provide a unified interface for working with different types of accounts, you can use abstraction in the form of interfaces and abstract classes.
    /// </summary>
    public class BankingSample
    {
    }

    /// <summary>
    /// Interface for Bank accounts
    /// </summary>
    public interface IAccount
    {
        string AccountNumber { get; }
        decimal Balance { get; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }

    /// <summary>
    /// Abstract class for common account functionality
    /// </summary>
    public abstract class AccountBase : IAccount
    {
        public string AccountNumber { get; }
        public decimal Balance { get; protected set; }

        public AccountBase(string accountNumber, decimal Balance)
        {
            AccountNumber = accountNumber;
            this.Balance = Balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public abstract void Withdraw(decimal amount);

    }


    public class SavingAcount : AccountBase
    {
        public SavingAcount(string accountNumber, decimal Balance) : base(accountNumber, Balance)
        {
        }

        public override void Withdraw(decimal amount)
        {
            // Implement withdrawal logic for savings account
        }
    }

    public class CheckAccount : AccountBase
    {
        public CheckAccount(string accountNumber, decimal Balance) : base(accountNumber, Balance)
        {
        }

        public override void Withdraw(decimal amount)
        {
            // Implement withdrawal logic for checking account
        }
    }
}