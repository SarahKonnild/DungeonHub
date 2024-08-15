using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonHub.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCharacterClassesSubclassesAndFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Characters");

            migrationBuilder.AddColumn<Guid>(
                name: "ClassId",
                table: "Characters",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "CharacterClasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    HitDie = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSubclasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSubclasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 3000, nullable: false),
                    ClassId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SubclassId = table.Column<Guid>(type: "TEXT", nullable: true),
                    GainSubclassFeature = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsSubclassFeature = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Features_CharacterClasses_ClassId",
                        column: x => x.ClassId,
                        principalTable: "CharacterClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Features_CharacterSubclasses_SubclassId",
                        column: x => x.SubclassId,
                        principalTable: "CharacterSubclasses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ClassId",
                table: "Characters",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_ClassId",
                table: "Features",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_SubclassId",
                table: "Features",
                column: "SubclassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_CharacterClasses_ClassId",
                table: "Characters",
                column: "ClassId",
                principalTable: "CharacterClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_CharacterClasses_ClassId",
                table: "Characters");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "CharacterClasses");

            migrationBuilder.DropTable(
                name: "CharacterSubclasses");

            migrationBuilder.DropIndex(
                name: "IX_Characters_ClassId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "Class",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
