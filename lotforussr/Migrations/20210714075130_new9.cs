using Microsoft.EntityFrameworkCore.Migrations;

namespace lotforussr.Migrations
{
    public partial class new9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "bidusername",
                table: "Histories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bidusername",
                table: "Histories");
        }
    }
}
