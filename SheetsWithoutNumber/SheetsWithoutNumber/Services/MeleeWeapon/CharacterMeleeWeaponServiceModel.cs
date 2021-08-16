namespace SheetsWithoutNumber.Services.MeleeWeapon
{
    public class CharacterMeleeWeaponServiceModel
    {
        public int Id { get; init; }

        public int CharacterId { get; set; }

        public int MeleeWeaponId { get; set; }

        public string MeleeWeaponName { get; init; }

        public string MeleeWeaponLocation { get; set; }
    }
}
