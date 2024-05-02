using TCPData;

namespace LINQExamples_1.src
{
    public static class SampleOne
    {
        public static void SelectAndWhere()
        {
            Console.WriteLine("\nSelect And Where Operator (Method Syntax) : ");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            var results = employees.Select(e => new
            {
                FullName = e.FirstName + " " + e.LastName,
                e.AnnualSalary
            }).Where(e => e.AnnualSalary >= 50000);

            foreach (var result in results)
            {
                Console.WriteLine($"{result.FullName,-20} {result.AnnualSalary}");
            }
        }

        public static void QuerySyntax()
        {
            Console.WriteLine("\nSelect And Where Operator (Query Syntax) : ");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            var results = from emp in employees
                          where emp.AnnualSalary >= 5000
                          select new
                          {
                              FullName = emp.FirstName + " " + emp.LastName,
                              emp.AnnualSalary
                          };

            employees.Add(new Employee
            {
                Id = 5,
                FirstName = "Sam",
                LastName = "Davis",
                AnnualSalary = 10000.20m,
                IsManager = true,
                DepartmentId = 2
            });

            foreach (var result in results)
            {
                Console.WriteLine($"{result.FullName,-20} {result.AnnualSalary}");
            }
        }

        /// <summary>
        /// Deferred Enumberable Extension Usage
        /// </summary>
        public static void DeferredEnumberableExtensionUsage()
        {
            Console.WriteLine("\nDeferred Execution : ");
            Console.WriteLine("Enumberable Collection Extension Method Usage : ");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            var results = from emp in employees.GetHighSalariedEmployees()
                          select new
                          {
                              FullName = emp.FirstName + " " + emp.LastName,
                              emp.AnnualSalary
                          };

            foreach (var result in results)
            {
                Console.WriteLine($"{result.FullName,-20} {result.AnnualSalary}");
            }

            employees.Add(new Employee
            {
                Id = 5,
                FirstName = "Sam",
                LastName = "Davis",
                AnnualSalary = 10000.20m,
                IsManager = true,
                DepartmentId = 2
            });
        }

        /// <summary>
        /// Deferred Enumberable Extension Usage
        /// </summary>
        public static void ImmediateEnumberableExtensionUsage()
        {
            Console.WriteLine("\nImmediate Execution : ");
            Console.WriteLine("Enumberable Collection Extension Method Usage : ");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            var results = (from emp in employees.GetHighSalariedEmployees()
                           select new
                           {
                               FullName = emp.FirstName + " " + emp.LastName,
                               emp.AnnualSalary
                           }).ToList();

            foreach (var result in results)
            {
                Console.WriteLine($"{result.FullName,-20} {result.AnnualSalary}");
            }

            employees.Add(new Employee
            {
                Id = 5,
                FirstName = "Sam",
                LastName = "Davis",
                AnnualSalary = 10000.20m,
                IsManager = true,
                DepartmentId = 2
            });
        }

    }
}