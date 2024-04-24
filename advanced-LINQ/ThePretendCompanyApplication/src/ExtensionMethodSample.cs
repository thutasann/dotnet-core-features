using TCPData;
using TCPExtensions;

namespace ThePretendCompanyApplication.src
{
    public static class ExtensionMethodSample
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nExtension Method Sample One : ");

            // filter extension method usage
            List<Employee> employees = Data.GetEmployees();
            var filteredEmployees = employees.Filter(e => e.IsManager == true);
            foreach (var filtered in filteredEmployees)
            {
                Console.WriteLine("filtered => " + filtered.FirstName);
            }
        }

        public static void LINQQuerySample()
        {
            Console.WriteLine("\nLINQ Query Sample One : ");

            List<Employee> employeesList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();

            var resultList = from emp in employeesList
                             join dep in departmentList
                             on emp.DepartmentId equals dep.Id
                             select new
                             {
                                 FirstName = emp.FirstName,
                                 LastName = emp.LastName,
                                 AnnualSalry = emp.AnnualSalary,
                                 Department = dep.LongName
                             };

            var averageSalary = resultList.Average(r => r.AnnualSalry);
            Console.WriteLine("averageSalary => " + averageSalary);

            var averageAnnualSalary = resultList.Average(r => r.AnnualSalry);
            var lowestAnnualSalary = resultList.Min(r => r.AnnualSalry);
            var highestAnnualSalary = resultList.Max(r => r.AnnualSalry);

            foreach (var filtered in resultList)
            {
                Console.WriteLine("filtered => " + filtered.FirstName);
            }
        }
    }
}