using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonHub.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddBasicCharacterDefinitions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbilityScores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Strength = table.Column<int>(type: "INTEGER", nullable: false),
                    Dexterity = table.Column<int>(type: "INTEGER", nullable: false),
                    Constitution = table.Column<int>(type: "INTEGER", nullable: false),
                    Intelligence = table.Column<int>(type: "INTEGER", nullable: false),
                    Wisdom = table.Column<int>(type: "INTEGER", nullable: false),
                    Charisma = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityScores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    AcrobaticsModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    AcrobaticsProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    AnimalHandlingModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    AnimalHandlingProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    ArcanaModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    ArcanaProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    AthleticsModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    AthleticsProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    DeceptionModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    DeceptionProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    HistoryModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    HistoryProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    InsightModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    InsightProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    IntimidationModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    IntimidationProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    InvestigationModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    InvestigationProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    MedicineModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicineProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    NatureModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    NatureProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    PerceptionModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    PerceptionProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    PerformanceModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    PerformanceProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    PersuasionModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    PersuasionProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    ReligionModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    ReligionProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    SleightOfHandModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    SleightOfHandProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    StealthModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    StealthProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    SurvivalModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    SurvivalProficient = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SavingThrows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    StrengthSaveModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    StrengthSaveProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    DexteritySaveModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    DexteritySaveProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    ConstitutionSaveModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    ConstitutionSaveProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    IntelligenceSaveModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    IntelligenceSaveProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    WisdomSaveModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    WisdomSaveProficient = table.Column<bool>(type: "INTEGER", nullable: false),
                    CharismaSaveModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    CharismaSaveProficient = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavingThrows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Class = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    ArmorClass = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxHitPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentHitPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    TemporaryHitPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    Initiative = table.Column<int>(type: "INTEGER", nullable: false),
                    Speed = table.Column<int>(type: "INTEGER", nullable: false),
                    DeathSaveFails = table.Column<int>(type: "INTEGER", nullable: false),
                    DeathSaveSuccesses = table.Column<int>(type: "INTEGER", nullable: false),
                    Inspiration = table.Column<bool>(type: "INTEGER", nullable: false),
                    ProficiencyBonus = table.Column<int>(type: "INTEGER", nullable: false),
                    SavingThrowsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AbilityScoresId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CharacterSkillsId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_AbilityScores_AbilityScoresId",
                        column: x => x.AbilityScoresId,
                        principalTable: "AbilityScores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_CharacterSkills_CharacterSkillsId",
                        column: x => x.CharacterSkillsId,
                        principalTable: "CharacterSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_SavingThrows_SavingThrowsId",
                        column: x => x.SavingThrowsId,
                        principalTable: "SavingThrows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AbilityScoresId",
                table: "Characters",
                column: "AbilityScoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterSkillsId",
                table: "Characters",
                column: "CharacterSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SavingThrowsId",
                table: "Characters",
                column: "SavingThrowsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "AbilityScores");

            migrationBuilder.DropTable(
                name: "CharacterSkills");

            migrationBuilder.DropTable(
                name: "SavingThrows");
        }
    }
}
