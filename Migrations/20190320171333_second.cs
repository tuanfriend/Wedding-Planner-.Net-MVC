using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingProj.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WedConnects_Userss_UserId",
                table: "WedConnects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Userss",
                table: "Userss");

            migrationBuilder.RenameTable(
                name: "Userss",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WedConnects_Users_UserId",
                table: "WedConnects",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WedConnects_Users_UserId",
                table: "WedConnects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Userss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Userss",
                table: "Userss",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WedConnects_Userss_UserId",
                table: "WedConnects",
                column: "UserId",
                principalTable: "Userss",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
