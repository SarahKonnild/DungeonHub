﻿// <auto-generated />
using DungeonHub.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DungeonHub.Persistence.Migrations
{
    [DbContext(typeof(DungeonHubDbContext))]
    [Migration("20240814192606_InitializeDatabase")]
    partial class InitializeDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");
#pragma warning restore 612, 618
        }
    }
}