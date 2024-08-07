using TCPData;

namespace LINQExamples_1.src.LINQ_Operators
{
    public static class ConversionOperator
    {
        public static void ToListSample()
        {
            Console.WriteLine("\nToList Sample :");
            List<Employee> employees = Data.GetEmployees();
            List<Employee> results = (from emp in employees
                                      where emp.AnnualSalary > 500
                                      select emp
                                    ).ToList();
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");
            }
        }

        public static void ToDictionarySample()
        {
            Console.WriteLine("\nToDictionary Sample : ");
            List<Employee> employees = Data.GetEmployees();
            Dictionary<int, Employee> dictionary = (from emp in employees
                                                    where emp.AnnualSalary > 50000
                                                    select emp).ToDictionary<Employee, int>(e => e.Id);
            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"Key : {key}, Value : {dictionary[key].FirstName} {dictionary[key].LastName} ");
            }
        }

        public static void ToArraySample()
        {
            Console.WriteLine("\nToArray Sample : ");
            List<Employee> employees = Data.GetEmployees();
            Employee[] results = (from emp in employees
                                  where emp.AnnualSalary > 5000
                                  select emp).ToArray();
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");
            }
        }

    }

    public static class LetIntoClauses
    {
        public static void LetClauseSample()
        {
            Console.WriteLine("\nLet Clause Sample : ");
            List<Employee> employees = Data.GetEmployees();
            var results = from emp in employees
                          let Initials = emp.FirstName[..1].ToUpper() + emp.LastName[..1].ToUpper()
                          let AnnualSalaryPlusBonus = emp.IsManager ? emp.AnnualSalary + (emp.AnnualSalary * 0.04m) : (emp.AnnualSalary * 0.02m)
                          where Initials == "JS" || Initials == "SJ" && AnnualSalaryPlusBonus > 5000
                          select new
                          {
                              Initials,
                              FullName = emp.FirstName + " " + emp.LastName,
                              AnnualSalaryPlusBonus
                          };

            foreach (var item in results)
            {
                Console.WriteLine($"{item.Initials,-5} {item.FullName,-10} {item.AnnualSalaryPlusBonus,-10}");
            }
        }

        public static void IntoSample()
        {
            Console.WriteLine("\nInto Sample : ");
            List<Employee> employees = Data.GetEmployees();
            var results = from emp in employees
                          where emp.AnnualSalary > 50000
                          select emp
                          into HighEarners
                          where HighEarners.IsManager == true
                          select HighEarners;

            foreach (var item in results)
            {
                Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");
            }
        }
    }
}