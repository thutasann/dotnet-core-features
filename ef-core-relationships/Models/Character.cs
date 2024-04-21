using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        public string RpgClass { get; set; } = "Knight";

        // User relation (1:n)
        [JsonIgnore]
        public User User { get; set; } = new User();
        public int UserId { get; set; }

        // Weapon relation (1:1)
        public Weapon Weapon { get; set; } = new Weapon();
    }
}