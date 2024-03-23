namespace advanced_c_.src.Abstraction
{
    public interface IEmployee
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
    }

    public enum EmployeeType
    {
        Teacher,
        HeadOfDepartment,
        HeadMaster
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

    /// <summary>
    /// Factoray pattern
    /// </summary>
    public static class EmployeeFactory
    {
        public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string FirstName, string LastName, decimal Salary)
        {
            IEmployee? employee = null;

            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = new Teacher { Id = id, FirstName = FirstName, LastName = LastName, Salary = Salary };
                    break;
                case EmployeeType.HeadOfDepartment:
                    employee = new HeadOfDepartment { Id = id, FirstName = FirstName, LastName = LastName, Salary = Salary };
                    break;
                case EmployeeType.HeadMaster:
                    employee = new HeadMaster { Id = id, FirstName = FirstName, LastName = LastName, Salary = Salary };
                    break;
            }

            return employee!;
        }
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

            IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Teacher", "One", 4000);
            employees.Add(teacher1);

            IEmployee teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Teacher", "Two", 5000);
            employees.Add(teacher2);

            IEmployee headOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Head Department", "one", 10000);
            employees.Add(headOfDepartment);

            IEmployee headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 4, "Head Master", "One", 20000);
            employees.Add(headMaster);

        }
    }
}