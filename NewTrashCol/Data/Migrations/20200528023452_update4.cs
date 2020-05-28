using Microsoft.EntityFrameworkCore.Migrations;

namespace NewTrashCol.Data.Migrations
{
    public partial class update4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "636cee22-c965-47b4-b1e6-4d73b200801e", "3ea0ae31-8c0f-4df0-9ded-96a2b63a5ba6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "613c5bb6-ca33-4ded-a995-1d2b60264168", "0a4788a9-21ad-434b-9ad4-acc83d8cdee3", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "613c5bb6-ca33-4ded-a995-1d2b60264168");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "636cee22-c965-47b4-b1e6-4d73b200801e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9a859c9-6fab-4f7f-88d1-6ba25218c760", "2702b647-3447-4ce3-9fdf-7174e66fa5c8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "658e073e-5300-492f-9ad9-a4e8bffa3b60", "73916449-dac9-4cba-abf6-cdc05acb2e2a", "Employee", "EMPLOYEE" });
        }
    }
}
