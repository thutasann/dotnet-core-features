using TCPData;

namespace LINQExamples_1.src.LINQ_Operators
{
    public static class GenerationOperator
    {
        public static void DefaultIfEmpty()
        {
            Console.WriteLine("\nGeneration Operator (DefaultIfEmpty)");
            List<int> intList = new();
            var newList = intList.DefaultIfEmpty(99999);
            Console.WriteLine("int ElementAt(0) " + newList.ElementAt(0));

            List<Employee> employees = new();
            var newEmployees = employees.DefaultIfEmpty(new Employee { Id = 0 });
            var empResult = newEmployees.ElementAt(0);
            if (empResult.Id == 0)
            {
                Console.WriteLine($"The list is empty");
            }
        }

        public static void EmptySample()
        {
            Console.WriteLine("\nEmpty Operator Sample : ");
            List<Employee> emptyEmployeeList = Enumerable.Empty<Employee>().ToList();
            emptyEmployeeList.Add(new Employee { Id = 7, FirstName = "Dan", LastName = "Brown" });

            foreach (var item in emptyEmployeeList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }
    }
}