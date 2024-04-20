namespace ef_core_relationships.Dto
{
    /// <summary>
    /// Character Create DTO
    /// </summary>
    public class CharacterCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string RpgClass { get; set; } = "Knight";
        public int UserId { get; set; } = 1;
    }
}