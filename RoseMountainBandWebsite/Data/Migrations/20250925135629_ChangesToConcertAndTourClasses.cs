using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoseMountainBandWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangesToConcertAndTourClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Concert_Tour_TourId",
                table: "Concert");

            migrationBuilder.DropIndex(
                name: "IX_Concert_TourId",
                table: "Concert");

            migrationBuilder.AlterColumn<int>(
                name: "TourId",
                table: "Concert",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TourId",
                table: "Concert",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Concert_TourId",
                table: "Concert",
                column: "TourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Concert_Tour_TourId",
                table: "Concert",
                column: "TourId",
                principalTable: "Tour",
                principalColumn: "Id");
        }
    }
}
