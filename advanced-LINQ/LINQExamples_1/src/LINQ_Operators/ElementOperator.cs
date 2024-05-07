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
                Console.WriteLine($"{emp.Id,-5} {emp.FirstName,-10} {emp.LastName,-10}");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
        }

        public static void FirstOrDefaultSample()
        {
            Console.WriteLine("\nFirstOrDefault Sample : ");
            List<int> integerList = new() { 3, 14, 23, 17, 28, 89 };
            int result = integerList.FirstOrDefault(i => i % 2 == 0);
            if (result != 0)
            {
                Console.WriteLine($"Result => ${result}");
            }
            else
            {
                Console.WriteLine("There are no even numbers in the collection");
            }
        }

        public static void LastOrDefaultSample()
        {
            Console.WriteLine("\nLastOrDefault Sample : ");
            List<int> integerList = new() { 3, 14, 23, 17, 28, 89 };
            int result = integerList.LastOrDefault(i => i % 2 == 0);
            if (result != 0)
            {
                Console.WriteLine($"Result => {result}");
            }
            else
            {
                Console.WriteLine("There are no even numbers in the collection");
            }
        }

        public static void SingleOrDefaultSample()
        {
            Console.WriteLine("\nSingleOrDefault Sample : ");
            List<Employee> employees = Data.GetEmployees();
            var result = employees.SingleOrDefault(e => e.Id == 2);
            if (result is not null)
            {
                Console.WriteLine($"Result => {result.FirstName} {result.LastName}");
            }
            else
            {
                Console.WriteLine("Employee does not exist in the collection");
            }
        }
    }
}