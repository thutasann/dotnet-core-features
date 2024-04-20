namespace ef_core_relationships.Models
{
    /// <summary>
    /// Character Model
    /// </summary>
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RpgClass { get; set; } = "Knight";
        public required User User { get; set; }
        public int UserId { get; set; }
    }
}