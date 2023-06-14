using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Examensarbete_Quiz.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Option1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Option2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Option3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Option4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectOption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserAge = table.Column<int>(type: "int", nullable: false),
                    UserGender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "CorrectOption", "Option1", "Option2", "Option3", "Option4", "Point", "QuestionText" },
                values: new object[,]
                {
                    { 1, "2", "1", "2", "3", "4", 0, "Vad är 1+1?" },
                    { 2, "4", "2", "4", "6", "8", 0, "Vad är 2+2?" },
                    { 3, "6", "3", "6", "9", "12", 0, "Vad är 3+3?" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "UserAge", "UserFirstName", "UserGender", "UserLastName" },
                values: new object[] { 1, 26, "Daniel", "Male", "Gyrén" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
