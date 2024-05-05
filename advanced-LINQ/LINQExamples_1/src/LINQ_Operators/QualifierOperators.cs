using System.Diagnostics.CodeAnalysis;
using TCPData;

namespace LINQExamples_1.src.LINQ_Operators
{
    public static class QualifierOperators
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

        public static void ContainsOperator()
        {
            Console.WriteLine("\nContains Qualifier Sample : ");
            List<Employee> employees = Data.GetEmployees();
            var searchEmployee = new Employee
            {
                Id = 3,
                FirstName = "Douglas",
                LastName = "Roberts",
                AnnualSalary = 40000.2m,
                IsManager = false,
                DepartmentId = 2
            };

            bool containsEmployee = employees.Contains(searchEmployee, new EmployeeComparer());
            if (containsEmployee)
            {
                Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was found");
            }
            else
            {
                Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was NOT found");
            }
        }
    }

    /// <summary>
    /// Equality Comparer
    /// </summary>
    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            if (x != null && y != null)
            {
                if (x.Id == y.Id && x.FirstName.ToLower() == y.FirstName.ToLower() && x.LastName.ToLower() == y.LastName.ToLower())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}