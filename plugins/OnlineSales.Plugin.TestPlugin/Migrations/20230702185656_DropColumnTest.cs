﻿// <auto-generated />
using Microsoft.EntityFrameworkCore.Migrations;
using OnlineSales.Plugin.TestPlugin.TestData;

#nullable disable

namespace OnlineSales.Plugin.TestPlugin.Migrations
{
    /// <inheritdoc />
    public partial class DropColumnTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: ChangeLogMigrationsTestData.AddedColumnName,
                table: "test_entity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // not needed
        }
    }
}