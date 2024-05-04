using TCPData;

namespace LINQExamples_1.src.LINQ_Operators
{
    public static class SortingOperators
    {
        public static void OrderByMethodSyntax()
        {
            Console.WriteLine("\nSorting Operators OrderBy (Method Syntax) : ");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();

            var results = employees.Join(departments, e => e.DepartmentId, d => d.Id,
                (emp, dep) => new
                {
                    emp.Id,
                    emp.FirstName,
                    emp.LastName,
                    emp.AnnualSalary,
                    emp.DepartmentId,
                    DepartmentName = dep.LongName
                }
            ).OrderBy(o => o.DepartmentId).ThenBy(o => o.AnnualSalary);

            foreach (var item in results)
            {
                Console.WriteLine($"Id: {item.Id,-5} First Name : {item.FirstName,-10}, Last Name : {item.LastName,-10} AnnualSalary : {item.AnnualSalary,10}\tDepartment Name : {item.DepartmentName}");
            }
        }

        public static void OrderByQuerySyntax()
        {
            Console.WriteLine("\nSorting Operators OrderBy (Query Syntax) : ");
            List<Employee> employees = Data.GetEmployees();
            List<Department> departments = Data.GetDepartments();
            var results = from emp in employees
                          join dept in departments
                          on emp.DepartmentId equals dept.Id
                          orderby emp.DepartmentId, emp.AnnualSalary descending
                          select new
                          {
                              emp.Id,
                              emp.FirstName,
                              emp.LastName,
                              emp.AnnualSalary,
                              emp.DepartmentId,
                              DepartmentName = dept.LongName
                          };

            foreach (var item in results)
            {
                Console.WriteLine($"Id: {item.Id,-5} First Name : {item.FirstName,-10}, Last Name : {item.LastName,-10} AnnualSalary : {item.AnnualSalary,10}\tDepartment Name : {item.DepartmentName}");
            }
        }

    }
}