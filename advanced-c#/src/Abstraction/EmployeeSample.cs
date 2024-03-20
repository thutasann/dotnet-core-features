using System.Runtime.CompilerServices;

namespace advanced_c_.src.Abstraction
{
    public interface IEmployee
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
    }

    /// <summary>
    /// Employee Base
    /// </summary>
    public class EmployeeBase : IEmployee
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public virtual decimal Salary { get; set; }
    }

    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
    }

    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }

    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.1m); }
    }

    // ------------------------- USAGE -------------------------
    public class AbstractEmployeeUsage
    {
        public static void SampleOne()
        {
            Console.WriteLine("------>>  Abstract Employee Sample ");
            decimal totalSalaries = 0;
            List<IEmployee> employees = new();

            SeedData(employees);

            foreach (IEmployee employee in employees)
            {
                totalSalaries += employee.Salary;
            }

            Console.WriteLine($"Total Annual Salaries: {totalSalaries}");
        }

        public static void SeedData(List<IEmployee> employees)
        {

            IEmployee teacher1 = new Teacher
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Fisher",
                Salary = 4000
            };

            employees.Add(teacher1);

            IEmployee teacher2 = new Teacher
            {
                Id = 2,
                FirstName = "Jenny",
                LastName = "Thomas",
                Salary = 4000
            };

            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment
            {
                Id = 3,
                FirstName = "Breddy",
                LastName = "Thomas",
                Salary = 9000
            };

            employees.Add(headOfDepartment);


            IEmployee headMaster = new HeadMaster
            {
                Id = 4,
                FirstName = "Head",
                LastName = "Master",
                Salary = 90000
            };


        }
    }
}