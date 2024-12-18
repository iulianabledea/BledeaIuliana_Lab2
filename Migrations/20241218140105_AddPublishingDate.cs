using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BledeaIuliana_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class AddPublishingDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PublishingDate",
                table: "Publisher",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishingDate",
                table: "Publisher");
        }
    }
}
