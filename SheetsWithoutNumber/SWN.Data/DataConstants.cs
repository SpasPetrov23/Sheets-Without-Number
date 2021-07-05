namespace SWN.Data
{
    public class DataConstants
    {
        //Constants for the User Entity
        public const int UsernameMaxLength = 30;
        public const string UserEmailRegularExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        //Constants for the Game Entity
        public const int GameNameMaxLength = 50;
        public const int GameDescriptionMaxLength = 200;

        //Constants for the UserRole Entity
        public const int UserRoleNameMaxLength = 10;

        //Constants for the Focus Entity
        public const int FocusNameMaxLength = 25;

        //Constants for the Background Entity
        public const int BackgroundNameMaxLength = 25;

        //Constants for the Class Entity
        public const int ClassNameMaxLength = 25;

        //Constants for the Skill Entity
        public const int SkillNameMaxLength = 25;

        //Constants for Item Entities (Equipment, Armor, Melee & Ranged Weapons, Item Locations)
        public const int ItemNameMaxLength = 40;
        public const int ItemTypeMaxLength = 30;
        public const int ItemAttributeMaxLength = 10;
        public const int ItemMagazineMaxLength = 5;
        public const int ItemDamageMaxLength = 5;

        //Constants for the Contact Entity
        public const int ContactNameMaxLength = 50;

        //Constants for the CharacterSheet Entity
        public const int SheetCharacterNameMaxLength = 30;
        public const int SheetSpeciesMaxLength = 20;
        public const int SheetHomeworldMaxLength = 20;
        public const int SheetEncumbranceMaxLength = 25;

    }
}
