namespace pure_DSA.src.KeyValuePair
{

    class User
    {
        public string Name { get; set; } = string.Empty;
        public string NiceName { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
    }

    public static class UsersFilterSample
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nUsers Filter Dictionary Sample => ");
            Dictionary<string, User> users = new();

            for (int i = 0; i < 60; i++)
            {
                string key = $"User{i}";
                users.Add(key, new User
                {
                    Name = $"Name{i}",
                    NiceName = $"NiceName{i}",
                    DisplayName = $"DisplayName{i}"
                });
            }

            string searchTerm = "Name1";
            var filteredUsers = users.Where(pair => pair.Value.Name.Contains(searchTerm)).ToDictionary(pair => pair.Key, pair => pair.Value);

            // Display filtered users
            foreach (var user in filteredUsers)
            {
                Console.WriteLine($"Key: {user.Key}, Name: {user.Value.Name}, NiceName: {user.Value.NiceName}, DisplayName: {user.Value.DisplayName}");
            }

        }
    }
}