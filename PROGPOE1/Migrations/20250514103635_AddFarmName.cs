using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROGPOE1.Migrations
{
    /// <inheritdoc />
    public partial class AddFarmName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FarmName",
                table: "Farmers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Farmers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FarmName",
                table: "Farmers");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Farmers");
        }
    }
}
