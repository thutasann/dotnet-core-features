namespace ef_core_relationships.Models
{
    /// <summary>
    /// Backpack Model
    /// </summary>
    public class Backpack
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public int CharacterId { get; set; }
        public Character? Character { get; set; }
    }
}