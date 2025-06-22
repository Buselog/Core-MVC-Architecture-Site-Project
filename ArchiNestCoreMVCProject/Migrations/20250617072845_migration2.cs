using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArchiNestCoreMVCProject.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FıeldId",
                table: "Teams");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FıeldId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
