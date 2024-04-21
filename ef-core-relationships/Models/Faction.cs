using System.Text.Json.Serialization;

namespace ef_core_relationships.Models
{
    public class Faction
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [JsonIgnore]
        public List<Character>? Characters { get; set; }
    }
}