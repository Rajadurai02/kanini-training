using Microsoft.EntityFrameworkCore.Migrations;

namespace EFStudentApplication.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfJoining = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfJoining", "Name" },
                values: new object[] { 101, "13-08-2021", "Arun" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfJoining", "Name" },
                values: new object[] { 103, "13-08-2021", "Ajay" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfJoining", "Name" },
                values: new object[] { 104, "13-08-2021", "Ashok" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
