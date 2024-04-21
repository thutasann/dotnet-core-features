namespace ef_core_relationships.Models
{
    /// <summary>
    /// Weapon Model
    /// </summary>
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; } = 10;
        public Character Character { get; set; } = new Character();
        public int CharacterId { get; set; }
    }
}