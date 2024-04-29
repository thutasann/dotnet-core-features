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

    }
}