namespace SheetsWithoutNumber.Services.Character
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using SWN.Data;
    using SWN.Data.Models;
    using SheetsWithoutNumber.Models.Characters;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using static SWN.Data.DataConstants;
    using static SWN.Data.DataConstants.ClassData;
    using static SWN.Data.DataConstants.FocusData;
    using static SWN.Data.DataConstants.ArmorData;

    public class CharacterService : ICharacterService
    {
        private readonly SWNDbContext data;
        private readonly IConfigurationProvider mapper;

        public CharacterService(SWNDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper.ConfigurationProvider;
        }

        public int Create(string name, int backgroundId, int classId, string characterImage, int strength, int constitution, int dexterity, int wisdom, int intelligence, int charisma, string homeworld, string species, string ownerId, int gameId)
        {
            var character = new Character
            {
                Name = name,
                BackgroundId = backgroundId,
                ClassId = classId,
                CharacterImage = characterImage,
                Strength = strength,
                Constitution = constitution,
                Dexterity = dexterity,
                Wisdom = wisdom,
                Intelligence = intelligence,
                Charisma = charisma,
                Homeworld = homeworld,
                Species = species,
                OwnerId = ownerId,
                GameId = gameId,
            };

            data.Characters.Add(character);

            data.Games
                .FirstOrDefault(g => g.Id == gameId)
                .Characters
                .Add(character);

            data.SaveChanges();

            return character.Id;
        }

        public CharacterDetailsModel Details(int characterId, string userId)
        {
            var character = data
                .Characters
                .Where(c => c.Id == characterId)
                .ProjectTo<CharacterDetailsModel>(this.mapper)
                .FirstOrDefault();

            character.UserId = userId;
            character.StrengthMod = this.CalculateAttributeModifier(character.Strength);
            character.DexterityMod = this.CalculateAttributeModifier(character.Dexterity);
            character.ConstitutionMod = this.CalculateAttributeModifier(character.Constitution);
            character.IntelligenceMod = this.CalculateAttributeModifier(character.Intelligence);
            character.CharismaMod = this.CalculateAttributeModifier(character.Charisma);
            character.WisdomMod = this.CalculateAttributeModifier(character.Wisdom);
            character.Initiative = character.DexterityMod;
            character.MaxSystemStrain = character.Constitution;
            character.CharactersSkills = character.CharactersSkills
                .OrderBy(cs => cs.SkillName)
                .ThenBy(cs => cs.IsSkillPsychic)
                .ToList();
            character.CharactersFoci = character.CharactersFoci
                .OrderBy(cs => cs.FocusName)
                .ToList();
            character.CharactersEquipments = character.CharactersEquipments
                .OrderBy(ce => ce.EquipmentType)
                .ThenBy(ce => ce.EquipmentName)
                .ToList();
            character.CharactersArmors = character.CharactersArmors
                .OrderBy(ca => ca.ArmorClass)
                .ThenBy(ca => ca.ArmorName)
                .ToList();

            character.CurrentReadiedEncumbrance = this.CalculateCurrentReadiedEncumbrance(character.CharactersEquipments, character.CharactersArmors);
            character.MaxReadiedEncumbrance = this.CalculateMaxReadiedEncumbrance(character.Strength, character.CharactersArmors);
            character.CurrentStowedEncumbrance = this.CalculateCurrentStowedEncumbrance(character.CharactersEquipments, character.CharactersArmors);
            character.MaxStowedEncumbrance = this.CalculateMaxStowedEncumbrance(character.Strength, character.CharactersArmors);
            character.Encumbrance = this.CalculateEncumbrance(character.CurrentReadiedEncumbrance, character.MaxReadiedEncumbrance, character.CurrentStowedEncumbrance, character.MaxStowedEncumbrance);

            character.Speed = this.CalculateSpeed(character.Encumbrance);

            character.ArmorClass = this.CalculateArmorClass(character.DexterityMod, character.CharactersFoci, character.Level, character.CharactersArmors);

            character.SavingThrowEvasion = this.CalculateSavingThrow(character.Level, character.StrengthMod, character.ConstitutionMod, character.DexterityMod, character.WisdomMod, character.CharismaMod, character.IntelligenceMod, "Evasion");
            character.SavingThrowPhysical = this.CalculateSavingThrow(character.Level, character.StrengthMod, character.ConstitutionMod, character.DexterityMod, character.WisdomMod, character.CharismaMod, character.IntelligenceMod, "Physical");
            character.SavingThrowMental = this.CalculateSavingThrow(character.Level, character.StrengthMod, character.ConstitutionMod, character.DexterityMod, character.WisdomMod, character.CharismaMod, character.IntelligenceMod, "Mental");

            character.MinimumXP = this.CalculateMinimumXP(character.Level);
            character.MaximumXP = this.CalculateMaximumXP(character.Level);
            character.XPBarWidth = this.CalculateExperiencePercentage(character.CurrentXP, character.MinimumXP, character.MaximumXP);
            character.AttackBonus = this.CalculateAttackBonus(character.Class, character.Level);

            var highestPsychicLevel = 0;
            if (character.CharactersSkills.Where(cs => cs.IsSkillPsychic).Any())
            {
                highestPsychicLevel = character.CharactersSkills
                .Where(cs => cs.IsSkillPsychic)
                .OrderByDescending(cs => cs.SkillLevel)
                .FirstOrDefault().SkillLevel;
            }
            var hasPsychicTrainingFocus = false;
            var wildTalentFocusLevel = 0;
            if (character.CharactersFoci.Any())
            {
                hasPsychicTrainingFocus = character.CharactersFoci.Any(cf => cf.FocusName == FocusPsychicTrainingName);

                if (character.CharactersFoci.Any(cf => cf.FocusName == FocusWildPsychicTalentName))
                {
                    wildTalentFocusLevel = character.CharactersFoci.Where(cf => cf.FocusName == FocusWildPsychicTalentName).FirstOrDefault().FocusLevel;
                }
            }
            character.MaxEffort = this.CalculateMaxEffort(character.Class, character.WisdomMod, character.ConstitutionMod, highestPsychicLevel, hasPsychicTrainingFocus, wildTalentFocusLevel);

            return character;
        }

        public bool Edit(int characterId, string name, string characterImage, int strength, int dexterity, int constitution, int intelligence, int charisma, int wisdom, int currentXP, int hitPoints, int maxHitPoints, int effort, int systemStrain, int credits)
        {
            var characterData = this.data.Characters.Find(characterId);

            if (characterData == null)
            {
                return false;
            }

            characterData.Name = name;
            characterData.CharacterImage = characterImage;
            characterData.Strength = strength;
            characterData.Dexterity = dexterity;
            characterData.Constitution = constitution;
            characterData.Intelligence = intelligence;
            characterData.Charisma = charisma;
            characterData.Wisdom = wisdom;
            characterData.CurrentXP = currentXP;
            characterData.Level = this.CalculateLevel(currentXP);
            characterData.HitPoints = hitPoints;
            characterData.MaxHitPoints = maxHitPoints;
            characterData.Effort = effort;
            characterData.SystemStrain = systemStrain;
            characterData.Credits = credits;

            this.data.SaveChanges();

            return true;
        }

        public int Delete(int characterId)
        {
            var character = data
                .Characters
                .Where(c => c.Id == characterId)
                .FirstOrDefault();

            var characterSkills = data.CharactersSkills
                .Where(cs => cs.CharacterId == characterId)
                .ToList();

            foreach (var characterSkill in characterSkills)
            {
                data.CharactersSkills.Remove(characterSkill);
            }

            character.CharactersSkills.Clear();

            data.Characters.Remove(character);

            data.SaveChanges();

            return character.Id;
        }

        public IEnumerable<CharacterListingModel> ByUser(string userId)
        {
            var characters = data
                .Characters
                .Where(c => c.OwnerId == userId)
                .ProjectTo<CharacterListingModel>(this.mapper)
                .ToList();

            return characters;
        }

        public IEnumerable<CharacterClassViewModel> GetCharacterClasses()
            => this.data
             .Classes
             .ProjectTo<CharacterClassViewModel>(this.mapper)
             .ToList();

        public IEnumerable<CharacterBackgroundViewModel> GetCharacterBackgrounds()
            => this.data
            .Backgrounds
            .OrderBy(b => b.Name)
            .ProjectTo<CharacterBackgroundViewModel>(this.mapper)
            .ToList();

        public CharacterOwnerModel GetCharacterById(int characterId)
           => this.data
            .Characters
            .Where(c => c.Id == characterId)
            .ProjectTo<CharacterOwnerModel>(this.mapper)
            .FirstOrDefault();

        public bool ClassExists(int classId)
            => this.data.Classes.Any(c => c.Id == classId);

        public bool BackgroundExists(int backgroundId)
            => this.data.Backgrounds.Any(b => b.Id == backgroundId);

        public int CalculateAttackBonus(string className, int level)
        {
            var attackMod = className switch
            {
                ClassData.WarriorClassName => level,
                ClassData.ExpertWarriorClassName => level / 2,
                ClassData.PsychicWarriorClassName => level / 2,
                _ => level / 2
            };

            if (className == ClassData.ExpertWarriorClassName || className == ClassData.PsychicWarriorClassName)
            {
                if (level >= 5)
                {
                    attackMod += 1;
                }
                else
                {
                    attackMod += 2;
                }
            }

            return attackMod;
        }

        public int CalculateCurrentReadiedEncumbrance(ICollection<CharactersEquipments> charactersEquipments, ICollection<CharactersArmors> charactersArmors)
        {
            var readiedEncumbrance = 0;

            foreach (var characterEquipment in charactersEquipments)
            {
                if (characterEquipment.EquipmentLocation == "Readied")
                {
                    readiedEncumbrance += characterEquipment.EquipmentEncumbrance;
                }
            }

            foreach (var characterArmor in charactersArmors)
            {
                if (characterArmor.ArmorLocation == "Readied")
                {
                    readiedEncumbrance += characterArmor.ArmorEncumbrance;
                }
            }

            return readiedEncumbrance;
        }

        public int CalculateMaxReadiedEncumbrance(int strength, ICollection<CharactersArmors> charactersArmors)
        {
            if (charactersArmors.Any(ca => ca.ArmorName == StormArmorName))
            {
                strength += 4;
            }

            var maxReadiedEncumbrance = strength / 2;

            return maxReadiedEncumbrance;
        }

        public int CalculateCurrentStowedEncumbrance(ICollection<CharactersEquipments> characterEquipments, ICollection<CharactersArmors> charactersArmors)
        {
            var stowedEncumbrance = 0;

            foreach (var characterEquipment in characterEquipments)
            {
                if (characterEquipment.EquipmentLocation == "Stowed" || characterEquipment.EquipmentLocation == "Backpack")
                {
                    stowedEncumbrance += characterEquipment.EquipmentEncumbrance;
                }
            }

            foreach (var characterArmor in charactersArmors)
            {
                if (characterArmor.ArmorLocation == "Stowed" || characterArmor.ArmorLocation == "Backpack")
                {
                    stowedEncumbrance += characterArmor.ArmorEncumbrance;
                }
            }

            return stowedEncumbrance;
        }

        public int CalculateMaxStowedEncumbrance(int strength, ICollection<CharactersArmors> charactersArmors)
        {
            if (charactersArmors.Any(ca => ca.ArmorName == StormArmorName))
            {
                strength += 4;
            }

            var maxStowedEncumbrance = strength;

            return maxStowedEncumbrance;
        }

        public string CalculateEncumbrance(int currentReadiedEncumbrance, int maxReadiedEncumbrance, int currentStowedEncumbrance, int maxStowedEncumbrance)
        {
            var encumbrance = "Normal";

            var surplusReadiedEncumbrance = currentReadiedEncumbrance - maxReadiedEncumbrance;
            var surplusStowedEncumbrance = currentStowedEncumbrance - maxStowedEncumbrance;

            if (surplusReadiedEncumbrance > 4 || surplusStowedEncumbrance > 8)
            {
                encumbrance = "Overburdened!";
            }
            else if ((surplusReadiedEncumbrance > 2 && surplusReadiedEncumbrance <= 4) ||
                (surplusStowedEncumbrance > 4 && surplusStowedEncumbrance <= 8))
            {
                encumbrance = "Heavily Encumbered";
            }
            else if ((surplusReadiedEncumbrance > 0 && surplusReadiedEncumbrance <= 2) ||
                (surplusStowedEncumbrance > 0 && surplusStowedEncumbrance <= 4))
            {
                encumbrance = "Lightly Encumbered";
            }

            return encumbrance;
        }

        public int CalculateSpeed(string encumbrance)
        {
            var speed = 10;

            if (encumbrance == "Lightly Encumbered")
            {
                speed = 7;
            }
            else if (encumbrance == "Heavily Encumbered")
            {
                speed = 5;
            }
            else if (encumbrance == "Overburdened")
            {
                speed = 0;
            }

            return speed;
        }

        public int CalculateMaxEffort(string characterClass, int wisdomMod, int constitutionMod, int highestPsychicLevel, bool hasPsychicTrainingFocus, int wildTalentFocusLevel)
        {
            var maxEffort = 0;

            if (characterClass == PsychicClassName || characterClass == PsychicWarriorClassName || characterClass == ExpertPsychicClassName)
            {
                maxEffort += 1 + Math.Max(wisdomMod, constitutionMod) + highestPsychicLevel;

                if (maxEffort < 1)
                {
                    maxEffort = 1;
                }
            }

            if (hasPsychicTrainingFocus)
            {
                maxEffort += 1;
            }

            if (wildTalentFocusLevel > 0)
            {
                maxEffort += wildTalentFocusLevel;
            }

            return maxEffort;
        }

        public int CalculateSavingThrow(int level, int strengthMod, int constitutionMod, int dexterityMod, int wisdomMod, int charismaMod, int intelligenceMod, string savingThrowType)
        {
            var savingThrow = 15;
            savingThrow -= level - 1;

            if (savingThrowType == "Physical")
            {
                savingThrow -= Math.Max(strengthMod, constitutionMod);
            }
            else if (savingThrowType == "Evasion")
            {
                savingThrow -= Math.Max(dexterityMod, intelligenceMod);
            }
            else if (savingThrowType == "Mental")
            {
                savingThrow -= Math.Max(wisdomMod, charismaMod);
            }

            return savingThrow;
        }

        public int CalculateExperiencePercentage(int currentXP, int minimumXP, int maximumXP)
        {
            var result = (currentXP - minimumXP) * 100 / (maximumXP - minimumXP);

            var percentage = result;

            return percentage;
        }

        public int CalculateAttributeModifier(int attribute)
        {
            var attributeMod = attribute switch
            {
                3 => -2,
                >= 4 and < 8 => -1,
                >= 8 and < 14 => 0,
                >= 14 and < 18 => +1,
                18 => +2
            };

            return attributeMod;
        }

        public int CalculateLevel(int currentXP)
        {
            var level = currentXP switch
            {
                < 3 => 1,
                >= 3 and < 6 => 2,
                >= 6 and < 12 => 3,
                >= 12 and < 18 => 4,
                >= 18 and < 27 => 5,
                >= 27 and < 39 => 6,
                >= 39 and < 54 => 7,
                >= 54 and < 72 => 8,
                >= 72 and < 93 => 9,
                >= 93 and < 117 => 10,
                >= 117 => 10 + (int)((currentXP - 93) / 24)
            };

            return level;
        }

        public int CalculateMinimumXP(int level)
        {
            var minimumXP = level switch
            {
                1 => 0,
                2 => 3,
                3 => 6,
                4 => 12,
                5 => 18,
                6 => 27,
                7 => 39,
                8 => 54,
                9 => 72,
                10 => 93,
                >= 11 => 93 + 24 * (level - 10)
            };

            return minimumXP;
        }

        public int CalculateMaximumXP(int level)
        {
            var maximumXP = level switch
            {
                1 => 3,
                2 => 6,
                3 => 12,
                4 => 18,
                5 => 27,
                6 => 39,
                7 => 54,
                8 => 72,
                9 => 93,
                10 => 117,
                >= 11 => 117 + 24 * (level - 10)
            };

            return maximumXP;
        }

        public int CalculateArmorClass(int dexterityMod, ICollection<CharactersFoci> characterFoci, int characterLevel, ICollection<CharactersArmors> characterArmors)
        {
            var hasIronhide = characterFoci.Any(cf => cf.FocusName == FocusIronhideName);

            double characterLevelReal = Math.Ceiling((double)characterLevel / 2);

            var armorClass = 10;

            if (hasIronhide)
            {
                armorClass = 15 + (int)characterLevelReal;
            }

            if (characterArmors.Any())
            {
                armorClass = characterArmors.Max(ca => ca.ArmorClass);
            }

            armorClass += dexterityMod;

            return armorClass;
        }
    }
}
