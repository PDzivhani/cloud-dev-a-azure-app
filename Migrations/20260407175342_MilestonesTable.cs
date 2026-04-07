using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstAzureWebAppNet8.Migrations
{
    /// <inheritdoc />
    public partial class MilestonesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Milestones",
                columns: table => new
                {
                    milestoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    milestoneTitle = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    milestoneDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    milestoneCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateAchieved = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Milestones", x => x.milestoneId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Milestones");
        }
    }
}
