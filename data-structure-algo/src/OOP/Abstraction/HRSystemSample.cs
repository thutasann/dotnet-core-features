namespace data_structure_algo.src.OOP.Abstraction
{
    /// <summary>
    /// OOP's Abstraction HR System Sample
    /// - Concrete employee types like FullTimeEmployee, PartTimeEmployee, and ContractEmployee extend EmployeeBase and provide their specific implementations for calculating salary.
    /// - Each concrete employee type has its own unique properties (e.g., MonthlySalary for full-time employees, HourlyRate and HoursWorked for part-time employees, and ContractAmount for contract employees) and behavior (e.g., salary calculation logic).
    /// - This abstraction allows you to work with different types of employees through a unified interface (IEmployee), while each concrete employee type encapsulates its specific details. It promotes code reusability, flexibility, and maintainability in your HR system.
    /// </summary>
    public class HRSystemSample
    {
    }

    public interface IEmployee
    {
        string EmployeeId { get; }
        string FullName { get; }
        decimal CalculateSalary();
    }

    /// <summary>
    /// Employee Base Class
    /// </summary>
    public abstract class BaseEmployee : IEmployee
    {
        public string EmployeeId { get; set; }
        public string FullName { get; set; }

        public BaseEmployee(string EmployeeId, string FullName)
        {
            this.EmployeeId = EmployeeId;
            this.FullName = FullName;
        }

        public abstract decimal CalculateSalary();
    }

    /// <summary>
    /// Full Time Employee
    /// </summary>
    public class FullTimeEmployee : BaseEmployee
    {
        public decimal MonthlySalary { get; set; }

        public FullTimeEmployee(string EmployeeId, string FullName, decimal MonthlySalary) : base(EmployeeId, FullName)
        {
            this.MonthlySalary = MonthlySalary;
        }

        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    /// <summary>
    /// Base Employee
    /// </summary>
    public class PartTimeEmployee : BaseEmployee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(string EmployeeId, string FullName, decimal HourlyRate, int HoursWorked) : base(EmployeeId, FullName)
        {
            this.HourlyRate = HourlyRate;
            this.HoursWorked = HoursWorked;
        }

        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }

    /// <summary>
    /// Contract Employee
    /// </summary>
    public class ContractEmployee : BaseEmployee
    {
        public decimal ContractAmount { get; set; }

        public ContractEmployee(string EmployeeId, string FullName, decimal ContractAmount) : base(EmployeeId, FullName)
        {
            this.ContractAmount = ContractAmount;
        }

        public override decimal CalculateSalary()
        {
            return ContractAmount;
        }
    }
}