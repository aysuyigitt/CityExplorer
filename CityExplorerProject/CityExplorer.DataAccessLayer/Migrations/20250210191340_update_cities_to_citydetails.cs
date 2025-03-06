using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityExplorer.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class update_cities_to_citydetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Cities_CityID1",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CityID1",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CityID1",
                table: "Cities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityID1",
                table: "Cities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CityID1",
                table: "Cities",
                column: "CityID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Cities_CityID1",
                table: "Cities",
                column: "CityID1",
                principalTable: "Cities",
                principalColumn: "CityID");
        }
    }
}
