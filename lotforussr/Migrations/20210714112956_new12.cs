using Microsoft.EntityFrameworkCore.Migrations;

namespace lotforussr.Migrations
{
    public partial class new12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<int>(
                name: "balance",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropColumn(
                name: "balance",
                table: "Users");

         
        }
    }
}
