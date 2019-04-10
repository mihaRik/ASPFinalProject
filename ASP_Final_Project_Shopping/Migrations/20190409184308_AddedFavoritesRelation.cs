using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Final_Project_Shopping.Migrations
{
    public partial class AddedFavoritesRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "4a7bbf40-1c11-4d5b-bf4f-f28932e3cb52", "4362ad25-0c66-4f58-93b7-4c131bfa1272" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "eb29d037-10ce-44ef-878f-7204953258b2", "b219e73a-a0ff-45b1-b73f-ab9c6981ab32" });

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Products",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abacce28-e0d4-46da-b8ba-351c488d877c", "eac0d052-eda9-4bd1-a864-0f2acc2a89b1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba7d9afc-6a94-413e-95d3-ba659e432a33", "d9ad1ee8-4b93-4b4f-92de-1f874c6f7025", "Member", "MEMBER" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserId",
                table: "Products",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_AspNetUsers_UserId",
                table: "Products",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_AspNetUsers_UserId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_UserId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "abacce28-e0d4-46da-b8ba-351c488d877c", "eac0d052-eda9-4bd1-a864-0f2acc2a89b1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ba7d9afc-6a94-413e-95d3-ba659e432a33", "d9ad1ee8-4b93-4b4f-92de-1f874c6f7025" });

            migrationBuilder.DropColumn(
                name: "UserId",
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
    }
}
