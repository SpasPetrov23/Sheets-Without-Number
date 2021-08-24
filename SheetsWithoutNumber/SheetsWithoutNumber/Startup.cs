namespace SheetsWithoutNumber
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using SheetsWithoutNumber.Infrastructure;
    using SheetsWithoutNumber.Services.Armor;
    using SheetsWithoutNumber.Services.Character;
    using SheetsWithoutNumber.Services.Equipments;
    using SheetsWithoutNumber.Services.Focus;
    using SheetsWithoutNumber.Services.Game;
    using SheetsWithoutNumber.Services.MeleeWeapon;
    using SheetsWithoutNumber.Services.RangedWeapon;
    using SheetsWithoutNumber.Services.Skill;
    using SheetsWithoutNumber.Services.User;
    using SWN.Data;
    using SWN.Data.Models;

    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SWNDbContext>(
                options => options.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection")));

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

            services.AddMemoryCache();

            services.AddTransient<ICharacterService, CharacterService>();
            services.AddTransient<IGameService, GameService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ISkillService, SkillService>();
            services.AddTransient<IFocusService, FocusService>();
            services.AddTransient<IEquipmentService, EquipmentService>();
            services.AddTransient<IArmorService, ArmorService>();
            services.AddTransient<IMeleeWeaponService, MeleeWeaponService>();
            services.AddTransient<IRangedWeaponService, RangedWeaponService>();
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

            app.UseStatusCodePagesWithReExecute("/Errors/Index", "?statusCode={0}");

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
                        name: "gameDetails",
                        pattern: "Games/Details/{id}/{information}",
                        defaults: new { controller = "Games", actions = "Details"});
                    endpoints.MapControllerRoute(
                        name: "areas",
                        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                });
        }
    }
}
