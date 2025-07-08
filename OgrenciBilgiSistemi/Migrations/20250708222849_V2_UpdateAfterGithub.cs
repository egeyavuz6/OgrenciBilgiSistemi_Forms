using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgrenciBilgiSistemi.Migrations
{
    /// <inheritdoc />
    public partial class V2_UpdateAfterGithub : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Deger",
                table: "Notlar",
                newName: "Grades");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Ogrenciler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CourseId",
                table: "Notlar",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Credit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notlar_CourseId",
                table: "Notlar",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notlar_Courses_CourseId",
                table: "Notlar",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notlar_Courses_CourseId",
                table: "Notlar");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Notlar_CourseId",
                table: "Notlar");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Notlar");

            migrationBuilder.RenameColumn(
                name: "Grades",
                table: "Notlar",
                newName: "Deger");
        }
    }
}
