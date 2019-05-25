using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NuoSoon.DataContext.Migrations
{
    public partial class vli1000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessRecord",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    IP = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    CountryCode = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    RegionName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Lat = table.Column<string>(nullable: true),
                    Lon = table.Column<string>(nullable: true),
                    Timezone = table.Column<string>(nullable: true),
                    ISP = table.Column<string>(nullable: true),
                    ORG = table.Column<string>(nullable: true),
                    AS = table.Column<string>(nullable: true),
                    Reverse = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Proxy = table.Column<string>(nullable: true),
                    Query = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Browser = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    LayoutEngine = table.Column<string>(nullable: true),
                    Platform = table.Column<string>(nullable: true),
                    UserAgent = table.Column<string>(nullable: true),
                    UserLanguages = table.Column<string>(nullable: true),
                    HttpMethod = table.Column<string>(nullable: true),
                    AccessFrom = table.Column<string>(nullable: true),
                    AccessTo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GBDistrictCode",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GBDistrictCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GBIndustrie",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Version = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GBIndustrie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupRight",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    RightId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupRight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleRight",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    RightId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleRight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemGroup",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    GropuName = table.Column<string>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemLog",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    Thread = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    Logger = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Exception = table.Column<string>(nullable: true),
                    Operator = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemNavigation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    SimpleName = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: false),
                    ControllerName = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    ChannelId = table.Column<int>(nullable: false),
                    IsSystem = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    IsInnerSite = table.Column<bool>(nullable: false),
                    IconUrl = table.Column<string>(nullable: true),
                    Target = table.Column<string>(nullable: true),
                    Parameter = table.Column<string>(nullable: true),
                    CreateIP = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(maxLength: 255, nullable: true),
                    Layer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemNavigation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemParameter",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Keyword = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemParameter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemPermission",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    GrantType = table.Column<string>(nullable: true),
                    GrantItem = table.Column<string>(nullable: false),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemPermission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemRight",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    GrantType = table.Column<string>(nullable: true),
                    GrantItem = table.Column<string>(nullable: false),
                    Desc = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemRight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemRole",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    RoleName = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemUser",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Pwd = table.Column<string>(nullable: false),
                    RealName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    IsLock = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRight",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    RightId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessRecord");

            migrationBuilder.DropTable(
                name: "GBDistrictCode");

            migrationBuilder.DropTable(
                name: "GBIndustrie");

            migrationBuilder.DropTable(
                name: "GroupRight");

            migrationBuilder.DropTable(
                name: "RoleRight");

            migrationBuilder.DropTable(
                name: "SystemGroup");

            migrationBuilder.DropTable(
                name: "SystemLog");

            migrationBuilder.DropTable(
                name: "SystemNavigation");

            migrationBuilder.DropTable(
                name: "SystemParameter");

            migrationBuilder.DropTable(
                name: "SystemPermission");

            migrationBuilder.DropTable(
                name: "SystemRight");

            migrationBuilder.DropTable(
                name: "SystemRole");

            migrationBuilder.DropTable(
                name: "SystemUser");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.DropTable(
                name: "UserRight");

            migrationBuilder.DropTable(
                name: "UserRole");
        }
    }
}
