using TCPData;

namespace LINQExamples_1.src
{
    public static class JoinOperator
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nJoin Operator : ");
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
    }
}