using Microsoft.EntityFrameworkCore.Migrations;

namespace NewTrashCol.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6ddd99f-fb5f-43f6-a57b-a6af49c5abf9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77e6b8d3-1165-40f0-817c-7d28a736b99a", "68a2b08b-386d-4992-805e-eaba926d1b0e", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77e6b8d3-1165-40f0-817c-7d28a736b99a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6ddd99f-fb5f-43f6-a57b-a6af49c5abf9", "68916f27-7d52-42f3-a7e1-34a0ca72249f", "Admin", "ADMIN" });
        }
    }
}
