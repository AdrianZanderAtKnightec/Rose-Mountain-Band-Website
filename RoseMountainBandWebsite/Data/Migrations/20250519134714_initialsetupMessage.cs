using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoseMountainBandWebsite.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialsetupMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubmitterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmuitterEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmittedText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");
        }
    }
}
