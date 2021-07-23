﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SWN.Data;

namespace SWN.Data.Migrations
{
    [DbContext(typeof(SWNDbContext))]
    partial class SWNDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CharacterFocus", b =>
                {
                    b.Property<string>("CharactersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FociId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CharactersId", "FociId");

                    b.HasIndex("FociId");

                    b.ToTable("CharacterFocus");
                });

            modelBuilder.Entity("CharacterSkill", b =>
                {
                    b.Property<string>("CharactersId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SkillsId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CharactersId", "SkillsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("CharacterSkill");
                });

            modelBuilder.Entity("SWN.Data.Models.Background", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Backgrounds");
                });

            modelBuilder.Entity("SWN.Data.Models.Character", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ArmorClass")
                        .HasColumnType("int");

                    b.Property<int>("AttackBonus")
                        .HasColumnType("int");

                    b.Property<int>("BackgroundId")
                        .HasColumnType("int");

                    b.Property<string>("CharacterImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Charisma")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("Constitution")
                        .HasColumnType("int");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<int>("Effort")
                        .HasColumnType("int");

                    b.Property<string>("Encumbrance")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("Goal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HitPoints")
                        .HasColumnType("int");

                    b.Property<string>("Homeworld")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Initiative")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("MaxEffort")
                        .HasColumnType("int");

                    b.Property<int>("MaxHitPoints")
                        .HasColumnType("int");

                    b.Property<int>("MaxSystemStrain")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReadiedEncumbrance")
                        .HasColumnType("int");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("StowedEncumbrance")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int>("SystemStrain")
                        .HasColumnType("int");

                    b.Property<int>("UnspentSkillPoints")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Wisdom")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BackgroundId");

                    b.HasIndex("ClassId");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("SWN.Data.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ability")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("SWN.Data.Models.Focus", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Foci");
                });

            modelBuilder.Entity("SWN.Data.Models.Game", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("NextSession")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlayersMax")
                        .HasColumnType("int");

                    b.Property<int?>("SessionFrequency")
                        .HasColumnType("int");

                    b.Property<int>("SessionsCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("SWN.Data.Models.Session", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GameId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserRoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "GameId");

                    b.HasIndex("GameId");

                    b.HasIndex("UserRoleId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("SWN.Data.Models.Skill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPsychic")
                        .HasColumnType("bit");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("SWN.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SWN.Data.Models.UserRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("CharacterFocus", b =>
                {
                    b.HasOne("SWN.Data.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SWN.Data.Models.Focus", null)
                        .WithMany()
                        .HasForeignKey("FociId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CharacterSkill", b =>
                {
                    b.HasOne("SWN.Data.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SWN.Data.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SWN.Data.Models.Character", b =>
                {
                    b.HasOne("SWN.Data.Models.Background", "Background")
                        .WithMany("Characters")
                        .HasForeignKey("BackgroundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SWN.Data.Models.Class", "Class")
                        .WithMany("Characters")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SWN.Data.Models.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Background");

                    b.Navigation("Class");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SWN.Data.Models.Session", b =>
                {
                    b.HasOne("SWN.Data.Models.Game", "Game")
                        .WithMany("Sessions")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SWN.Data.Models.User", "User")
                        .WithMany("Sessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SWN.Data.Models.UserRole", "UserRole")
                        .WithMany("Sessions")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("SWN.Data.Models.Background", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("SWN.Data.Models.Class", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("SWN.Data.Models.Game", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("SWN.Data.Models.User", b =>
                {
                    b.Navigation("Characters");

                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("SWN.Data.Models.UserRole", b =>
                {
                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
