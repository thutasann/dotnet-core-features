using TCPData;

namespace LINQExamples_1.src.LINQ_Operators
{
    public static class ParticipatingOperators
    {
        public static void SkipSample()
        {
            Console.WriteLine("\nSkip Sample ");
            List<Employee> employees = Data.GetEmployees();
            var results = employees.Skip(2);
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");
            }
        }

        public static void SkipWhileSample()
        {
            Console.WriteLine("\nSkipWhile Sample ");
            List<Employee> employees = Data.GetEmployees();
            var results = employees.SkipWhile(e => e.AnnualSalary > 5000);
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");
            }
        }

        public static void TakeSample()
        {
            Console.WriteLine("\nTake Sample ");
            List<Employee> employees = Data.GetEmployees();
            var results = employees.Take(2);
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");
            }
        }

        public static void TakeWhileSample()
        {
            Console.WriteLine("\nTakeWhile Sample ");
            List<Employee> employees = Data.GetEmployees();
            var results = employees.TakeWhile(e => e.AnnualSalary > 5000);
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");
            }
        }

    }
}