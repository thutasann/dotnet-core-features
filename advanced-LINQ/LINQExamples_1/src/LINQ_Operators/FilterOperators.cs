using System.Collections;
using TCPData;

namespace LINQExamples_1.src.LINQ_Operators
{
    public static class FilterOperators
    {
        public static void FilterOperatorQuerySyntax()
        {
            Console.WriteLine("\nFilter Operator (Query Syntax) From Mixed Collection : ");
            ArrayList mixedCollection = Data.GetHeterogeneousDataCollection();
            var employeeResult = from s in mixedCollection.OfType<Employee>()
                                 select s;

            foreach (Employee employee in employeeResult)
            {
                Console.WriteLine($"Employee Result : {employee.FirstName} {employee.LastName}");
            }
        }
    }
}