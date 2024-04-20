namespace ef_core_relationships.Models
{
    /// <summary>
    /// User Model
    /// </summary>
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public List<Character> Characters { get; set; } = new List<Character>();
    }
}