namespace SheetsWithoutNumber.Services.RangedWeapon
{
    public class CharacterRangedWeaponServiceModel
    {
        public int Id { get; init; }

        public int CharacterId { get; set; }

        public int RangedWeaponId { get; set; }

        public int RangedWeaponAmmo { get; set; }

        public string RangedWeaponName { get; init; }

        public string RangedWeaponLocation { get; set; }
    }
}
