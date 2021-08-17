using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DatabaseAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2021, 8, 16, 11, 45, 3, 618, DateTimeKind.Local).AddTicks(6604), "Get some text books for school", new DateTime(2021, 8, 21, 11, 45, 3, 619, DateTimeKind.Local).AddTicks(1167), 0, "Get books for School - DB " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
