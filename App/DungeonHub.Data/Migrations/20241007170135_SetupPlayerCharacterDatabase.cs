using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonHub.Backend.Migrations
{
    /// <inheritdoc />
    public partial class SetupPlayerCharacterDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Race = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Background = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Class = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Subclass = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxHealth = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentHealth = table.Column<int>(type: "INTEGER", nullable: false),
                    TemporaryHealth = table.Column<int>(type: "INTEGER", nullable: false),
                    ArmorClass = table.Column<int>(type: "INTEGER", nullable: false),
                    Strength = table.Column<int>(type: "INTEGER", nullable: false),
                    Dexterity = table.Column<int>(type: "INTEGER", nullable: false),
                    Intelligence = table.Column<int>(type: "INTEGER", nullable: false),
                    Constitution = table.Column<int>(type: "INTEGER", nullable: false),
                    Wisdom = table.Column<int>(type: "INTEGER", nullable: false),
                    Charisma = table.Column<int>(type: "INTEGER", nullable: false),
                    Speed = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerCharacters", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerCharacters");
        }
    }
}
