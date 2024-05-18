using TCPData;

namespace LINQExamples_1.src.LINQ_Operators
{
    public static class ProjectionOperator
    {
        public static void SelectSample()
        {
            Console.WriteLine("\nSelect Sample : ");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments(employees);
            var results = departments.Select(d => d.Employees);
            foreach (var items in results)
            {
                foreach (var item in items)
                {
                    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");
                }
            }
        }

        public static void SelectManySample()
        {
            Console.WriteLine("\nSelectMany Sample : ");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments(employees);
            var results = departments.SelectMany(d => d.Employees).OrderBy(o => o.Id);
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");
            }
        }
    }
}