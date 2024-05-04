using TCPData;

namespace LINQExamples_1.src.LINQ_Operators
{
    public static class QuantifierOperators
    {
        public static void AllAndAnyOperators()
        {
            Console.WriteLine("\nAll And Any Operator : ");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();
            decimal annualSalaryCompare = 2000;
            bool isTrueAll = employees.All(e => e.AnnualSalary > annualSalaryCompare);

            if (isTrueAll)
            {
                Console.WriteLine($"All employee annual salaries are above {annualSalaryCompare}");
            }
            else
            {
                Console.WriteLine($"Not all Employee annual salaries are above {annualSalaryCompare}");
            }

            bool isTrueAny = employees.Any(e => e.AnnualSalary > annualSalaryCompare);
            if (isTrueAny)
            {
                Console.WriteLine($"At least one employee employee annual salary are above {annualSalaryCompare}");
            }
            else

            {
                Console.WriteLine($"Not all Employee annual salaries are above {annualSalaryCompare}");
            }
        }
    }
}