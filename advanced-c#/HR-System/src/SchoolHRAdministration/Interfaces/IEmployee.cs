namespace advanced_c_.src.SchoolHRAdministration.Interfaces
{
    public interface IEmployee
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
    }

}