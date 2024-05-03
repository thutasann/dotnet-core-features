using TCPData;

namespace LINQExamples_1.src
{
    public static class JoinOperator
    {
        public static void MethodSyntax()
        {
            Console.WriteLine("\nJoin Operator (Method Syntax) : ");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            var results = departments.Join(employees,
                department => department.Id,
                employee => employee.DepartmentId,
                (department, employee) => new
                {
                    FullName = employee.FirstName + " " + employee.LastName,
                    employee.AnnualSalary,
                    departmentName = department.LongName
                }
            );

            foreach (var result in results)
            {
                Console.WriteLine($"{result.FullName,-20} {result.AnnualSalary}\t{result.departmentName}");
            }
        }

        public static void QuerySyntax()
        {
            Console.WriteLine("\nJoin Operator (Query Syntax )");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            var results = from dept in departments
                          join emp in employees
                          on dept.Id equals emp.DepartmentId
                          select new
                          {
                              FullName = emp.FirstName + " " + emp.LastName,
                              emp.AnnualSalary,
                              DepartmentName = dept.LongName
                          };

            foreach (var result in results)
            {
                Console.WriteLine($"{result.FullName,-20} {result.AnnualSalary}\t{result.DepartmentName}");
            }
        }
    }
}