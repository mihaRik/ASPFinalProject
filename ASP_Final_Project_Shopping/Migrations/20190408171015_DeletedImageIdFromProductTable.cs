using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Final_Project_Shopping.Migrations
{
    public partial class DeletedImageIdFromProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ba5fbc67-e6a5-47bc-b579-e4fd41c4cf07", "e7fb5998-0e89-407f-9704-91a9b7bf41ae" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bc210233-aee5-45fd-99bf-80c66cbcfbeb", "85a67dec-c05d-47b6-810f-1d4e70db25da" });

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a7bbf40-1c11-4d5b-bf4f-f28932e3cb52", "4362ad25-0c66-4f58-93b7-4c131bfa1272", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eb29d037-10ce-44ef-878f-7204953258b2", "b219e73a-a0ff-45b1-b73f-ab9c6981ab32", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4a7bbf40-1c11-4d5b-bf4f-f28932e3cb52", "4362ad25-0c66-4f58-93b7-4c131bfa1272" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "eb29d037-10ce-44ef-878f-7204953258b2", "b219e73a-a0ff-45b1-b73f-ab9c6981ab32" });

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba5fbc67-e6a5-47bc-b579-e4fd41c4cf07", "e7fb5998-0e89-407f-9704-91a9b7bf41ae", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc210233-aee5-45fd-99bf-80c66cbcfbeb", "85a67dec-c05d-47b6-810f-1d4e70db25da", "Member", "MEMBER" });
        }
    }
}
