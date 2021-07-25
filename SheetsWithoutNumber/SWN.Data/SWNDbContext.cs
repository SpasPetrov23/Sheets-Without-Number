namespace SWN.Data
{
    using SWN.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;

    public class SWNDbContext : IdentityDbContext<User>
    {
        public SWNDbContext()
        {
        }

        public SWNDbContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<Game> Games { get; init; }

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
            //modelBuilder.Entity<Session>().HasKey(s => new { s.UserId, s.GameId });

            modelBuilder.Entity<Character>()
                .HasOne<Game>(c => c.Game)
                .WithMany(g => g.Characters)
                .HasForeignKey(c => c.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Character>()
                .HasOne<Background>(c => c.Background)
                .WithMany(b => b.Characters)
                .HasForeignKey(c => c.BackgroundId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Character>()
                .HasOne<Class>(@char => @char.Class)
                .WithMany(c => c.Characters)
                .HasForeignKey(@char => @char.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
