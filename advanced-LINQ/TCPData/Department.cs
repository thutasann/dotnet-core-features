namespace TCPData
{
    public class Department
    {
        public int Id { get; set; }
        public string ShortName { get; set; } = string.Empty;
        public string LongName { get; set; } = string.Empty;
        public IEnumerable<Employee> Employees { get; set; } = Enumerable.Empty<Employee>();
    }
}