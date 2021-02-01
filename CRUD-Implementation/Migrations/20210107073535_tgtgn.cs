using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_Implementation.Migrations
{
    public partial class tgtgn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_student_teacher_TeacherId",
                table: "student");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "student",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_student_teacher_TeacherId",
                table: "student",
                column: "TeacherId",
                principalTable: "teacher",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_student_teacher_TeacherId",
                table: "student");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_student_teacher_TeacherId",
                table: "student",
                column: "TeacherId",
                principalTable: "teacher",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
