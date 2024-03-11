namespace data_structure_algo.src.OOP.Polymorphism
{
    /// <summary>
    /// Account Base Class
    /// </summary>
    public abstract class PolyAccount
    {
        protected string accountNumber;
        protected decimal balance;

        public PolyAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public string AccountNumber { get { return accountNumber; } }
        public decimal Balance { get { return balance; } }

        public virtual void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New Balance : {balance:C}");
        }

        public abstract void WithDraw(decimal amount);
    }

    /// <summary>
    /// Checking Account class inheriting from PolyAccount
    /// </summary>
    public class CheckingAccount : PolyAccount
    {
        public CheckingAccount(string accountNumber) : base(accountNumber)
        {
        }

        public override void WithDraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"WithDrawn {amount:C}. New Balance {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
    }

    /// <summary>
    /// SavingsAccount class inherting from PolyAccount
    /// </summary>
    public class SavingsAccount : PolyAccount
    {
        public SavingsAccount(string accountNumber) : base(accountNumber)
        {
        }

        public override void WithDraw(decimal amount)
        {

            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }
    }
}