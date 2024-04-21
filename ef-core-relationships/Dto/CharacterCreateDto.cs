namespace ef_core_relationships.Dto
{
    /// <summary>
    /// Character Create Dto
    /// </summary>
    public record struct CharacterCreateDto(
        string Name,
        BackpackCreateDto Backpack,
        List<WeaponCreateDto> Weapons
    );
}