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

            data.Database.Migrate();

            SeedClasses(data);

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
                    Ability = string.Empty,
                    Description = string.Empty,
                },
                new Class 
                {
                    Name = "Psychic",
                    Ability = string.Empty,
                    Description = string.Empty,
                },
                new Class 
                {
                    Name = "Adventurer (Expert + Warrior)",
                    Ability = string.Empty,
                    Description = string.Empty,
                },
                new Class 
                {
                    Name = "Adventurer (Expert + Psychic)",
                    Ability = string.Empty,
                    Description = string.Empty,
                },
                new Class 
                {
                    Name = "Adventurer (Warrior + Psychic)",
                    Ability = string.Empty,
                    Description = string.Empty,
                }
            });

            data.SaveChanges();
        }
    }
}
