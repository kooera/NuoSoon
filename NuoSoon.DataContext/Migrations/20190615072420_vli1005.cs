using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NuoSoon.DataContext.Migrations
{
    public partial class vli1005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    SubTitle = table.Column<string>(maxLength: 150, nullable: true),
                    Summary = table.Column<string>(maxLength: 500, nullable: true),
                    Content = table.Column<string>(nullable: true),
                    SeoTitle = table.Column<string>(maxLength: 100, nullable: true),
                    SeoKeyword = table.Column<string>(maxLength: 200, nullable: true),
                    SeoDescription = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    ParentId = table.Column<long>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleComment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleComment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleExtend",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    ClickCount = table.Column<long>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    IsTop = table.Column<bool>(nullable: false),
                    IsHot = table.Column<bool>(nullable: false),
                    IsRecommend = table.Column<bool>(nullable: false),
                    IsFlash = table.Column<bool>(nullable: false),
                    IsHide = table.Column<bool>(nullable: false),
                    LikeCount = table.Column<int>(nullable: false),
                    Author = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleExtend", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticlePhoto",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    PhotoType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlePhoto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleRelation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    ArticleId = table.Column<long>(nullable: false),
                    RelationId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleRelation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleTag",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CreateId = table.Column<long>(nullable: false),
                    UpdateTime = table.Column<DateTime>(nullable: false),
                    UpdateId = table.Column<long>(nullable: false),
                    ArticleId = table.Column<long>(nullable: false),
                    TagName = table.Column<string>(maxLength: 20, nullable: true),
                    ClickCount = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTag", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "ArticleCategory");

            migrationBuilder.DropTable(
                name: "ArticleComment");

            migrationBuilder.DropTable(
                name: "ArticleExtend");

            migrationBuilder.DropTable(
                name: "ArticlePhoto");

            migrationBuilder.DropTable(
                name: "ArticleRelation");

            migrationBuilder.DropTable(
                name: "ArticleTag");
        }
    }
}
