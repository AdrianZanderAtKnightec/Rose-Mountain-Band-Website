using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoseMountainBandWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubmuitterEmail",
                table: "Message",
                newName: "SubmitterEmail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubmitterEmail",
                table: "Message",
                newName: "SubmuitterEmail");
        }
    }
}
