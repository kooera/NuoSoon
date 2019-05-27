using Microsoft.EntityFrameworkCore.Migrations;

namespace NuoSoon.DataContext.Migrations
{
    public partial class vli1004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "IdParent",
                table: "Navigation",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdParent",
                table: "Navigation",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
