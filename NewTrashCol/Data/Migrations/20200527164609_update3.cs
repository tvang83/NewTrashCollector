using Microsoft.EntityFrameworkCore.Migrations;

namespace NewTrashCol.Data.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ac0f1c9-ed00-4c9a-b50b-056d76cbe017");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9a859c9-6fab-4f7f-88d1-6ba25218c760", "2702b647-3447-4ce3-9fdf-7174e66fa5c8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "658e073e-5300-492f-9ad9-a4e8bffa3b60", "73916449-dac9-4cba-abf6-cdc05acb2e2a", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "658e073e-5300-492f-9ad9-a4e8bffa3b60");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9a859c9-6fab-4f7f-88d1-6ba25218c760");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7ac0f1c9-ed00-4c9a-b50b-056d76cbe017", "88c3edb8-de9e-46d2-bd74-7fccf69b4c69", "Admin", "ADMIN" });
        }
    }
}
