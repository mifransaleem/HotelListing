using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b8732f4-63dc-4a82-b507-2458120bc722");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58930d31-7e48-4577-b467-4ae0de30d755");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "630f4422-f8b5-4db2-9204-ff1aee9a818a", "71c001f5-294c-43aa-b553-77f7750e8baf", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11ccbeb6-1370-45b8-8c17-fa6935bf1906", "9905e707-61d8-4c0f-a576-37db3b1f62f1", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11ccbeb6-1370-45b8-8c17-fa6935bf1906");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "630f4422-f8b5-4db2-9204-ff1aee9a818a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58930d31-7e48-4577-b467-4ae0de30d755", "e5b508e1-c6fb-4104-bccc-b132923ce772", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b8732f4-63dc-4a82-b507-2458120bc722", "81444645-6c44-4b23-a775-62be8f8b462f", "Administrator", "ADMINISTRATOR" });
        }
    }
}
