using System.Security.Cryptography.X509Certificates;
using TCPData;

namespace LINQExamples_1.src.LINQ_Operators
{
    public static class AggregateOperator
    {
        public static void AggregateSample()
        {
            Console.WriteLine("\nAggregate Sample : ");
            List<Employee> employees = Data.GetEmployees();
            decimal totalAnnualSalary = employees.Aggregate<Employee, decimal>(0, (totalAnnualSalary, e) =>
            {
                var bonus = e.IsManager ? 0.04m : 0.02m;
                totalAnnualSalary = e.AnnualSalary + (e.AnnualSalary * bonus) + totalAnnualSalary;
                return totalAnnualSalary;
            });

            Console.WriteLine($"Total Annual Salary of all employees (include bonus) : {totalAnnualSalary}");

            string data = employees.Aggregate<Employee, string, string>("Employee Annual salaries (including bonus) : ", (s, e) =>
            {
                var bonus = e.IsManager ? 0.04m : 0.02m;
                s += $"{e.FirstName} {e.LastName} - {e.AnnualSalary + (e.AnnualSalary * bonus)}";
                return s;
            }, s => s.Substring(0, s.Length - 2));

            Console.WriteLine($"Data : {data}");
        }

        public static void AverageSample()
        {
            Console.WriteLine("\nAverage Operator Sample : ");
            List<Employee> employees = Data.GetEmployees();
            decimal average = employees.Average(e => e.AnnualSalary);
            Console.WriteLine($"Average Annual Salary : {average}");
        }

        public static void CountSample()
        {
            Console.WriteLine("\nCount Operator Sample : ");
            List<Employee> employees = Data.GetEmployees();
            int countEmployees = employees.Count();
            Console.WriteLine($"Number of Employees : {countEmployees}");
        }

        public static void SumSample()
        {
            Console.WriteLine("\nSum Operator Sample : ");
            List<Employee> employees = Data.GetEmployees();
            decimal result = employees.Sum(e => e.AnnualSalary);
            Console.WriteLine($"Sum Result : {result}");
        }

        public static void MaxSample()
        {
            Console.WriteLine("\nMax Operator Sample : ");
            List<Employee> employees = Data.GetEmployees();
            decimal result = employees.Max(e => e.AnnualSalary);
            Console.WriteLine($"Highest Salary Result : {result}");
        }
    }
}