using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ef_core_relationships.Models
{
    /// <summary>
    /// User Model
    /// </summary>
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public ICollection<Character> Characters { get; set; } = new List<Character>();
    }
}