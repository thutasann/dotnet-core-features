namespace ef_core_relationships.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CharacterId { get; set; }
        public Character? Character { get; set; }
    }
}