using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment1_FrameWork.Migrations
{
    public partial class AddStud_Course : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stud_Course",
                columns: table => new
                {
                    stud_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Course", x => new { x.stud_ID, x.Course_ID });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stud_Course");
        }
    }
}
