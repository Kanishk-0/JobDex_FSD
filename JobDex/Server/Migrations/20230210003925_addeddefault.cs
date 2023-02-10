using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobDex.Server.Migrations
{
    public partial class addeddefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StaffDetails",
                columns: new[] { "Id", "DateCreated", "StaffEmail", "StaffName", "StaffNo", "StaffPwd" },
                values: new object[] { 1, new DateTime(2023, 2, 10, 8, 39, 25, 201, DateTimeKind.Local).AddTicks(8559), "Jaake@gmail.com", "Jaake", 97814201, "Jake01" });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Id", "DateCreated", "UserAddress", "UserCStatus", "UserDOB", "UserEStatus", "UserEmail", "UserName", "UserNo", "UserPwd" },
                values: new object[] { 1, new DateTime(2023, 2, 10, 8, 39, 25, 200, DateTimeKind.Local).AddTicks(4230), "punggol", "PR", new DateTime(2004, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "employed", "Jake@gmail.com", "Jake", 97814201, "Jake01" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StaffDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
