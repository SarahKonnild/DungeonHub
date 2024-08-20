﻿// <auto-generated />
using System;
using DungeonHub.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DungeonHub.Persistence.Migrations
{
    [DbContext(typeof(DungeonHubDbContext))]
    [Migration("20240815192622_AddCharacterClassesSubclassesAndFeatures")]
    partial class AddCharacterClassesSubclassesAndFeatures
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("DungeonHub.Backend.Models.AbilityScores", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Charisma")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Constitution")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Dexterity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Intelligence")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Wisdom")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("AbilityScores");
                });

            modelBuilder.Entity("DungeonHub.Backend.Models.Creature.Character.Character", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AbilityScoresId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ArmorClass")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("CharacterSkillsId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("TEXT");

                    b.Property<int>("CurrentHitPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeathSaveFails")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeathSaveSuccesses")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Initiative")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Inspiration")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxHitPoints")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<int>("ProficiencyBonus")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("SavingThrowsId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Speed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TemporaryHitPoints")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AbilityScoresId");

                    b.HasIndex("CharacterSkillsId");

                    b.HasIndex("ClassId");

                    b.HasIndex("SavingThrowsId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DungeonHub.Backend.Models.Creature.Character.CharacterClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("HitDie")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CharacterClasses");
                });

            modelBuilder.Entity("DungeonHub.Backend.Models.Creature.Character.CharacterSkills", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AcrobaticsModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AcrobaticsProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimalHandlingModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AnimalHandlingProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArcanaModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ArcanaProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AthleticsModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AthleticsProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeceptionModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DeceptionProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HistoryModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HistoryProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InsightModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("InsightProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IntimidationModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IntimidationProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InvestigationModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("InvestigationProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MedicineModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MedicineProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NatureModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("NatureProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PerceptionModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("PerceptionProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PerformanceModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("PerformanceProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersuasionModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("PersuasionProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ReligionModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ReligionProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SleightOfHandModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SleightOfHandProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StealthModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("StealthProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurvivalModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SurvivalProficient")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CharacterSkills");
                });

            modelBuilder.Entity("DungeonHub.Backend.Models.Creature.Character.CharacterSubclass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CharacterSubclasses");
                });

            modelBuilder.Entity("DungeonHub.Backend.Models.Creature.Character.Feature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("TEXT");

                    b.Property<bool>("GainSubclassFeature")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSubclassFeature")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("SubclassId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("SubclassId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("DungeonHub.Backend.Models.SavingThrows", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("CharismaSaveModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CharismaSaveProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConstitutionSaveModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ConstitutionSaveProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DexteritySaveModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DexteritySaveProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IntelligenceSaveModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IntelligenceSaveProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StrengthSaveModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("StrengthSaveProficient")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WisdomSaveModifier")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("WisdomSaveProficient")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SavingThrows");
                });

            modelBuilder.Entity("DungeonHub.Backend.Models.Creature.Character.Character", b =>
                {
                    b.HasOne("DungeonHub.Backend.Models.AbilityScores", "AbilityScores")
                        .WithMany()
                        .HasForeignKey("AbilityScoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DungeonHub.Backend.Models.Creature.Character.CharacterSkills", "CharacterSkills")
                        .WithMany()
                        .HasForeignKey("CharacterSkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DungeonHub.Backend.Models.Creature.Character.CharacterClass", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DungeonHub.Backend.Models.SavingThrows", "SavingThrows")
                        .WithMany()
                        .HasForeignKey("SavingThrowsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AbilityScores");

                    b.Navigation("CharacterSkills");

                    b.Navigation("Class");

                    b.Navigation("SavingThrows");
                });

            modelBuilder.Entity("DungeonHub.Backend.Models.Creature.Character.Feature", b =>
                {
                    b.HasOne("DungeonHub.Backend.Models.Creature.Character.CharacterClass", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DungeonHub.Backend.Models.Creature.Character.CharacterSubclass", "Subclass")
                        .WithMany()
                        .HasForeignKey("SubclassId");

                    b.Navigation("Class");

                    b.Navigation("Subclass");
                });
#pragma warning restore 612, 618
        }
    }
}