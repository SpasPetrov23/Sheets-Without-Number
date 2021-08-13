namespace SheetsWithoutNumber
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Services.Armor;
    using SheetsWithoutNumber.Services.Character;
    using SheetsWithoutNumber.Services.Equipments;
    using SheetsWithoutNumber.Services.Focus;
    using SheetsWithoutNumber.Services.Game;
    using SheetsWithoutNumber.Services.Skills;
    using SheetsWithoutNumber.Services.User;
    using SWN.Data;
    using SWN.Data.Models;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SWNDbContext>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services
                .AddDefaultIdentity<User>(options =>
                {
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.SignIn.RequireConfirmedEmail = true;
                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<SWNDbContext>();

            services
                .AddControllersWithViews(options => 
                    {
                        options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
                    })
                .AddRazorRuntimeCompilation();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Users/Login";
            });

            services.AddAutoMapper(typeof(Startup));

            services.AddTransient<ICharacterService, CharacterService>();
            services.AddTransient<IGameService, GameService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ISkillService, SkillService>();
            services.AddTransient<IFocusService, FocusService>();
            services.AddTransient<IEquipmentService, EquipmentService>();
            services.AddTransient<IArmorService, ArmorService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.PrepareDatabase();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app
                .UseHttpsRedirection()
                .UseStaticFiles()
                .UseRouting()
                .UseAuthentication()
                .UseAuthorization()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapRazorPages();
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                    endpoints.MapControllerRoute(
                        name: "areas",
                        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                });
        }
    }
}
