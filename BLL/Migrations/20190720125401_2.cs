using Microsoft.EntityFrameworkCore.Migrations;

namespace BLL.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailID",
                table: "users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    EmailID = table.Column<string>(nullable: false),
                    IsActivate = table.Column<bool>(nullable: false),
                    Code = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.EmailID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_EmailID",
                table: "users",
                column: "EmailID");

            migrationBuilder.AddForeignKey(
                name: "FK_users_Email_EmailID",
                table: "users",
                column: "EmailID",
                principalTable: "Email",
                principalColumn: "EmailID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_Email_EmailID",
                table: "users");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropIndex(
                name: "IX_users_EmailID",
                table: "users");

            migrationBuilder.DropColumn(
                name: "EmailID",
                table: "users");
        }
    }
}
