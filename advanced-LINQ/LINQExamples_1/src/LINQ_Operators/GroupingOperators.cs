using TCPData;

namespace LINQExamples_1.src.LINQ_Operators
{
    public static class GroupingOperators
    {
        public static void GroupByQuerySyntax()
        {
            Console.WriteLine("\nGroupBy (Query Syntax) : ");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            var groupResult = from emp in employees
                              orderby emp.DepartmentId descending
                              group emp by emp.DepartmentId;

            foreach (var result in groupResult)
            {
                Console.WriteLine($"Department Id : {result.Key}");
                foreach (Employee emp in result)
                {
                    Console.WriteLine($"\tEmployee Full Name : {emp.FirstName} {emp.LastName}");
                }
            }
        }

        public static void ToLookUpOperator()
        {
            Console.WriteLine("\nToLookUp Operator : ");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            var groupResult = employees.OrderBy(o => o.DepartmentId).ToLookup(emp => emp.DepartmentId);
            foreach (var result in groupResult)
            {
                Console.WriteLine($"Department Id : {result.Key}");
                foreach (Employee emp in result)
                {
                    Console.WriteLine($"\tEmployee Full Name : {emp.FirstName} {emp.LastName}");
                }
            }
        }
    }
}