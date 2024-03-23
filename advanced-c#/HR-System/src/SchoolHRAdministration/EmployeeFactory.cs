using advanced_c_.src.SchoolHRAdministration.Interfaces;
using advanced_c_.src.SchoolHRAdministration.utils;

namespace advanced_c_.src.SchoolHRAdministration
{
    /// <summary>
    /// Employee Factory
    /// </summary>
    public static class EmployeeFactory
    {
        public static IEmployee GetEmployeeInstance(EmployeeType employeeType, int id, string FirstName, string LastName, decimal Salary)
        {
            IEmployee? employee = null;

            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = FactoryPattern<IEmployee, Teacher>.GetInstance();
                    break;
                case EmployeeType.HeadOfDepartment:
                    employee = FactoryPattern<IEmployee, HeadOfDepartment>.GetInstance();
                    break;
                case EmployeeType.HeadMaster:
                    employee = FactoryPattern<IEmployee, HeadMaster>.GetInstance();
                    break;
            }

            if (employee != null)
            {
                employee.Id = id;
                employee.FirstName = FirstName;
                employee.LastName = LastName;
                employee.Salary = Salary;
            }
            else
            {
                throw new NullReferenceException();
            }

            return employee;
        }
    }
}