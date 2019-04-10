using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Final_Project_Shopping.Migrations
{
    public partial class AddedProductAndImageTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "cc9a8a99-c8ee-4e98-acc5-5e495e1fb4b3", "e24c8e6f-095f-4ba7-9ade-1cc612a7d8e1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "dda7c0e1-9296-4a5b-80e6-413ccc7dad38", "a7aae5be-1ea1-4356-ab0b-22764d496586" });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    SalePrice = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    OnSale = table.Column<bool>(nullable: false),
                    ReviewCount = table.Column<int>(nullable: false),
                    ReviewAverage = table.Column<double>(nullable: false),
                    Department = table.Column<string>(maxLength: 100, nullable: true),
                    Class = table.Column<string>(maxLength: 100, nullable: true),
                    SubClass = table.Column<string>(maxLength: 100, nullable: true),
                    Color = table.Column<string>(maxLength: 100, nullable: true),
                    Weight = table.Column<string>(maxLength: 100, nullable: true),
                    ImageId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FromServer = table.Column<bool>(nullable: false),
                    ImageUrl = table.Column<string>(maxLength: 300, nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba5fbc67-e6a5-47bc-b579-e4fd41c4cf07", "e7fb5998-0e89-407f-9704-91a9b7bf41ae", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc210233-aee5-45fd-99bf-80c66cbcfbeb", "85a67dec-c05d-47b6-810f-1d4e70db25da", "Member", "MEMBER" });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ba5fbc67-e6a5-47bc-b579-e4fd41c4cf07", "e7fb5998-0e89-407f-9704-91a9b7bf41ae" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "bc210233-aee5-45fd-99bf-80c66cbcfbeb", "85a67dec-c05d-47b6-810f-1d4e70db25da" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dda7c0e1-9296-4a5b-80e6-413ccc7dad38", "a7aae5be-1ea1-4356-ab0b-22764d496586", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc9a8a99-c8ee-4e98-acc5-5e495e1fb4b3", "e24c8e6f-095f-4ba7-9ade-1cc612a7d8e1", "Member", "MEMBER" });
        }
    }
}
