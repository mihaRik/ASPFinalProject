using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Final_Project_Shopping.Migrations
{
    public partial class SeedingDbWithRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cab5356e-7a7a-4d5e-8800-bb5ffd66e600", "2f85befd-5f52-4474-99ba-32871c10e40a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "34898f49-9c70-4bd1-ba1e-19f2291cdc53", "9a0da7a8-bafb-4b69-ae95-53eb56aa97a1", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "34898f49-9c70-4bd1-ba1e-19f2291cdc53", "9a0da7a8-bafb-4b69-ae95-53eb56aa97a1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cab5356e-7a7a-4d5e-8800-bb5ffd66e600", "2f85befd-5f52-4474-99ba-32871c10e40a" });
        }
    }
}
