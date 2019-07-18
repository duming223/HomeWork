using Microsoft.EntityFrameworkCore.Migrations;

namespace BLL.Migrations
{
    public partial class integral : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Integral",
                table: "users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Integral",
                table: "users");
        }
    }
}
