using Microsoft.EntityFrameworkCore.Migrations;

namespace lotforussr.Migrations
{
    public partial class new11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histories_Users_UserId",
                table: "Histories");

            migrationBuilder.DropIndex(
                name: "IX_Histories_UserId",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Histories");

            migrationBuilder.AddColumn<int>(
                name: "UserforbidId",
                table: "Histories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Histories_UserforbidId",
                table: "Histories",
                column: "UserforbidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_Users_UserforbidId",
                table: "Histories",
                column: "UserforbidId",
                principalTable: "Users",
                principalColumn: "Id"
              );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histories_Users_UserforbidId",
                table: "Histories");

            migrationBuilder.DropIndex(
                name: "IX_Histories_UserforbidId",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "UserforbidId",
                table: "Histories");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Histories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Histories_UserId",
                table: "Histories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_Users_UserId",
                table: "Histories",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id"
                );
        }
    }
}
