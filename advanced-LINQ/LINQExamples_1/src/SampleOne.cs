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
            Console.WriteLine("\n(Query Syntax) : ");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            var results = from emp in employees
                          where emp.AnnualSalary >= 5000
                          select new
                          {
                              FullName = emp.FirstName + " " + emp.LastName,
                              emp.AnnualSalary
                          };

            foreach (var result in results)
            {
                Console.WriteLine($"{result.FullName,-20} {result.AnnualSalary}");
            }
        }

    }
}