using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Final_Project_Shopping.Migrations
{
    public partial class AddedCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "34898f49-9c70-4bd1-ba1e-19f2291cdc53", "9a0da7a8-bafb-4b69-ae95-53eb56aa97a1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cab5356e-7a7a-4d5e-8800-bb5ffd66e600", "2f85befd-5f52-4474-99ba-32871c10e40a" });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    APICategoryId = table.Column<string>(maxLength: 100, nullable: true),
                    CategoryName = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dda7c0e1-9296-4a5b-80e6-413ccc7dad38", "a7aae5be-1ea1-4356-ab0b-22764d496586", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc9a8a99-c8ee-4e98-acc5-5e495e1fb4b3", "e24c8e6f-095f-4ba7-9ade-1cc612a7d8e1", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cc9a8a99-c8ee-4e98-acc5-5e495e1fb4b3", "e24c8e6f-095f-4ba7-9ade-1cc612a7d8e1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "dda7c0e1-9296-4a5b-80e6-413ccc7dad38", "a7aae5be-1ea1-4356-ab0b-22764d496586" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cab5356e-7a7a-4d5e-8800-bb5ffd66e600", "2f85befd-5f52-4474-99ba-32871c10e40a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "34898f49-9c70-4bd1-ba1e-19f2291cdc53", "9a0da7a8-bafb-4b69-ae95-53eb56aa97a1", "Member", "MEMBER" });
        }
    }
}
