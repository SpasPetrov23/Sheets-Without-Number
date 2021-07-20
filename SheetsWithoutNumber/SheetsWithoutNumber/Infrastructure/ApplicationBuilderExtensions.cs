namespace SheetsWithoutNumber.Infrastructure
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using SWN.Data;
    using SWN.Data.Models;
    using System;
    using System.Linq;

    using static SWN.Data.DataConstants;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<SWNDbContext>();

            //data.Database.EnsureDeleted();
            data.Database.Migrate();

            SeedClasses(data);
            SeedBackgrounds(data);

            return app;
        }

        private static void SeedClasses(SWNDbContext data)
        {
            if (data.Classes.Any())
            {
                return;
            }

            data.Classes.AddRange(new[]
            {
                new Class
                {
                    Name = "Expert",
                    Ability = ClassExpertAbility,
                    Description = ClassExpertDescription,
                },
                new Class
                {
                    Name = "Warrior",
                    Ability = ClassWarriorAbility,
                    Description = ClassWarriorDescription,
                },
                new Class
                {
                    Name = "Psychic",
                    Ability = ClassPsychicAbility,
                    Description = ClassPsychicDescription,
                },
                new Class
                {
                    Name = "Adventurer (Expert + Psychic)",
                    Ability = ClassAdventurerAbilityExpertPsychic,
                    Description = ClassAdventurerDescription,
                },
                new Class
                {
                    Name = "Adventurer (Expert + Warrior)",
                    Ability = ClassAdventurerAbilityExpertWarrior,
                    Description = ClassAdventurerDescription,
                },
                new Class
                {
                    Name = "Adventurer (Psychic + Warrior)",
                    Ability = ClassAdventurerAbilityPsychicWarrior,
                    Description = ClassAdventurerDescription,
                }
            });

            data.SaveChanges();
        }

        private static void SeedBackgrounds(SWNDbContext data)
        {
            if (data.Backgrounds.Any())
            {
                return;
            }

            data.Backgrounds.AddRange(new[]
            {
                new Background
                {
                    Name = "Barbarian",
                    Description = BackgroundBarbarianDescription
                },
                new Background
                {
                    Name = "Clergy",
                    Description = BackgroundClergyDescription
                },
                new Background
                {
                    Name = "Courtesan",
                    Description = BackgroundCourtesanDescription
                },
                new Background
                {
                    Name = "Criminal",
                    Description = BackgroundCriminalDescription
                },
                new Background
                {
                    Name = "Dilettante",
                    Description = BackgroundDilettanteDescription
                },
                new Background
                {
                    Name = "Entertainer",
                    Description = BackgroundEntertainerDescription
                },
                new Background
                {
                    Name = "Merchant",
                    Description = BackgroundMerchantDescription
                },
                new Background
                {
                    Name = "Noble",
                    Description = BackgroundNobleDescription
                },
                new Background
                {
                    Name = "Official",
                    Description = BackgroundOfficialDescription
                },
                new Background
                {
                    Name = "Peasant",
                    Description = BackgroundPeasantDescription
                },
                new Background
                {
                    Name = "Physician",
                    Description = BackgroundPhysicianDescription
                },
                new Background
                {
                    Name = "Pilot",
                    Description = BackgroundPilotDescription
                },
                new Background
                {
                    Name = "Politician",
                    Description = BackgroundPoliticianDescription
                },
                new Background
                {
                    Name = "Scholar",
                    Description = BackgroundScholarDescription
                },
                new Background
                {
                    Name = "Soldier",
                    Description = BackgroundSoliderDescription
                },
                new Background
                {
                    Name = "Spacer",
                    Description = BackgroundSpacerDescription
                },
                new Background
                {
                    Name = "Technician",
                    Description = BackgroundTechnicianDescription
                },
                new Background
                {
                    Name = "Thug",
                    Description = BackgroundThugDescription
                },
                new Background
                {
                    Name = "Vagabond",
                    Description = BackgroundVagabondDescription
                },
                new Background
                {
                    Name = "Worker",
                    Description = BackgroundWorkerDescription
                }
            });

            data.SaveChanges();
        }
    }
}
