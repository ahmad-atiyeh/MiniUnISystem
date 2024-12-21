using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniUnISystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserType",
                table: "User",
                newName: "Discriminator");

            migrationBuilder.AddColumn<int>(
                name: "ExamId1",
                table: "ExamResults",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExamResults_ExamId1",
                table: "ExamResults",
                column: "ExamId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamResults_Exams_ExamId1",
                table: "ExamResults",
                column: "ExamId1",
                principalTable: "Exams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamResults_Exams_ExamId1",
                table: "ExamResults");

            migrationBuilder.DropIndex(
                name: "IX_ExamResults_ExamId1",
                table: "ExamResults");

            migrationBuilder.DropColumn(
                name: "ExamId1",
                table: "ExamResults");

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "User",
                newName: "UserType");
        }
    }
}
