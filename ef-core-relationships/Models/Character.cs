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
        public string RpgClass { get; set; } = "Knight";
        public User User { get; set; } = new User();
        public int UserId { get; set; }
    }
}