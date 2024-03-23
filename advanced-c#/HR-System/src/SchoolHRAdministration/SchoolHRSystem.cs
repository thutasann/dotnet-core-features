using advanced_c_.src.SchoolHRAdministration.Interfaces;

namespace advanced_c_.src.SchoolHRAdministration
{
    public class EmployeeBase : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
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
    public class SchoolHRSystem
    {
        public static void SampleOne()
        {
            Console.WriteLine("------>> School HR System ");
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