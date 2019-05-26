using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NuoSoon.DataContext.Migrations
{
    public partial class vli1002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Navigation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    IdParent = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    SimpleName = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: false),
                    ControllerName = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    IdChannel = table.Column<int>(nullable: false),
                    IsSys = table.Column<bool>(nullable: false),
                    IsLock = table.Column<bool>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    IsInnerSite = table.Column<bool>(nullable: false),
                    IconUrl = table.Column<string>(nullable: true),
                    Target = table.Column<string>(nullable: true),
                    Parameter = table.Column<string>(nullable: true),
                    CreateIP = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(maxLength: 255, nullable: true),
                    Layer = table.Column<int>(nullable: false),
                    Actions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Navigation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Navigation");
        }
    }
}
