﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace lotforussr.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<bool>(
            //    name: "isreg",
            //    table: "Users",
            //    type: "bit",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.CreateTable(
            //    name: "lot",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Initialprice = table.Column<int>(type: "int", nullable: false),
            //        Finalprice = table.Column<int>(type: "int", nullable: true),
            //        History = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_lot", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_lot_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_lot_UserId",
            //    table: "lot",
            //    column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lot");

            migrationBuilder.DropColumn(
                name: "isreg",
                table: "Users");
        }
    }
}
