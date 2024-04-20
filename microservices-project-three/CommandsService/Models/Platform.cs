using System.ComponentModel.DataAnnotations;

namespace CommandsService.Models
{
    /// <summary>
    /// Platform Model
    /// </summary>
    public class Platform
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int ExternalId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Command> Commands { get; set; } = new List<Command>();
    }
}