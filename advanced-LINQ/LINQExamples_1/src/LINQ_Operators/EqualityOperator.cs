using TCPData;
using System.Diagnostics.CodeAnalysis;

namespace LINQExamples_1.src.LINQ_Operators
{
    public static class EqualityOperator
    {
        public static void SequenceEqual()
        {
            Console.WriteLine("\nEquality Operator SequenceEqual : ");
            List<Employee> employees = Data.GetEmployees();

            List<int> integerList1 = new() { 1, 2, 3, 4, 5, 6 };
            List<int> integerList2 = new() { 1, 2, 3, 4, 5, 6 };

            bool boolSequenceEqual = integerList1.SequenceEqual(integerList2);
            Console.WriteLine($"Int Sequence Equal => {boolSequenceEqual}");

            var employeeListCompare = Data.GetEmployees();
            bool boolSE = employees.SequenceEqual(employeeListCompare, new EmployeeEqualityComparer());
            Console.WriteLine($"Employee Sequence Equal => {boolSE}");

        }
    }

    public class EmployeeEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            if (x != null && y != null)
            {
                if (x.Id == y.Id && x.FirstName.ToLower() == y.FirstName.ToLower() && x.LastName.ToLower() == y.LastName.ToLower())
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}