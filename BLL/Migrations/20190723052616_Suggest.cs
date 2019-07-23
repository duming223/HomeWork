using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BLL.Migrations
{
    public partial class Suggest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    PassWord = table.Column<string>(nullable: true),
                    Integral = table.Column<int>(nullable: false),
                    EmailID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_Email_EmailID",
                        column: x => x.EmailID,
                        principalTable: "Email",
                        principalColumn: "EmailID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suggest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    AuthorID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suggest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suggest_User_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suggest_AuthorID",
                table: "Suggest",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_User_EmailID",
                table: "User",
                column: "EmailID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suggest");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Email");
        }
    }
}
