using Microsoft.EntityFrameworkCore.Migrations;

namespace lotforussr.Migrations
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histories_Lots_lotId",
                table: "Histories");

            migrationBuilder.DropForeignKey(
                name: "FK_Histories_Users_userId",
                table: "Histories");

            migrationBuilder.DropIndex(
                name: "IX_Histories_userId",
                table: "Histories");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Histories");

            migrationBuilder.RenameColumn(
                name: "lotId",
                table: "Histories",
                newName: "LotId");

            migrationBuilder.RenameIndex(
                name: "IX_Histories_lotId",
                table: "Histories",
                newName: "IX_Histories_LotId");

            migrationBuilder.AlterColumn<int>(
                name: "LotId",
                table: "Histories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_Lots_LotId",
                table: "Histories",
                column: "LotId",
                principalTable: "Lots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Histories_Lots_LotId",
                table: "Histories");

            migrationBuilder.RenameColumn(
                name: "LotId",
                table: "Histories",
                newName: "lotId");

            migrationBuilder.RenameIndex(
                name: "IX_Histories_LotId",
                table: "Histories",
                newName: "IX_Histories_lotId");

            migrationBuilder.AlterColumn<int>(
                name: "lotId",
                table: "Histories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Histories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Histories_userId",
                table: "Histories",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_Lots_lotId",
                table: "Histories",
                column: "lotId",
                principalTable: "Lots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Histories_Users_userId",
                table: "Histories",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
