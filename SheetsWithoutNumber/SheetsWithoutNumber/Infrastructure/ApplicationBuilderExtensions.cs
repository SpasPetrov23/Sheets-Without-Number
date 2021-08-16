namespace SheetsWithoutNumber.Infrastructure
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using SWN.Data;
    using SWN.Data.Models;
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;

    using static Areas.Admin.AdminConstants;
    using static SWN.Data.DataConstants.ClassData;
    using static SWN.Data.DataConstants.Background;
    using static SWN.Data.DataConstants.SkillData;
    using static SWN.Data.DataConstants.FocusData;
    using static SWN.Data.DataConstants.EquipmentData;
    using static SWN.Data.DataConstants.ArmorData;
    using static SWN.Data.DataConstants.MeleeWeaponData;
    using static SWN.Data.DataConstants.RangedWeaponData;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider;

            MigrateDatabase(services);

            SeedAdministrators(services);
            SeedClasses(services);
            SeedBackgrounds(services);
            SeedSkills(services);
            SeedFoci(services);
            SeedEquipment(services);
            SeedArmor(services);
            SeedMeleeWeapons(services);
            SeedRangedWeapons(services);

            return app;
        }

        private static void MigrateDatabase(IServiceProvider services)
        {

            var data = services.GetRequiredService<SWNDbContext>();

            data.Database.EnsureDeleted();
            data.Database.Migrate();
        }

        private static void SeedAdministrators(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<User>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task
                .Run(async () =>
                {
                    if (await roleManager.RoleExistsAsync(AdministratorRoleName))
                    {
                        return;
                    }

                    var role = new IdentityRole { Name = AdministratorRoleName };

                    await roleManager.CreateAsync(role);

                    const string adminEmail = "admin@swn.com";
                    const string adminUsername = "Admin";
                    const string adminPassword = "admin123";

                    var user = new User
                    {
                        Email = adminEmail,
                        UserName = adminUsername,
                    };

                    await userManager.CreateAsync(user, adminPassword);

                    await userManager.AddToRoleAsync(user, role.Name);
                })
                .GetAwaiter()
                .GetResult();
        }

        private static void SeedClasses(IServiceProvider services)
        {
            var data = services.GetRequiredService<SWNDbContext>();

            if (data.Classes.Any())
            {
                return;
            }

            data.Classes.AddRange(new[]
            {
                new Class
                {
                    Name = "Expert",
                    Ability = ExpertAbility,
                    Description = ExpertDescription,
                },
                new Class
                {
                    Name = "Warrior",
                    Ability = WarriorAbility,
                    Description = WarriorDescription,
                },
                new Class
                {
                    Name = "Psychic",
                    Ability = PsychicAbility,
                    Description = PsychicDescription,
                },
                new Class
                {
                    Name = "Adventurer (Expert + Psychic)",
                    Ability = AdventurerAbilityExpertPsychic,
                    Description = AdventurerDescription,
                },
                new Class
                {
                    Name = "Adventurer (Expert + Warrior)",
                    Ability = AdventurerAbilityExpertWarrior,
                    Description = AdventurerDescription,
                },
                new Class
                {
                    Name = "Adventurer (Psychic + Warrior)",
                    Ability = AdventurerAbilityPsychicWarrior,
                    Description = AdventurerDescription,
                }
            });

            data.SaveChanges();
        }

        private static void SeedBackgrounds(IServiceProvider services)
        {
            var data = services.GetRequiredService<SWNDbContext>();

            if (data.Backgrounds.Any())
            {
                return;
            }

            data.Backgrounds.AddRange(new[]
            {
                new Background
                {
                    Name = "Barbarian",
                    Description = BarbarianDescription
                },
                new Background
                {
                    Name = "Clergy",
                    Description = ClergyDescription
                },
                new Background
                {
                    Name = "Courtesan",
                    Description = CourtesanDescription
                },
                new Background
                {
                    Name = "Criminal",
                    Description = CriminalDescription
                },
                new Background
                {
                    Name = "Dilettante",
                    Description = DilettanteDescription
                },
                new Background
                {
                    Name = "Entertainer",
                    Description = EntertainerDescription
                },
                new Background
                {
                    Name = "Merchant",
                    Description = MerchantDescription
                },
                new Background
                {
                    Name = "Noble",
                    Description = NobleDescription
                },
                new Background
                {
                    Name = "Official",
                    Description = OfficialDescription
                },
                new Background
                {
                    Name = "Peasant",
                    Description = PeasantDescription
                },
                new Background
                {
                    Name = "Physician",
                    Description = PhysicianDescription
                },
                new Background
                {
                    Name = "Pilot",
                    Description = PilotDescription
                },
                new Background
                {
                    Name = "Politician",
                    Description = PoliticianDescription
                },
                new Background
                {
                    Name = "Scholar",
                    Description = ScholarDescription
                },
                new Background
                {
                    Name = "Soldier",
                    Description = SoliderDescription
                },
                new Background
                {
                    Name = "Spacer",
                    Description = SpacerDescription
                },
                new Background
                {
                    Name = "Technician",
                    Description = TechnicianDescription
                },
                new Background
                {
                    Name = "Thug",
                    Description = ThugDescription
                },
                new Background
                {
                    Name = "Vagabond",
                    Description = VagabondDescription
                },
                new Background
                {
                    Name = "Worker",
                    Description = WorkerDescription
                }
            });

            data.SaveChanges();
        }

        private static void SeedSkills(IServiceProvider services)
        {
            var data = services.GetRequiredService<SWNDbContext>();

            if (data.Skills.Any())
            {
                return;
            }

            data.Skills.AddRange(new[]
            {
                new Skill
                {
                    Name = SkillAdministerName,
                    Description = SkillAdministerDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillConnectName,
                    Description = SkillConnectDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillExertName,
                    Description = SkillExertDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillFixName,
                    Description = SkillFixDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillHealName,
                    Description = SkillHealDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillKnowName,
                    Description = SkillKnowDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillLeadName,
                    Description = SkillLeadDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillNoticeName,
                    Description = SkillNoticeDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillPerformName,
                    Description = SkillPerformDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillPilotName,
                    Description = SkillPilotDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillProgramName,
                    Description = SkillProgramDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillPunchName,
                    Description = SkillPunchDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillShootName,
                    Description = SkillShootDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillSneakName,
                    Description = SkillSneakDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillStabName,
                    Description = SkillStabDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillSurviveName,
                    Description = SkillSurviveDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillTalkName,
                    Description = SkillTalkDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillTradeName,
                    Description = SkillTradeDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillWorkName,
                    Description = SkillWorkDescription,
                    IsPsychic = false
                },
                new Skill
                {
                    Name = SkillBiopsionicsName,
                    Description = SkillBiopsionicsDescription,
                    IsPsychic = true
                },
                new Skill
                {
                    Name = SkillMetapsionicsName,
                    Description = SkillMetapsionicsDescription,
                    IsPsychic = true
                },
                new Skill
                {
                    Name = SkillPrecognitionName,
                    Description = SkillPrecognitionDescription,
                    IsPsychic = true
                },
                new Skill
                {
                    Name = SkillTelekinesisName,
                    Description = SkillTelekinesisDescription,
                    IsPsychic = true
                },
                new Skill
                {
                    Name = SkillTelepathyName,
                    Description = SkillTelepathyDescription,
                    IsPsychic = true
                },
                new Skill
                {
                    Name = SkillTeleportationName,
                    Description = SkillTeleportationDescription,
                    IsPsychic = true
                },
            });

            data.SaveChanges();
        }

        private static void SeedFoci(IServiceProvider services)
        {
            var data = services.GetRequiredService<SWNDbContext>();

            if (data.Foci.Any())
            {
                return;
            }

            data.Foci.AddRange(new[]
            {
                new Focus
                {
                    Name = FocusAlertName,
                    Description = FoucsAlertDescription
                },
                new Focus
                {
                    Name = FocusArmsmanName,
                    Description = FoucsArmsmanDescription
                },
                new Focus
                {
                    Name = FocusAssassinName,
                    Description = FoucsAssassinDescription
                },
                new Focus
                {
                    Name = FocusCloseCombatantName,
                    Description = FoucsCloseCombatantDescription
                },
                new Focus
                {
                    Name = FocusConnectedName,
                    Description = FoucsConnectedDescription
                },
                new Focus
                {
                    Name = FocusDieHardName,
                    Description = FoucsDieHardDescription
                },
                new Focus
                {
                    Name = FocusDiplomatName,
                    Description = FoucsDiplomatDescription
                },
                new Focus
                {
                    Name = FocusGunslingerName,
                    Description = FoucsGunslingerDescription
                },
                new Focus
                {
                    Name = FocusHackerName,
                    Description = FoucsHackerDescription
                },
                new Focus
                {
                    Name = FocusHealerName,
                    Description = FoucsHealerDescription
                },
                new Focus
                {
                    Name = FocusHenchkeeperName,
                    Description = FoucsHenchkeeperDescription
                },
                new Focus
                {
                    Name = FocusIronhideName,
                    Description = FoucsIronhideDescription
                },
                new Focus
                {
                    Name = FocusPsychicTrainingName,
                    Description = FoucsPsychicTrainingDescription
                },
                new Focus
                {
                    Name = FocusSavageFrayName,
                    Description = FoucsSavageFrayDescription
                },
                new Focus
                {
                    Name = FocusShockingAssaultName,
                    Description = FoucsShockingAssaultDescription
                },
                new Focus
                {
                    Name = FocusSniperName,
                    Description = FoucsSniperDescription
                },
                new Focus
                {
                    Name = FocusSpecialistAdministerName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistConnectName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistExertName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistFixName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistHealName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistKnowName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistLeadName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistNoticeName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistPerformName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistPilotName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistProgramName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistSneakName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistSurviveName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistTalkName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistTradeName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusSpecialistWorkName,
                    Description = FoucsSpecialistDescription
                },
                new Focus
                {
                    Name = FocusStarCaptainName,
                    Description = FoucsStarCaptainDescription
                },
                new Focus
                {
                    Name = FocusStarfarerName,
                    Description = FoucsStarfarerDescription
                },
                new Focus
                {
                    Name = FocusTinkerName,
                    Description = FoucsTinkerDescription
                },
                new Focus
                {
                    Name = FocusUnarmedCombatantName,
                    Description = FoucsUnarmedCombatantDescription
                },
                new Focus
                {
                    Name = FocusUniqueGiftName,
                    Description = FoucsUniqueGiftDescription
                },
                new Focus
                {
                    Name = FocusWandererName,
                    Description = FoucsWandererDescription
                },
                new Focus
                {
                    Name = FocusWildPsychicTalentName,
                    Description = FocusWildPsychicTalentName
                },
            });

            data.SaveChanges();
        }

        private static void SeedEquipment(IServiceProvider services)
        {
            var data = services.GetRequiredService<SWNDbContext>();

            if (data.Equipments.Any())
            {
                return;
            }

            data.Equipments.AddRange(new[]
            {
                new Equipment
                {
                    Name = Ammo20RoundsName,
                    Description = Ammo20RoundsDescription,
                    Type = Ammo20RoundsType,
                    Cost = Ammo20RoundsCost,
                    Encumbrance = Ammo20RoundsEncumbrance,
                    TechLevel = Ammo20RoundsTL
                },
                new Equipment
                {
                    Name = AmmoMissileName,
                    Description = AmmoMissileDescription,
                    Type = AmmoMissileType,
                    Cost = AmmoMissileCost,
                    Encumbrance = AmmoMissileEncumbrance,
                    TechLevel = AmmoMissileTL
                },
                new Equipment
                {
                    Name = PowerCellTypeAName,
                    Description = PowerCellTypeADescription,
                    Type = PowerCellTypeAType,
                    Cost = PowerCellTypeACost,
                    Encumbrance = PowerCellTypeAEncumbrance,
                    TechLevel = PowerCellTypeATL
                },
                new Equipment
                {
                    Name = PowerCellTypeBName,
                    Description = PowerCellTypeBDescription,
                    Type = PowerCellTypeBType,
                    Cost = PowerCellTypeBCost,
                    Encumbrance = PowerCellTypeBEncumbrance,
                    TechLevel = PowerCellTypeBTL
                },
                new Equipment
                {
                    Name = SolarRechargerName,
                    Description = SolarRechargerDescription,
                    Type = SolarRechargerType,
                    Cost = SolarRechargerCost,
                    Encumbrance = SolarRechargerEncumbrance,
                    TechLevel = SolarRechargerTL
                },
                new Equipment
                {
                    Name = TelekineticGeneratorName,
                    Description = TelekineticGeneratorDescription,
                    Type = TelekineticGeneratorType,
                    Cost = TelekineticGeneratorCost,
                    Encumbrance = TelekineticGeneratorEncumbrance,
                    TechLevel = TelekineticGeneratorTL
                },
                new Equipment
                {
                    Name = CommServerName,
                    Description = CommServerDescription,
                    Type = CommServerType,
                    Cost = CommServerCost,
                    Encumbrance = CommServerEncumbrance,
                    TechLevel = CommServerTL
                },
                new Equipment
                {
                    Name = CompadName,
                    Description = CompadDescription,
                    Type = CompadType,
                    Cost = CompadCost,
                    Encumbrance = CompadEncumbrance,
                    TechLevel = CompadTL
                },
                new Equipment
                {
                    Name = FieldRadioName,
                    Description = FieldRadioDescription,
                    Type = FieldRadioType,
                    Cost = FieldRadioCost,
                    Encumbrance = FieldRadioEncumbrance,
                    TechLevel = FieldRadioTL
                },
                new Equipment
                {
                    Name = TranslatorTorcName,
                    Description = TranslatorTorcDescription,
                    Type = TranslatorTorcType,
                    Cost = TranslatorTorcCost,
                    Encumbrance = TranslatorTorcEncumbrance,
                    TechLevel = TranslatorTorcTL
                },
                new Equipment
                {
                    Name = BlackSlabName,
                    Description = BlackSlabDescription,
                    Type = BlackSlabType,
                    Cost = BlackSlabCost,
                    Encumbrance = BlackSlabEncumbrance,
                    TechLevel = BlackSlabTL
                },
                new Equipment
                {
                    Name = DataPhaseTapName,
                    Description = DataPhaseTapDescription,
                    Type = DataPhaseTapType,
                    Cost = DataPhaseTapCost,
                    Encumbrance = DataPhaseTapEncumbrance,
                    TechLevel = DataPhaseTapTL
                },
                new Equipment
                {
                    Name = DataProtocolName,
                    Description = DataProtocolDescription,
                    Type = DataProtocolType,
                    Cost = DataProtocolCost,
                    Encumbrance = DataProtocolEncumbrance,
                    TechLevel = DataProtocolTL
                },
                new Equipment
                {
                    Name = DataslabName,
                    Description = DataslabDescription,
                    Type = DataslabType,
                    Cost = DataslabCost,
                    Encumbrance = DataslabEncumbrance,
                    TechLevel = DataslabTL
                },
                new Equipment
                {
                    Name = LineShuntName,
                    Description = LineShuntDescription,
                    Type = LineShuntType,
                    Cost = LineShuntCost,
                    Encumbrance = LineShuntEncumbrance,
                    TechLevel = LineShuntTL
                },
                new Equipment
                {
                    Name = RemoteLinkUnitName,
                    Description = RemoteLinkUnitDescription,
                    Type = RemoteLinkUnitType,
                    Cost = RemoteLinkUnitCost,
                    Encumbrance = RemoteLinkUnitEncumbrance,
                    TechLevel = RemoteLinkUnitTL
                },
                new Equipment
                {
                    Name = StilettoChargeName,
                    Description = StilettoChargeDescription,
                    Type = StilettoChargeType,
                    Cost = StilettoChargeCost,
                    Encumbrance = StilettoChargeEncumbrance,
                    TechLevel = StilettoChargeTL
                },
                new Equipment
                {
                    Name = StorageUnitName,
                    Description = StorageUnitDescription,
                    Type = StorageUnitType,
                    Cost = StorageUnitCost,
                    Encumbrance = StorageUnitEncumbrance,
                    TechLevel = StorageUnitTL
                },
                new Equipment
                {
                    Name = TightbeamLinkUnitName,
                    Description = TightbeamLinkUnitDescription,
                    Type = TightbeamLinkUnitType,
                    Cost = TightbeamLinkUnitCost,
                    Encumbrance = TightbeamLinkUnitEncumbrance,
                    TechLevel = TightbeamLinkUnitTL
                },
                new Equipment
                {
                    Name = AtmofilterName,
                    Description = AtmofilterDescription,
                    Type = AtmofilterType,
                    Cost = AtmofilterCost,
                    Encumbrance = AtmofilterEncumbrance,
                    TechLevel = AtmofilterTL
                },
                new Equipment
                {
                    Name = BackpackTL0Name,
                    Description = BackpackTL0Description,
                    Type = BackpackTL0Type,
                    Cost = BackpackTL0Cost,
                    Encumbrance = BackpackTL0Encumbrance,
                    TechLevel = BackpackTL0TL
                },
                new Equipment
                {
                    Name = BackpackTL4Name,
                    Description = BackpackTL4Description,
                    Type = BackpackTL4Type,
                    Cost = BackpackTL4Cost,
                    Encumbrance = BackpackTL4Encumbrance,
                    TechLevel = BackpackTL4TL
                },
                new Equipment
                {
                    Name = BinocularsTL3Name,
                    Description = BinocularsTL3Description,
                    Type = BinocularsTL3Type,
                    Cost = BinocularsTL3Cost,
                    Encumbrance = BinocularsTL3Encumbrance,
                    TechLevel = BinocularsTL3TL
                },
                new Equipment
                {
                    Name = BinocularsTL4Name,
                    Description = BinocularsTL4Description,
                    Type = BinocularsTL4Type,
                    Cost = BinocularsTL4Cost,
                    Encumbrance = BinocularsTL4Encumbrance,
                    TechLevel = BinocularsTL4TL
                },
                new Equipment
                {
                    Name = ClimbingHarnessName,
                    Description = ClimbingHarnessDescription,
                    Type = ClimbingHarnessType,
                    Cost = ClimbingHarnessCost,
                    Encumbrance = ClimbingHarnessEncumbrance,
                    TechLevel = ClimbingHarnessTL
                },
                new Equipment
                {
                    Name = GlowbugName,
                    Description = GlowbugDescription,
                    Type = GlowbugType,
                    Cost = GlowbugCost,
                    Encumbrance = GlowbugEncumbrance,
                    TechLevel = GlowbugTL
                },
                new Equipment
                {
                    Name = GrapnelLauncherName,
                    Description = GrapnelLauncherDescription,
                    Type = GrapnelLauncherType,
                    Cost = GrapnelLauncherCost,
                    Encumbrance = GrapnelLauncherEncumbrance,
                    TechLevel = GrapnelLauncherTL
                },
                new Equipment
                {
                    Name = GravChuteTL4Name,
                    Description = GravChuteTL4Description,
                    Type = GravChuteTL4Type,
                    Cost = GravChuteTL4Cost,
                    Encumbrance = GravChuteTL4Encumbrance,
                    TechLevel = GravChuteTL4TL
                },
                new Equipment
                {
                    Name = GravChuteTL5Name,
                    Description = GravChuteTL5Description,
                    Type = GravChuteTL5Type,
                    Cost = GravChuteTL5Cost,
                    Encumbrance = GravChuteTL5Encumbrance,
                    TechLevel = GravChuteTL5TL
                },
                new Equipment
                {
                    Name = GravHarnessName,
                    Description = GravHarnessDescription,
                    Type = GravHarnessType,
                    Cost = GravHarnessCost,
                    Encumbrance = GravHarnessEncumbrance,
                    TechLevel = GravHarnessTL
                },
                new Equipment
                {
                    Name = InstapanelName,
                    Description = InstapanelDescription,
                    Type = InstapanelType,
                    Cost = InstapanelCost,
                    Encumbrance = InstapanelEncumbrance,
                    TechLevel = InstapanelTL
                },
                new Equipment
                {
                    Name = LowlightgogglesName,
                    Description = LowlightgogglesDescription,
                    Type = LowlightgogglesType,
                    Cost = LowlightgogglesCost,
                    Encumbrance = LowlightgogglesEncumbrance,
                    TechLevel = LowlightgogglesTL
                },
                new Equipment
                {
                    Name = NavcompName,
                    Description = NavcompDescription,
                    Type = NavcompType,
                    Cost = NavcompCost,
                    Encumbrance = NavcompEncumbrance,
                    TechLevel = NavcompTL
                },
                new Equipment
                {
                    Name = PortaboxName,
                    Description = PortaboxDescription,
                    Type = PortaboxType,
                    Cost = PortaboxCost,
                    Encumbrance = PortaboxEncumbrance,
                    TechLevel = PortaboxTL
                },
                new Equipment
                {
                    Name = PressureTentName,
                    Description = PressureTentDescription,
                    Type = PressureTentType,
                    Cost = PressureTentCost,
                    Encumbrance = PressureTentEncumbrance,
                    TechLevel = PressureTentTL
                },
                new Equipment
                {
                    Name = Rations1dayName,
                    Description = Rations1dayDescription,
                    Type = Rations1dayType,
                    Cost = Rations1dayCost,
                    Encumbrance = Rations1dayEncumbrance,
                    TechLevel = Rations1dayTL
                },
                new Equipment
                {
                    Name = RopeTL020metersName,
                    Description = RopeTL020metersDescription,
                    Type = RopeTL020metersType,
                    Cost = RopeTL020metersCost,
                    Encumbrance = RopeTL020metersEncumbrance,
                    TechLevel = RopeTL020metersTL
                },
                new Equipment
                {
                    Name = RopeTL420metersName,
                    Description = RopeTL420metersDescription,
                    Type = RopeTL420metersType,
                    Cost = RopeTL420metersCost,
                    Encumbrance = RopeTL420metersEncumbrance,
                    TechLevel = RopeTL420metersTL
                },
                new Equipment
                {
                    Name = ScoutReportName,
                    Description = ScoutReportDescription,
                    Type = ScoutReportType,
                    Cost = ScoutReportCost,
                    Encumbrance = ScoutReportEncumbrance,
                    TechLevel = ScoutReportTL
                },
                new Equipment
                {
                    Name = SurveyScannerName,
                    Description = SurveyScannerDescription,
                    Type = SurveyScannerType,
                    Cost = SurveyScannerCost,
                    Encumbrance = SurveyScannerEncumbrance,
                    TechLevel = SurveyScannerTL
                },
                new Equipment
                {
                    Name = SurvivalKitName,
                    Description = SurvivalKitDescription,
                    Type = SurvivalKitType,
                    Cost = SurvivalKitCost,
                    Encumbrance = SurvivalKitEncumbrance,
                    TechLevel = SurvivalKitTL
                },
                new Equipment
                {
                    Name = TelescopingPoleName,
                    Description = TelescopingPoleDescription,
                    Type = TelescopingPoleType,
                    Cost = TelescopingPoleCost,
                    Encumbrance = TelescopingPoleEncumbrance,
                    TechLevel = TelescopingPoleTL
                },
                new Equipment
                {
                    Name = ThermalFlareName,
                    Description = ThermalFlareDescription,
                    Type = ThermalFlareType,
                    Cost = ThermalFlareCost,
                    Encumbrance = ThermalFlareEncumbrance,
                    TechLevel = ThermalFlareTL
                },
                new Equipment
                {
                    Name = TradeGoodsName,
                    Description = TradeGoodsDescription,
                    Type = TradeGoodsType,
                    Cost = TradeGoodsCost,
                    Encumbrance = TradeGoodsEncumbrance,
                    TechLevel = TradeGoodsTL
                },
                new Equipment
                {
                    Name = TradeMetalsName,
                    Description = TradeMetalsDescription,
                    Type = TradeMetalsType,
                    Cost = TradeMetalsCost,
                    Encumbrance = TradeMetalsEncumbrance,
                    TechLevel = TradeMetalsTL
                },
                new Equipment
                {
                    Name = VaccFresherName,
                    Description = VaccFresherDescription,
                    Type = VaccFresherType,
                    Cost = VaccFresherCost,
                    Encumbrance = VaccFresherEncumbrance,
                    TechLevel = VaccFresherTL
                },
                new Equipment
                {
                    Name = VaccSkinName,
                    Description = VaccSkinDescription,
                    Type = VaccSkinType,
                    Cost = VaccSkinCost,
                    Encumbrance = VaccSkinEncumbrance,
                    TechLevel = VaccSkinTL
                },
                new Equipment
                {
                    Name = OxygenTankName,
                    Description = OxygenTankDescription,
                    Type = OxygenTankType,
                    Cost = OxygenTankCost,
                    Encumbrance = OxygenTankEncumbrance,
                    TechLevel = OxygenTankTL
                },
                new Equipment
                {
                    Name = BezoarName,
                    Description = BezoarDescription,
                    Type = BezoarType,
                    Cost = BezoarCost,
                    Encumbrance = BezoarEncumbrance,
                    TechLevel = BezoarTL
                },
                new Equipment
                {
                    Name = BrainwaveName,
                    Description = BrainwaveDescription,
                    Type = BrainwaveType,
                    Cost = BrainwaveCost,
                    Encumbrance = BrainwaveEncumbrance,
                    TechLevel = BrainwaveTL
                },
                new Equipment
                {
                    Name = HushName,
                    Description = HushDescription,
                    Type = HushType,
                    Cost = HushCost,
                    Encumbrance = HushEncumbrance,
                    TechLevel = HushTL
                },
                new Equipment
                {
                    Name = LiftName,
                    Description = LiftDescription,
                    Type = LiftType,
                    Cost = LiftCost,
                    Encumbrance = LiftEncumbrance,
                    TechLevel = LiftTL
                },
                new Equipment
                {
                    Name = PsychName,
                    Description = PsychDescription,
                    Type = PsychType,
                    Cost = PsychCost,
                    Encumbrance = PsychEncumbrance,
                    TechLevel = PsychTL
                },
                new Equipment
                {
                    Name = PretechCosmeticName,
                    Description = PretechCosmeticDescription,
                    Type = PretechCosmeticType,
                    Cost = PretechCosmeticCost,
                    Encumbrance = PretechCosmeticEncumbrance,
                    TechLevel = PretechCosmeticTL
                },
                new Equipment
                {
                    Name = ReverieName,
                    Description = ReverieDescription,
                    Type = ReverieType,
                    Cost = ReverieCost,
                    Encumbrance = ReverieEncumbrance,
                    TechLevel = ReverieTL
                },
                new Equipment
                {
                    Name = SquealName,
                    Description = SquealDescription,
                    Type = SquealType,
                    Cost = SquealCost,
                    Encumbrance = SquealEncumbrance,
                    TechLevel = SquealTL
                },
                new Equipment
                {
                    Name = TsunamiName,
                    Description = TsunamiDescription,
                    Type = TsunamiType,
                    Cost = TsunamiCost,
                    Encumbrance = TsunamiEncumbrance,
                    TechLevel = TsunamiTL
                },
                new Equipment
                {
                    Name = BiosacannerName,
                    Description = BiosacannerDescription,
                    Type = BiosacannerType,
                    Cost = BiosacannerCost,
                    Encumbrance = BiosacannerEncumbrance,
                    TechLevel = BiosacannerTL
                },
                new Equipment
                {
                    Name = LazarusPatchName,
                    Description = LazarusPatchDescription,
                    Type = LazarusPatchType,
                    Cost = LazarusPatchCost,
                    Encumbrance = LazarusPatchEncumbrance,
                    TechLevel = LazarusPatchTL
                },
                new Equipment
                {
                    Name = MedkitName,
                    Description = MedkitDescription,
                    Type = MedkitType,
                    Cost = MedkitCost,
                    Encumbrance = MedkitEncumbrance,
                    TechLevel = MedkitTL
                },
                new Equipment
                {
                    Name = MetatoolName,
                    Description = MetatoolDescription,
                    Type = MetatoolType,
                    Cost = MetatoolCost,
                    Encumbrance = MetatoolEncumbrance,
                    TechLevel = MetatoolTL
                },
                new Equipment
                {
                    Name = SparePartsName,
                    Description = SparePartsDescription,
                    Type = SparePartsType,
                    Cost = SparePartsCost,
                    Encumbrance = SparePartsEncumbrance,
                    TechLevel = SparePartsTL
                },
                new Equipment
                {
                    Name = TailoredAntiallergensName,
                    Description = TailoredAntiallergensDescription,
                    Type = TailoredAntiallergensType,
                    Cost = TailoredAntiallergensCost,
                    Encumbrance = TailoredAntiallergensEncumbrance,
                    TechLevel = TailoredAntiallergensTL
                },
                new Equipment
                {
                    Name = ToolkitPostechName,
                    Description = ToolkitPostechDescription,
                    Type = ToolkitPostechType,
                    Cost = ToolkitPostechCost,
                    Encumbrance = ToolkitPostechEncumbrance,
                    TechLevel = ToolkitPostechTL
                },
                new Equipment
                {
                    Name = ToolkitPretechName,
                    Description = ToolkitPretechDescription,
                    Type = ToolkitPretechType,
                    Cost = ToolkitPretechCost,
                    Encumbrance = ToolkitPretechEncumbrance,
                    TechLevel = ToolkitPretechTL
                },
                new Equipment
                {
                    Name = RutterName,
                    Description = RutterDescription,
                    Type = RutterType,
                    Cost = RutterCost,
                    Encumbrance = RutterEncumbrance,
                    TechLevel = RutterTL
                }
            });

            data.SaveChanges();
        }

        private static void SeedArmor(IServiceProvider services)
        {
            var data = services.GetRequiredService<SWNDbContext>();

            if (data.Armors.Any())
            {
                return;
            }

            data.Armors.AddRange(new[]
            {
                new Armor
                {
                    Name = ShieldName,
                    Description = ShieldDescription,
                    ArmorClass = ShieldAC,
                    Type = ShieldType,
                    Cost = ShieldCost,
                    Encumbrance = ShieldEncumbrance,
                    TechLevel = ShieldTL
                },
                new Armor
                {
                    Name = LeatherJackName,
                    Description = LeatherJackDescription,
                    ArmorClass = LeatherJackAC,
                    Type = LeatherJackType,
                    Cost = LeatherJackCost,
                    Encumbrance = LeatherJackEncumbrance,
                    TechLevel = LeatherJackTL
                },
                new Armor
                {
                    Name = ThickHideName,
                    Description = ThickHideDescription,
                    ArmorClass = ThickHideAC,
                    Type = ThickHideType,
                    Cost = ThickHideCost,
                    Encumbrance = ThickHideEncumbrance,
                    TechLevel = ThickHideTL
                },
                new Armor
                {
                    Name = QuiltedArmorName,
                    Description = QuiltedArmorDescription,
                    ArmorClass = QuiltedArmorAC,
                    Type = QuiltedArmorType,
                    Cost = QuiltedArmorCost,
                    Encumbrance = QuiltedArmorEncumbrance,
                    TechLevel = QuiltedArmorTL
                },
                new Armor
                {
                    Name = CuriassName,
                    Description = CuriassDescription,
                    ArmorClass = CuriassAC,
                    Type = CuriassType,
                    Cost = CuriassCost,
                    Encumbrance = CuriassEncumbrance,
                    TechLevel = CuriassTL
                },
                new Armor
                {
                    Name = BrigandineName,
                    Description = BrigandineDescription,
                    ArmorClass = BrigandineAC,
                    Type = BrigandineType,
                    Cost = BrigandineCost,
                    Encumbrance = BrigandineEncumbrance,
                    TechLevel = BrigandineTL
                },
                new Armor
                {
                    Name = LinothoraxName,
                    Description = LinothoraxDescription,
                    ArmorClass = LinothoraxAC,
                    Type = LinothoraxType,
                    Cost = LinothoraxCost,
                    Encumbrance = LinothoraxEncumbrance,
                    TechLevel = LinothoraxTL
                },
                new Armor
                {
                    Name = HalfPlateName,
                    Description = HalfPlateDescription,
                    ArmorClass = HalfPlateAC,
                    Type = HalfPlateType,
                    Cost = HalfPlateCost,
                    Encumbrance = HalfPlateEncumbrance,
                    TechLevel = HalfPlateTL
                },
                new Armor
                {
                    Name = FullPlateName,
                    Description = FullPlateDescription,
                    ArmorClass = FullPlateAC,
                    Type = FullPlateType,
                    Cost = FullPlateCost,
                    Encumbrance = FullPlateEncumbrance,
                    TechLevel = FullPlateTL
                },
                new Armor
                {
                    Name = LayeredMailName,
                    Description = LayeredMailDescription,
                    ArmorClass = LayeredMailAC,
                    Type = LayeredMailType,
                    Cost = LayeredMailCost,
                    Encumbrance = LayeredMailEncumbrance,
                    TechLevel = LayeredMailTL
                },
                new Armor
                {
                    Name = WarpaintName,
                    Description = WarpaintDescription,
                    ArmorClass = WarpaintAC,
                    Type = WarpaintType,
                    Cost = WarpaintCost,
                    Encumbrance = WarpaintEncumbrance,
                    TechLevel = WarpaintTL
                },
                new Armor
                {
                    Name = ArmoredUndersuitName,
                    Description = ArmoredUndersuitDescription,
                    ArmorClass = ArmoredUndersuitAC,
                    Type = ArmoredUndersuitType,
                    Cost = ArmoredUndersuitCost,
                    Encumbrance = ArmoredUndersuitEncumbrance,
                    TechLevel = ArmoredUndersuitTL
                },
                new Armor
                {
                    Name = SecureClothingName,
                    Description = SecureClothingDescription,
                    ArmorClass = SecureClothingAC,
                    Type = SecureClothingType,
                    Cost = SecureClothingCost,
                    Encumbrance = SecureClothingEncumbrance,
                    TechLevel = SecureClothingTL
                },
                new Armor
                {
                    Name = ArmoredVaccSuitName,
                    Description = ArmoredVaccSuitDescription,
                    ArmorClass = ArmoredVaccSuitAC,
                    Type = ArmoredVaccSuitType,
                    Cost = ArmoredVaccSuitCost,
                    Encumbrance = ArmoredVaccSuitEncumbrance,
                    TechLevel = ArmoredVaccSuitTL
                },
                new Armor
                {
                    Name = DeflectorArrayName,
                    Description = DeflectorArrayDescription,
                    ArmorClass = DeflectorArrayAC,
                    Type = DeflectorArrayType,
                    Cost = DeflectorArrayCost,
                    Encumbrance = DeflectorArrayEncumbrance,
                    TechLevel = DeflectorArrayTL
                },
                new Armor
                {
                    Name = ForcePavisName,
                    Description = ForcePavisDescription,
                    ArmorClass = ForcePavisAC,
                    Type = ForcePavisType,
                    Cost = ForcePavisCost,
                    Encumbrance = ForcePavisEncumbrance,
                    TechLevel = ForcePavisTL
                },
                new Armor
                {
                    Name = SecurityArmorName,
                    Description = SecurityArmorDescription,
                    ArmorClass = SecurityArmorAC,
                    Type = SecurityArmorType,
                    Cost = SecurityArmorCost,
                    Encumbrance = SecurityArmorEncumbrance,
                    TechLevel = SecurityArmorTL
                },
                new Armor
                {
                    Name = WovenBodyArmorName,
                    Description = WovenBodyArmorDescription,
                    ArmorClass = WovenBodyArmorAC,
                    Type = WovenBodyArmorType,
                    Cost = WovenBodyArmorCost,
                    Encumbrance = WovenBodyArmorEncumbrance,
                    TechLevel = WovenBodyArmorTL
                },
                new Armor
                {
                    Name = CombatFieldUniformName,
                    Description = CombatFieldUniformDescription,
                    ArmorClass = CombatFieldUniformAC,
                    Type = CombatFieldUniformType,
                    Cost = CombatFieldUniformCost,
                    Encumbrance = CombatFieldUniformEncumbrance,
                    TechLevel = CombatFieldUniformTL
                },
                new Armor
                {
                    Name = IcarusHarnessName,
                    Description = IcarusHarnessDescription,
                    ArmorClass = IcarusHarnessAC,
                    Type = IcarusHarnessType,
                    Cost = IcarusHarnessCost,
                    Encumbrance = IcarusHarnessEncumbrance,
                    TechLevel = IcarusHarnessTL
                },
                new Armor
                {
                    Name = VestimentumName,
                    Description = VestimentumDescription,
                    ArmorClass = VestimentumAC,
                    Type = VestimentumType,
                    Cost = VestimentumCost,
                    Encumbrance = VestimentumEncumbrance,
                    TechLevel = VestimentumTL
                },
                new Armor
                {
                    Name = AssaultSuitName,
                    Description = AssaultSuitDescription,
                    ArmorClass = AssaultSuitAC,
                    Type = AssaultSuitType,
                    Cost = AssaultSuitCost,
                    Encumbrance = AssaultSuitEncumbrance,
                    TechLevel = AssaultSuitTL
                },
                new Armor
                {
                    Name = StormArmorName,
                    Description = StormArmorDescription,
                    ArmorClass = StormArmorAC,
                    Type = StormArmorType,
                    Cost = StormArmorCost,
                    Encumbrance = StormArmorEncumbrance,
                    TechLevel = StormArmorTL
                },
                new Armor
                {
                    Name = FieldEmitterPanoplyName,
                    Description = FieldEmitterPanoplyDescription,
                    ArmorClass = FieldEmitterPanoplyAC,
                    Type = FieldEmitterPanoplyType,
                    Cost = FieldEmitterPanoplyCost,
                    Encumbrance = FieldEmitterPanoplyEncumbrance,
                    TechLevel = FieldEmitterPanoplyTL
                },
                new Armor
                {
                    Name = ArmorVaccSuitName,
                    Description = ArmorVaccSuitDescription,
                    ArmorClass = ArmorVaccSuitAC,
                    Type = ArmorVaccSuitType,
                    Cost = ArmorVaccSuitCost,
                    Encumbrance = ArmorVaccSuitEncumbrance,
                    TechLevel = ArmorVaccSuitTL
                }
            });

            data.SaveChanges();
        }

        private static void SeedMeleeWeapons(IServiceProvider services)
        {
            var data = services.GetRequiredService<SWNDbContext>();
        
            if (data.MeleeWeapons.Any())
            {
                return;
            }
        
            data.MeleeWeapons.AddRange(new[]
            {
                new MeleeWeapon
                {
                    Name = SmallPrimitiveWeaponName,
                    Description = SmallPrimitiveWeaponDescription,
                    Attribute = SmallPrimitiveWeaponAttribute,
                    Damage = SmallPrimitiveWeaponDamage,
                    Skill = SmallPrimitiveWeaponSkill,
                    ShockPoints = SmallPrimitiveWeaponShockPoints,
                    ShockAC = SmallPrimitiveWeaponShockAC,
                    Cost = SmallPrimitiveWeaponCost,
                    ThrowRange = SmallPrimitiveWeaponThrowRange,
                    Encumbrance = SmallPrimitiveWeaponEncumbrance,
                    TechLevel = SmallPrimitiveWeaponTL
                },
                new MeleeWeapon
                {
                    Name = KnifeName,
                    Description = KnifeDescription,
                    Attribute = KnifeAttribute,
                    Damage = KnifeDamage,
                    Skill = KnifeSkill,
                    ShockPoints = KnifeShockPoints,
                    ShockAC = KnifeShockAC,
                    Cost = KnifeCost,
                    ThrowRange = KnifeThrowRange,
                    Encumbrance = KnifeEncumbrance,
                    TechLevel = KnifeTL
                },
                new MeleeWeapon
                {
                    Name = SpikedKnucklesName,
                    Description = SpikedKnucklesDescription,
                    Attribute = SpikedKnucklesAttribute,
                    Damage = SpikedKnucklesDamage,
                    Skill = SpikedKnucklesSkill,
                    ShockPoints = SpikedKnucklesShockPoints,
                    ShockAC = SpikedKnucklesShockAC,
                    Cost = SpikedKnucklesCost,
                    ThrowRange = SpikedKnucklesThrowRange,
                    Encumbrance = SpikedKnucklesEncumbrance,
                    TechLevel = SpikedKnucklesTL
                },
                new MeleeWeapon
                {
                    Name = MediumPrimitiveWeaponName,
                    Description = MediumPrimitiveWeaponDescription,
                    Attribute = MediumPrimitiveWeaponAttribute,
                    Damage = MediumPrimitiveWeaponDamage,
                    Skill = MediumPrimitiveWeaponSkill,
                    ShockPoints = MediumPrimitiveWeaponShockPoints,
                    ShockAC = MediumPrimitiveWeaponShockAC,
                    Cost = MediumPrimitiveWeaponCost,
                    ThrowRange = MediumPrimitiveWeaponThrowRange,
                    Encumbrance = MediumPrimitiveWeaponEncumbrance,
                    TechLevel = MediumPrimitiveWeaponTL
                },
                new MeleeWeapon
                {
                    Name = SpearName,
                    Description = SpearDescription,
                    Attribute = SpearAttribute,
                    Damage = SpearDamage,
                    Skill = SpearSkill,
                    ShockPoints = SpearShockPoints,
                    ShockAC = SpearShockAC,
                    Cost = SpearCost,
                    ThrowRange = SpearThrowRange,
                    Encumbrance = SpearEncumbrance,
                    TechLevel = SpearTL
                },
                new MeleeWeapon
                {
                    Name = LargePrimitiveWeaponName,
                    Description = LargePrimitiveWeaponDescription,
                    Attribute = LargePrimitiveWeaponAttribute,
                    Damage = LargePrimitiveWeaponDamage,
                    Skill = LargePrimitiveWeaponSkill,
                    ShockPoints = LargePrimitiveWeaponShockPoints,
                    ShockAC = LargePrimitiveWeaponShockAC,
                    Cost = LargePrimitiveWeaponCost,
                    ThrowRange = LargePrimitiveWeaponThrowRange,
                    Encumbrance = LargePrimitiveWeaponEncumbrance,
                    TechLevel = LargePrimitiveWeaponTL
                },
                new MeleeWeapon
                {
                    Name = SmallAdvancedWeaponName,
                    Description = SmallAdvancedWeaponDescription,
                    Attribute = SmallAdvancedWeaponAttribute,
                    Damage = SmallAdvancedWeaponDamage,
                    Skill = SmallAdvancedWeaponSkill,
                    ShockPoints = SmallAdvancedWeaponShockPoints,
                    ShockAC = SmallAdvancedWeaponShockAC,
                    Cost = SmallAdvancedWeaponCost,
                    ThrowRange = SmallAdvancedWeaponThrowRange,
                    Encumbrance = SmallAdvancedWeaponEncumbrance,
                    TechLevel = SmallAdvancedWeaponTL
                },
                new MeleeWeapon
                {
                    Name = MonobladeKnifeName,
                    Description = MonobladeKnifeDescription,
                    Attribute = MonobladeKnifeAttribute,
                    Damage = MonobladeKnifeDamage,
                    Skill = MonobladeKnifeSkill,
                    ShockPoints = MonobladeKnifeShockPoints,
                    ShockAC = MonobladeKnifeShockAC,
                    Cost = MonobladeKnifeCost,
                    ThrowRange = MonobladeKnifeThrowRange,
                    Encumbrance = MonobladeKnifeEncumbrance,
                    TechLevel = MonobladeKnifeTL
                },
                new MeleeWeapon
                {
                    Name = ThermalKnifeName,
                    Description = ThermalKnifeDescription,
                    Attribute = ThermalKnifeAttribute,
                    Damage = ThermalKnifeDamage,
                    Skill = ThermalKnifeSkill,
                    ShockPoints = ThermalKnifeShockPoints,
                    ShockAC = ThermalKnifeShockAC,
                    Cost = ThermalKnifeCost,
                    ThrowRange = ThermalKnifeThrowRange,
                    Encumbrance = ThermalKnifeEncumbrance,
                    TechLevel = ThermalKnifeTL
                },
                new MeleeWeapon
                {
                    Name = KinesisWrapsName,
                    Description = KinesisWrapsDescription,
                    Attribute = KinesisWrapsAttribute,
                    Damage = KinesisWrapsDamage,
                    Skill = KinesisWrapsSkill,
                    ShockPoints = KinesisWrapsShockPoints,
                    ShockAC = KinesisWrapsShockAC,
                    Cost = KinesisWrapsCost,
                    ThrowRange = KinesisWrapsThrowRange,
                    Encumbrance = KinesisWrapsEncumbrance,
                    TechLevel = KinesisWrapsTL
                },
                new MeleeWeapon
                {
                    Name = MediumAdvancedWeaponName,
                    Description = MediumAdvancedWeaponDescription,
                    Attribute = MediumAdvancedWeaponAttribute,
                    Damage = MediumAdvancedWeaponDamage,
                    Skill = MediumAdvancedWeaponSkill,
                    ShockPoints = MediumAdvancedWeaponShockPoints,
                    ShockAC = MediumAdvancedWeaponShockAC,
                    Cost = MediumAdvancedWeaponCost,
                    ThrowRange = MediumAdvancedWeaponThrowRange,
                    Encumbrance = MediumAdvancedWeaponEncumbrance,
                    TechLevel = MediumAdvancedWeaponTL
                },
                new MeleeWeapon
                {
                    Name = LargeAdvancedWeaponName,
                    Description = LargeAdvancedWeaponDescription,
                    Attribute = LargeAdvancedWeaponAttribute,
                    Damage = LargeAdvancedWeaponDamage,
                    Skill = LargeAdvancedWeaponSkill,
                    ShockPoints = LargeAdvancedWeaponShockPoints,
                    ShockAC = LargeAdvancedWeaponShockAC,
                    Cost = LargeAdvancedWeaponCost,
                    ThrowRange = LargeAdvancedWeaponThrowRange,
                    Encumbrance = LargeAdvancedWeaponEncumbrance,
                    TechLevel = LargeAdvancedWeaponTL
                },
                new MeleeWeapon
                {
                    Name = StunBatonName,
                    Description = StunBatonDescription,
                    Attribute = StunBatonAttribute,
                    Damage = StunBatonDamage,
                    Skill = StunBatonSkill,
                    ShockPoints = StunBatonShockPoints,
                    ShockAC = StunBatonShockAC,
                    Cost = StunBatonCost,
                    ThrowRange = StunBatonThrowRange,
                    Encumbrance = StunBatonEncumbrance,
                    TechLevel = StunBatonTL
                },
                new MeleeWeapon
                {
                    Name = SuitRipperName,
                    Description = SuitRipperDescription,
                    Attribute = SuitRipperAttribute,
                    Damage = SuitRipperDamage,
                    Skill = SuitRipperSkill,
                    ShockPoints = SuitRipperShockPoints,
                    ShockAC = SuitRipperShockAC,
                    Cost = SuitRipperCost,
                    ThrowRange = SuitRipperThrowRange,
                    Encumbrance = SuitRipperEncumbrance,
                    TechLevel = SuitRipperTL
                },
                new MeleeWeapon
                {
                    Name = UnarmedAttackName,
                    Description = UnarmedAttackDescription,
                    Attribute = UnarmedAttackAttribute,
                    Damage = UnarmedAttackDamage,
                    Skill = UnarmedAttackSkill,
                    ShockPoints = UnarmedAttackShockPoints,
                    ShockAC = UnarmedAttackShockAC,
                    Cost = UnarmedAttackCost,
                    ThrowRange = UnarmedAttackThrowRange,
                    Encumbrance = UnarmedAttackEncumbrance,
                    TechLevel = UnarmedAttackTL
                }
            });
        
            data.SaveChanges();
        }

        private static void SeedRangedWeapons(IServiceProvider services)
        {
            var data = services.GetRequiredService<SWNDbContext>();

            if (data.RangedWeapons.Any())
            {
                return;
            }

            data.RangedWeapons.AddRange(new[]
            {
                new RangedWeapon
                {
                    Name = PrimitiveBowName,
                    Description = PrimitiveBowDescription,
                    AmmoType = PrimitiveBowAmmoType,
                    Damage = PrimitiveBowDamage,
                    NormalRange = PrimitiveBowNormalRange,
                    MaximumRange = PrimitiveBowMaxRange,
                    Cost = PrimitiveBowCost,
                    Magazine = PrimitiveBowMagazine,
                    Attribute = PrimitiveBowAttribute,
                    Encumbrance = PrimitiveBowEncumbrance,
                    TechLevel = PrimitiveBowTL,
                    IsHeavy = PrimitiveBowIsHeavy
                },
                new RangedWeapon
                {
                    Name = AdvancedBowName,
                    Description = AdvancedBowDescription,
                    AmmoType = AdvancedBowAmmoType,
                    Damage = AdvancedBowDamage,
                    NormalRange = AdvancedBowNormalRange,
                    MaximumRange = AdvancedBowMaxRange,
                    Cost = AdvancedBowCost,
                    Magazine = AdvancedBowMagazine,
                    Attribute = AdvancedBowAttribute,
                    Encumbrance = AdvancedBowEncumbrance,
                    TechLevel = AdvancedBowTL,
                    IsHeavy = AdvancedBowIsHeavy
                },
                new RangedWeapon
                {
                    Name = ConversionBowName,
                    Description = ConversionBowDescription,
                    AmmoType = ConversionBowAmmoType,
                    Damage = ConversionBowDamage,
                    NormalRange = ConversionBowNormalRange,
                    MaximumRange = ConversionBowMaxRange,
                    Cost = ConversionBowCost,
                    Magazine = ConversionBowMagazine,
                    Attribute = ConversionBowAttribute,
                    Encumbrance = ConversionBowEncumbrance,
                    TechLevel = ConversionBowTL,
                    IsHeavy = ConversionBowIsHeavy
                },
                new RangedWeapon
                {
                    Name = GrenadeName,
                    Description = GrenadeDescription,
                    AmmoType = GrenadeAmmoType,
                    Damage = GrenadeDamage,
                    NormalRange = GrenadeNormalRange,
                    MaximumRange = GrenadeMaxRange,
                    Cost = GrenadeCost,
                    Magazine = GrenadeMagazine,
                    Attribute = GrenadeAttribute,
                    Encumbrance = GrenadeEncumbrance,
                    TechLevel = GrenadeTL,
                    IsHeavy = GrenadeIsHeavy
                },
                new RangedWeapon
                {
                    Name = CrudePistolName,
                    Description = CrudePistolDescription,
                    AmmoType = CrudePistolAmmoType,
                    Damage = CrudePistolDamage,
                    NormalRange = CrudePistolNormalRange,
                    MaximumRange = CrudePistolMaxRange,
                    Cost = CrudePistolCost,
                    Magazine = CrudePistolMagazine,
                    Attribute = CrudePistolAttribute,
                    Encumbrance = CrudePistolEncumbrance,
                    TechLevel = CrudePistolTL,
                    IsHeavy = CrudePistolIsHeavy
                },
                new RangedWeapon
                {
                    Name = MusketName,
                    Description = MusketDescription,
                    AmmoType = MusketAmmoType,
                    Damage = MusketDamage,
                    NormalRange = MusketNormalRange,
                    MaximumRange = MusketMaxRange,
                    Cost = MusketCost,
                    Magazine = MusketMagazine,
                    Attribute = MusketAttribute,
                    Encumbrance = MusketEncumbrance,
                    TechLevel = MusketTL,
                    IsHeavy = MusketIsHeavy
                },
                new RangedWeapon
                {
                    Name = RevolverName,
                    Description = RevolverDescription,
                    AmmoType = RevolverAmmoType,
                    Damage = RevolverDamage,
                    NormalRange = RevolverNormalRange,
                    MaximumRange = RevolverMaxRange,
                    Cost = RevolverCost,
                    Magazine = RevolverMagazine,
                    Attribute = RevolverAttribute,
                    Encumbrance = RevolverEncumbrance,
                    TechLevel = RevolverTL,
                    IsHeavy = RevolverIsHeavy
                },
                new RangedWeapon
                {
                    Name = RifleName,
                    Description = RifleDescription,
                    AmmoType = RifleAmmoType,
                    Damage = RifleDamage,
                    NormalRange = RifleNormalRange,
                    MaximumRange = RifleMaxRange,
                    Cost = RifleCost,
                    Magazine = RifleMagazine,
                    Attribute = RifleAttribute,
                    Encumbrance = RifleEncumbrance,
                    TechLevel = RifleTL,
                    IsHeavy = RifleIsHeavy
                },
                new RangedWeapon
                {
                    Name = ShotgunName,
                    Description = ShotgunDescription,
                    AmmoType = ShotgunAmmoType,
                    Damage = ShotgunDamage,
                    NormalRange = ShotgunNormalRange,
                    MaximumRange = ShotgunMaxRange,
                    Cost = ShotgunCost,
                    Magazine = ShotgunMagazine,
                    Attribute = ShotgunAttribute,
                    Encumbrance = ShotgunEncumbrance,
                    TechLevel = ShotgunTL,
                    IsHeavy = ShotgunIsHeavy
                },
                new RangedWeapon
                {
                    Name = SemiAutoPistolName,
                    Description = SemiAutoPistolDescription,
                    AmmoType = SemiAutoPistolAmmoType,
                    Damage = SemiAutoPistolDamage,
                    NormalRange = SemiAutoPistolNormalRange,
                    MaximumRange = SemiAutoPistolMaxRange,
                    Cost = SemiAutoPistolCost,
                    Magazine = SemiAutoPistolMagazine,
                    Attribute = SemiAutoPistolAttribute,
                    Encumbrance = SemiAutoPistolEncumbrance,
                    TechLevel = SemiAutoPistolTL,
                    IsHeavy = SemiAutoPistolIsHeavy
                },
                new RangedWeapon
                {
                    Name = SubmachineGunName,
                    Description = SubmachineGunDescription,
                    AmmoType = SubmachineGunAmmoType,
                    Damage = SubmachineGunDamage,
                    NormalRange = SubmachineGunNormalRange,
                    MaximumRange = SubmachineGunMaxRange,
                    Cost = SubmachineGunCost,
                    Magazine = SubmachineGunMagazine,
                    Attribute = SubmachineGunAttribute,
                    Encumbrance = SubmachineGunEncumbrance,
                    TechLevel = SubmachineGunTL,
                    IsHeavy = SubmachineGunIsHeavy
                },
                new RangedWeapon
                {
                    Name = CombatRifleName,
                    Description = CombatRifleDescription,
                    AmmoType = CombatRifleAmmoType,
                    Damage = CombatRifleDamage,
                    NormalRange = CombatRifleNormalRange,
                    MaximumRange = CombatRifleMaxRange,
                    Cost = CombatRifleCost,
                    Magazine = CombatRifleMagazine,
                    Attribute = CombatRifleAttribute,
                    Encumbrance = CombatRifleEncumbrance,
                    TechLevel = CombatRifleTL,
                    IsHeavy = CombatRifleIsHeavy
                },
                new RangedWeapon
                {
                    Name = CombatShotgunName,
                    Description = CombatShotgunDescription,
                    AmmoType = CombatShotgunAmmoType,
                    Damage = CombatShotgunDamage,
                    NormalRange = CombatShotgunNormalRange,
                    MaximumRange = CombatShotgunMaxRange,
                    Cost = CombatShotgunCost,
                    Magazine = CombatShotgunMagazine,
                    Attribute = CombatShotgunAttribute,
                    Encumbrance = CombatShotgunEncumbrance,
                    TechLevel = CombatShotgunTL,
                    IsHeavy = CombatShotgunIsHeavy
                },
                new RangedWeapon
                {
                    Name = SniperRifleName,
                    Description = SniperRifleDescription,
                    AmmoType = SniperRifleAmmoType,
                    Damage = SniperRifleDamage,
                    NormalRange = SniperRifleNormalRange,
                    MaximumRange = SniperRifleMaxRange,
                    Cost = SniperRifleCost,
                    Magazine = SniperRifleMagazine,
                    Attribute = SniperRifleAttribute,
                    Encumbrance = SniperRifleEncumbrance,
                    TechLevel = SniperRifleTL,
                    IsHeavy = SniperRifleIsHeavy
                },
                new RangedWeapon
                {
                    Name = VoidCarbineName,
                    Description = VoidCarbineDescription,
                    AmmoType = VoidCarbineAmmoType,
                    Damage = VoidCarbineDamage,
                    NormalRange = VoidCarbineNormalRange,
                    MaximumRange = VoidCarbineMaxRange,
                    Cost = VoidCarbineCost,
                    Magazine = VoidCarbineMagazine,
                    Attribute = VoidCarbineAttribute,
                    Encumbrance = VoidCarbineEncumbrance,
                    TechLevel = VoidCarbineTL,
                    IsHeavy = VoidCarbineIsHeavy
                },
                new RangedWeapon
                {
                    Name = MagPistolName,
                    Description = MagPistolDescription,
                    AmmoType = MagPistolAmmoType,
                    Damage = MagPistolDamage,
                    NormalRange = MagPistolNormalRange,
                    MaximumRange = MagPistolMaxRange,
                    Cost = MagPistolCost,
                    Magazine = MagPistolMagazine,
                    Attribute = MagPistolAttribute,
                    Encumbrance = MagPistolEncumbrance,
                    TechLevel = MagPistolTL,
                    IsHeavy = MagPistolIsHeavy
                },
                new RangedWeapon
                {
                    Name = MagRifleName,
                    Description = MagRifleDescription,
                    AmmoType = MagRifleAmmoType,
                    Damage = MagRifleDamage,
                    NormalRange = MagRifleNormalRange,
                    MaximumRange = MagRifleMaxRange,
                    Cost = MagRifleCost,
                    Magazine = MagRifleMagazine,
                    Attribute = MagRifleAttribute,
                    Encumbrance = MagRifleEncumbrance,
                    TechLevel = MagRifleTL,
                    IsHeavy = MagRifleIsHeavy
                },
                new RangedWeapon
                {
                    Name = SpikeThrowerName,
                    Description = SpikeThrowerDescription,
                    AmmoType = SpikeThrowerAmmoType,
                    Damage = SpikeThrowerDamage,
                    NormalRange = SpikeThrowerNormalRange,
                    MaximumRange = SpikeThrowerMaxRange,
                    Cost = SpikeThrowerCost,
                    Magazine = SpikeThrowerMagazine,
                    Attribute = SpikeThrowerAttribute,
                    Encumbrance = SpikeThrowerEncumbrance,
                    TechLevel = SpikeThrowerTL,
                    IsHeavy = SpikeThrowerIsHeavy
                },
                new RangedWeapon
                {
                    Name = LaserPistolName,
                    Description = LaserPistolDescription,
                    AmmoType = LaserPistolAmmoType,
                    Damage = LaserPistolDamage,
                    NormalRange = LaserPistolNormalRange,
                    MaximumRange = LaserPistolMaxRange,
                    Cost = LaserPistolCost,
                    Magazine = LaserPistolMagazine,
                    Attribute = LaserPistolAttribute,
                    Encumbrance = LaserPistolEncumbrance,
                    TechLevel = LaserPistolTL,
                    IsHeavy = LaserPistolIsHeavy
                },
                new RangedWeapon
                {
                    Name = LaserRifleName,
                    Description = LaserRifleDescription,
                    AmmoType = LaserRifleAmmoType,
                    Damage = LaserRifleDamage,
                    NormalRange = LaserRifleNormalRange,
                    MaximumRange = LaserRifleMaxRange,
                    Cost = LaserRifleCost,
                    Magazine = LaserRifleMagazine,
                    Attribute = LaserRifleAttribute,
                    Encumbrance = LaserRifleEncumbrance,
                    TechLevel = LaserRifleTL,
                    IsHeavy = LaserRifleIsHeavy
                },
                new RangedWeapon
                {
                    Name = ThermalPistolName,
                    Description = ThermalPistolDescription,
                    AmmoType = ThermalPistolAmmoType,
                    Damage = ThermalPistolDamage,
                    NormalRange = ThermalPistolNormalRange,
                    MaximumRange = ThermalPistolMaxRange,
                    Cost = ThermalPistolCost,
                    Magazine = ThermalPistolMagazine,
                    Attribute = ThermalPistolAttribute,
                    Encumbrance = ThermalPistolEncumbrance,
                    TechLevel = ThermalPistolTL,
                    IsHeavy = ThermalPistolIsHeavy
                },
                new RangedWeapon
                {
                    Name = PlasmaProjectorName,
                    Description = PlasmaProjectorDescription,
                    AmmoType = PlasmaProjectorAmmoType,
                    Damage = PlasmaProjectorDamage,
                    NormalRange = PlasmaProjectorNormalRange,
                    MaximumRange = PlasmaProjectorMaxRange,
                    Cost = PlasmaProjectorCost,
                    Magazine = PlasmaProjectorMagazine,
                    Attribute = PlasmaProjectorAttribute,
                    Encumbrance = PlasmaProjectorEncumbrance,
                    TechLevel = PlasmaProjectorTL,
                    IsHeavy = PlasmaProjectorIsHeavy
                },
                new RangedWeapon
                {
                    Name = ShearRifleName,
                    Description = ShearRifleDescription,
                    AmmoType = ShearRifleAmmoType,
                    Damage = ShearRifleDamage,
                    NormalRange = ShearRifleNormalRange,
                    MaximumRange = ShearRifleMaxRange,
                    Cost = ShearRifleCost,
                    Magazine = ShearRifleMagazine,
                    Attribute = ShearRifleAttribute,
                    Encumbrance = ShearRifleEncumbrance,
                    TechLevel = ShearRifleTL,
                    IsHeavy = ShearRifleIsHeavy
                },
                new RangedWeapon
                {
                    Name = ThunderGunName,
                    Description = ThunderGunDescription,
                    AmmoType = ThunderGunAmmoType,
                    Damage = ThunderGunDamage,
                    NormalRange = ThunderGunNormalRange,
                    MaximumRange = ThunderGunMaxRange,
                    Cost = ThunderGunCost,
                    Magazine = ThunderGunMagazine,
                    Attribute = ThunderGunAttribute,
                    Encumbrance = ThunderGunEncumbrance,
                    TechLevel = ThunderGunTL,
                    IsHeavy = ThunderGunIsHeavy
                },
                new RangedWeapon
                {
                    Name = DistortionCannonName,
                    Description = DistortionCannonDescription,
                    AmmoType = DistortionCannonAmmoType,
                    Damage = DistortionCannonDamage,
                    NormalRange = DistortionCannonNormalRange,
                    MaximumRange = DistortionCannonMaxRange,
                    Cost = DistortionCannonCost,
                    Magazine = DistortionCannonMagazine,
                    Attribute = DistortionCannonAttribute,
                    Encumbrance = DistortionCannonEncumbrance,
                    TechLevel = DistortionCannonTL,
                    IsHeavy = DistortionCannonIsHeavy
                },
                new RangedWeapon
                {
                    Name = HeavyMachineGunName,
                    Description = HeavyMachineGunDescription,
                    AmmoType = HeavyMachineGunAmmoType,
                    Damage = HeavyMachineGunDamage,
                    NormalRange = HeavyMachineGunNormalRange,
                    MaximumRange = HeavyMachineGunMaxRange,
                    Cost = HeavyMachineGunCost,
                    Magazine = HeavyMachineGunMagazine,
                    Attribute = HeavyMachineGunAttribute,
                    Encumbrance = HeavyMachineGunEncumbrance,
                    TechLevel = HeavyMachineGunTL,
                    IsHeavy = HeavyMachineGunIsHeavy
                },
                new RangedWeapon
                {
                    Name = RocketLauncherName,
                    Description = RocketLauncherDescription,
                    AmmoType = RocketLauncherAmmoType,
                    Damage = RocketLauncherDamage,
                    NormalRange = RocketLauncherNormalRange,
                    MaximumRange = RocketLauncherMaxRange,
                    Cost = RocketLauncherCost,
                    Magazine = RocketLauncherMagazine,
                    Attribute = RocketLauncherAttribute,
                    Encumbrance = RocketLauncherEncumbrance,
                    TechLevel = RocketLauncherTL,
                    IsHeavy = RocketLauncherIsHeavy
                },
                new RangedWeapon
                {
                    Name = DemoChargeName,
                    Description = DemoChargeDescription,
                    AmmoType = DemoChargeAmmoType,
                    Damage = DemoChargeDamage,
                    NormalRange = DemoChargeNormalRange,
                    MaximumRange = DemoChargeMaxRange,
                    Cost = DemoChargeCost,
                    Magazine = DemoChargeMagazine,
                    Attribute = DemoChargeAttribute,
                    Encumbrance = DemoChargeEncumbrance,
                    TechLevel = DemoChargeTL,
                    IsHeavy = DemoChargeIsHeavy
                },
                new RangedWeapon
                {
                    Name = RailgunName,
                    Description = RailgunDescription,
                    AmmoType = RailgunAmmoType,
                    Damage = RailgunDamage,
                    NormalRange = RailgunNormalRange,
                    MaximumRange = RailgunMaxRange,
                    Cost = RailgunCost,
                    Magazine = RailgunMagazine,
                    Attribute = RailgunAttribute,
                    Encumbrance = RailgunEncumbrance,
                    TechLevel = RailgunTL,
                    IsHeavy = RailgunIsHeavy
                },
                new RangedWeapon
                {
                    Name = AntiVehicleLaserName,
                    Description = AntiVehicleLaserDescription,
                    AmmoType = AntiVehicleLaserAmmoType,
                    Damage = AntiVehicleLaserDamage,
                    NormalRange = AntiVehicleLaserNormalRange,
                    MaximumRange = AntiVehicleLaserMaxRange,
                    Cost = AntiVehicleLaserCost,
                    Magazine = AntiVehicleLaserMagazine,
                    Attribute = AntiVehicleLaserAttribute,
                    Encumbrance = AntiVehicleLaserEncumbrance,
                    TechLevel = AntiVehicleLaserTL,
                    IsHeavy = AntiVehicleLaserIsHeavy
                },
                new RangedWeapon
                {
                    Name = HydraArrayName,
                    Description = HydraArrayDescription,
                    AmmoType = HydraArrayAmmoType,
                    Damage = HydraArrayDamage,
                    NormalRange = HydraArrayNormalRange,
                    MaximumRange = HydraArrayMaxRange,
                    Cost = HydraArrayCost,
                    Magazine = HydraArrayMagazine,
                    Attribute = HydraArrayAttribute,
                    Encumbrance = HydraArrayEncumbrance,
                    TechLevel = HydraArrayTL,
                    IsHeavy = HydraArrayIsHeavy
                },
                new RangedWeapon
                {
                    Name = WheatcutterBeltName,
                    Description = WheatcutterBeltDescription,
                    AmmoType = WheatcutterBeltAmmoType,
                    Damage = WheatcutterBeltDamage,
                    NormalRange = WheatcutterBeltNormalRange,
                    MaximumRange = WheatcutterBeltMaxRange,
                    Cost = WheatcutterBeltCost,
                    Magazine = WheatcutterBeltMagazine,
                    Attribute = WheatcutterBeltAttribute,
                    Encumbrance = WheatcutterBeltEncumbrance,
                    TechLevel = WheatcutterBeltTL,
                    IsHeavy = WheatcutterBeltIsHeavy
                },
                new RangedWeapon
                {
                    Name = VortexCannonName,
                    Description = VortexCannonDescription,
                    AmmoType = VortexCannonAmmoType,
                    Damage = VortexCannonDamage,
                    NormalRange = VortexCannonNormalRange,
                    MaximumRange = VortexCannonMaxRange,
                    Cost = VortexCannonCost,
                    Magazine = VortexCannonMagazine,
                    Attribute = VortexCannonAttribute,
                    Encumbrance = VortexCannonEncumbrance,
                    TechLevel = VortexCannonTL,
                    IsHeavy = VortexCannonIsHeavy
                }
            });

            data.SaveChanges();
        }
    }
}
