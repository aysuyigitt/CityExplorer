using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityExplorer.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_city_citydetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "CityDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CityDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "CityDetails");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CityDetails");
        }
    }
}
