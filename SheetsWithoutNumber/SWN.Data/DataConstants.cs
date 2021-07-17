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
        public const int ClassNameMaxLength = 40;

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

        //Constants for the Character Entity
        public const int CharacterNameMaxLength = 30;
        public const int CharacterSpeciesMaxLength = 20;
        public const int CharacterHomeworldMaxLength = 20;
        public const int CharacterEncumbranceMaxLength = 25;

        //Constants for the Class Entity
        public const string ClassExpertAbility = "•You gain a free level in a non-combat focus related to your background. Most concepts will take Specialist in their main skill, though Diplomat, Starfarer, Healer, or some other focus might suit better. You may not take a combat-oriented focus with this perk. In case of uncertainty, the GM decides whether or not a focus is permitted.\n•Once per scene, you can reroll a failed skill check, taking the new roll if it’s better.\n•When you advance an experience level, you gain a bonus skill point that can be spent on any non-combat, non-psychic skill. You can save this point to spend later if you wish.";
        public const string ClassExpertDescription = "Your hero is exceptionally good at a useful skill. Doctors, cat burglars, starship pilots, grifters, technicians, or any other concept that focuses on expertise in a non-combat skill should pick the Expert class. Experts are the best at such skills and gain more of them than other classes do. Just as a Warrior can be relied upon to make a shot when the chips are down, an Expert has a knack for succeeding at the moments of greatest importance. Once per scene, an Expert can reroll a failed skill check, taking the new result if it’s better.This benefit can be applied to any skill check, even those that the Expert isn’t specially focused in. Their natural talent bleeds over into everything they do. In their chosen field, however, the Expert is exceptionally gifted. Aside from the free focus level that all PCs get at the start of the game, an Expert can choose an additional level in a non-combat focus related to their background. They can spend both of these levels on the same focus if they wish, thus starting the game with level 2 in that particular knack.";

    }
}
