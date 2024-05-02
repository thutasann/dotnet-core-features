using TCPData;

namespace LINQExamples_1.src
{
    public static class EnumerableCollectionExtensionMethods
    {
        /// <summary>
        /// Enumberable Collection Extension Method
        /// </summary>
        /// <param name="employees"></param>
        /// <returns></returns>
        public static IEnumerable<Employee> GetHighSalariedEmployees(this IEnumerable<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Accessing employee : {employee.FirstName + " " + employee.LastName}");

                if (employee.AnnualSalary >= 50000)
                    yield return employee;
            }
        }
    }
}