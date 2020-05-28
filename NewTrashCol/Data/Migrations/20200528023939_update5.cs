using Microsoft.EntityFrameworkCore.Migrations;

namespace NewTrashCol.Data.Migrations
{
    public partial class update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "960a3fa4-4227-4077-b7e1-de3a5b454e6b", "343c3652-fe18-45b8-804e-67b5c25d0939", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe5308d0-b835-44d8-8e7f-9aecf58cb4ff", "293280fd-1fcb-42c6-9fcf-6103140acbc6", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "960a3fa4-4227-4077-b7e1-de3a5b454e6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe5308d0-b835-44d8-8e7f-9aecf58cb4ff");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "636cee22-c965-47b4-b1e6-4d73b200801e", "3ea0ae31-8c0f-4df0-9ded-96a2b63a5ba6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "613c5bb6-ca33-4ded-a995-1d2b60264168", "0a4788a9-21ad-434b-9ad4-acc83d8cdee3", "Employee", "EMPLOYEE" });
        }
    }
}
