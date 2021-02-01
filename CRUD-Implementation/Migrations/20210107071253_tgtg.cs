using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_Implementation.Migrations
{
    public partial class tgtg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "teacher",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teacher", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_student_teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "teacher",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "studeentcourse",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studeentcourse", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_studeentcourse_course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studeentcourse_student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "studentaddress",
                columns: table => new
                {
                    StudentAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentaddress", x => x.StudentAddressId);
                    table.ForeignKey(
                        name: "FK_studentaddress_student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_studeentcourse_CourseId",
                table: "studeentcourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_student_TeacherId",
                table: "student",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_studentaddress_StudentId",
                table: "studentaddress",
                column: "StudentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studeentcourse");

            migrationBuilder.DropTable(
                name: "studentaddress");

            migrationBuilder.DropTable(
                name: "course");

            migrationBuilder.DropTable(
                name: "student");

            migrationBuilder.DropTable(
                name: "teacher");
        }
    }
}
