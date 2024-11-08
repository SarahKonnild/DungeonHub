using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonHub.Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddPlayerCharacterMetaData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PlayerCharacters",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "PlayerCharacters",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PlayerCharacters",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerCharacters_UserId",
                table: "PlayerCharacters",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerCharacters_AspNetUsers_UserId",
                table: "PlayerCharacters",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerCharacters_AspNetUsers_UserId",
                table: "PlayerCharacters");

            migrationBuilder.DropIndex(
                name: "IX_PlayerCharacters_UserId",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "PlayerCharacters");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PlayerCharacters");
        }
    }
}
