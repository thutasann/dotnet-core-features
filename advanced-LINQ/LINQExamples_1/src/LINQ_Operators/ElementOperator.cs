using TCPData;

namespace LINQExamples_1.src.LINQ_Operators
{
    public static class ElementOperator
    {
        public static void ElementAtSample()
        {
            Console.WriteLine("\nElemnetAt Sample : ");
            List<Employee> employees = Data.GetEmployees();
            var emp = employees.ElementAtOrDefault(2);
            if (emp != null)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
        }
    }
}