﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Boxetheus.Migrations
{
    /// <inheritdoc />
    public partial class Color : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "BoxView",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "BoxView");
        }
    }
}
