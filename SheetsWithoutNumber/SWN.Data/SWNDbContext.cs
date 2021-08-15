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

        public DbSet<Character> Characters { get; set; }

        public DbSet<Skill> Skills { get; init; }

        public DbSet<Equipment> Equipments { get; init; }

        public DbSet<Armor> Armors { get; init; }

        public DbSet<MeleeWeapon> MeleeWeapons { get; init; }

        public DbSet<CharactersSkills> CharactersSkills { get; init; }

        public DbSet<CharactersFoci> CharactersFoci { get; init; }

        public DbSet<CharactersEquipments> CharactersEquipments { get; init; }

        public DbSet<CharactersArmors> CharactersArmors { get; init; }

        public DbSet<CharactersMeleeWeapons> CharactersMeleeWeapons { get; init; }

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

            modelBuilder.Entity<CharactersSkills>()
                .HasOne<Character>(cs => cs.Character)
                .WithMany(c => c.CharactersSkills)
                .HasForeignKey(cs => cs.CharacterId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CharactersSkills>()
                .HasOne<Skill>(cs => cs.Skill)
                .WithMany(c => c.CharactersSkills)
                .HasForeignKey(cs => cs.SkillId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CharactersFoci>()
                .HasOne<Character>(cf => cf.Character)
                .WithMany(c => c.CharactersFoci)
                .HasForeignKey(cf => cf.CharacterId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CharactersFoci>()
                .HasOne<Focus>(cf => cf.Focus)
                .WithMany(c => c.CharactersFoci)
                .HasForeignKey(cf => cf.FocusId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CharactersEquipments>()
                .HasOne<Character>(ce => ce.Character)
                .WithMany(c => c.CharactersEquipments)
                .HasForeignKey(ce => ce.CharacterId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CharactersEquipments>()
                .HasOne<Equipment>(ce => ce.Equipment)
                .WithMany(e => e.CharactersEquipments)
                .HasForeignKey(ce => ce.EquipmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CharactersArmors>()
                .HasOne<Character>(ca => ca.Character)
                .WithMany(c => c.CharactersArmors)
                .HasForeignKey(ca => ca.CharacterId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CharactersArmors>()
                .HasOne<Armor>(ca => ca.Armor)
                .WithMany(a => a.CharactersArmors)
                .HasForeignKey(ca => ca.ArmorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CharactersMeleeWeapons>()
                .HasOne<Character>(cmw => cmw.Character)
                .WithMany(c => c.CharactersMeleeWeapons)
                .HasForeignKey(cmw => cmw.CharacterId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CharactersMeleeWeapons>()
                .HasOne<MeleeWeapon>(cmw => cmw.MeleeWeapon)
                .WithMany(mw => mw.CharactersMeleeWeapons)
                .HasForeignKey(cmw => cmw.MeleeWeaponId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
