using System.ComponentModel.DataAnnotations;

namespace ef_core_relationships.Models
{
    /// <summary>
    /// Character Model
    /// </summary>
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // one-one
        public Backpack? Backpack { get; set; }

        // one-many
        public List<Weapon>? Weapons { get; set; }

        // many-many
        public List<Faction>? Factions { get; set; }
    }
}