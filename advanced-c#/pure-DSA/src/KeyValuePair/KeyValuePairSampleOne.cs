namespace pure_DSA.src.KeyValuePair
{
    public static class KeyValuePairSampleOne
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nKeyValuePair Sample One ===>");
            var person = new KeyValuePair<string, int>("Alice", 30);
            Console.WriteLine($"Name : {person.Key}, Age: {person.Value}");

            var people = new Dictionary<string, int>
            {
                { "Alice", 30},
                { "Bob", 40 },
                { "Charlie", 25 }
            };

            foreach (var kvp in people)
            {
                Console.WriteLine($"Name : {kvp.Key}, Age : {kvp.Value}");
            }
        }
    }

    public static class NestedKeyValuePairSampleOne
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nNested KeyValuePair Sample One ===>");
            var nestedKeyValuePair = new KeyValuePair<string, KeyValuePair<string, int>>(
                "outerKey",
                new("InnerKey", 10)
            );

            Console.WriteLine($"Outer Key : {nestedKeyValuePair.Key}");
            Console.WriteLine($"Inner Key {nestedKeyValuePair.Value.Key}");
            Console.WriteLine($"Inner Value {nestedKeyValuePair.Value.Value}");
        }
    }

    public static class NestedKeyValuePairSampleTwo
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nNested KeyValuePair Sample Two ===>");

            // List of Employees and their Salaries
            var employees = new List<KeyValuePair<string, decimal>> {
                new("Alice", 5000),
                new("Bob", 6000),
                new("Charlie", 5500),
                new("David", 64000),
                new("Eva", 5300)
            };

            // iterate total Salary
            decimal totalSalary = 0;
            foreach (var employee in employees)
            {
                totalSalary += employee.Value;
            }
            Console.WriteLine($"\nTotal salary of all employees: ${totalSalary}");

            // add new employee
            employees.Add(new("Frank", 7000));
            Console.WriteLine("Employees and Their salaries...");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee : {employee.Key} : {employee.Value}");
            }

            // remove employee by key
            string nameToDelete = "Frank";
            DeleteEmployeeByKey(employees, nameToDelete);
            Console.WriteLine("\nUpdated employees and their salaries...");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee: {employee.Key}: ${employee.Value}");
            }

            // update employee by key
            string nameToUpdate = "Alice";
            decimal newSalary = 7000;
            UpdateEmployeeByKey(employees, nameToUpdate, newSalary);
            Console.WriteLine("\nUpdated employees and their salaries:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee: {employee.Key}: ${employee.Value}");
            }
        }

        private static void DeleteEmployeeByKey(List<KeyValuePair<string, decimal>> employees, string name)
        {
            int index = employees.FindIndex(emp => emp.Key == name);

            if (index != -1)
            {
                employees.RemoveAt(index);
                Console.WriteLine($"Employee {name} has been deleted");
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
        }

        private static void UpdateEmployeeByKey(List<KeyValuePair<string, decimal>> employees, string name, decimal newSalary)
        {
            int index = employees.FindIndex(emp => emp.Key == name);
            if (index != -1)
            {
                employees[index] = new(name, newSalary);
            }
            else
            {
                Console.WriteLine("Employee not found");
            }
        }
    }
}