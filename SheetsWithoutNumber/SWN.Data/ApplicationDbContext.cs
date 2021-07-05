namespace SWN.Data
{
    using Microsoft.EntityFrameworkCore;
    using SWN.Data.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<User> Users { get; init; }

        public DbSet<Game> Games { get; init; }

        public DbSet<UserRole> UserRoles { get; init; }

        public DbSet<Session> Sessions { get; init; }

        public DbSet<Character> Characters { get; init; }

        public DbSet<Skill> Skills { get; init; }

        public DbSet<Class> Classes { get; init; }

        public DbSet<Background> Backgrounds { get; init; }

        public DbSet<Focus> Foci { get; init; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-5O8U2TO;Database=SheetsWithoutNumber;Integrated Security = true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Session>().HasKey(s => new { s.UserId, s.GameId });

            modelBuilder.Entity<Session>()
                .HasOne<User>(s => s.User)
                .WithMany(u => u.Sessions)
                .HasForeignKey(s => s.UserId);

            modelBuilder.Entity<Session>()
                .HasOne<Game>(s => s.Game)
                .WithMany(g => g.Sessions)
                .HasForeignKey(s => s.GameId);

            modelBuilder.Entity<Session>()
                .HasOne<UserRole>(s => s.UserRole)
                .WithMany(ur => ur.Sessions)
                .HasForeignKey(s => s.UserRoleId);
        }
    }
}
