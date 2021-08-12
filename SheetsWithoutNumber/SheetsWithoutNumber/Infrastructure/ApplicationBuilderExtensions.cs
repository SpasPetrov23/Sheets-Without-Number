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

            return app;
        }

        private static void MigrateDatabase(IServiceProvider services)
        {

            var data = services.GetRequiredService<SWNDbContext>();

            //data.Database.EnsureDeleted();
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
    }
}
