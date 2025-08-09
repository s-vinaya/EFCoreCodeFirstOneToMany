using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFMVCLastDayPractise.Migrations
{
    /// <inheritdoc />
    public partial class AddLocationToHotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Hotels");
        }
    }
}
