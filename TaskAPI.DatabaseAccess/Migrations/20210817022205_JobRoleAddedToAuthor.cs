using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DatabaseAccess.Migrations
{
    public partial class JobRoleAddedToAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobRole",
                table: "Authors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "JobRole",
                value: "Developer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "JobRole",
                value: "Cloud Assistant");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "JobRole",
                value: "Machanical Engineer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "JobRole",
                value: "Teacher");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 17, 7, 52, 4, 915, DateTimeKind.Local).AddTicks(4444), new DateTime(2021, 8, 22, 7, 52, 4, 916, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 17, 7, 52, 4, 916, DateTimeKind.Local).AddTicks(2090), new DateTime(2021, 8, 19, 7, 52, 4, 916, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 17, 7, 52, 4, 916, DateTimeKind.Local).AddTicks(2111), new DateTime(2021, 8, 18, 7, 52, 4, 916, DateTimeKind.Local).AddTicks(2112) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobRole",
                table: "Authors");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 16, 17, 32, 43, 206, DateTimeKind.Local).AddTicks(5824), new DateTime(2021, 8, 21, 17, 32, 43, 207, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 16, 17, 32, 43, 207, DateTimeKind.Local).AddTicks(4784), new DateTime(2021, 8, 18, 17, 32, 43, 207, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 16, 17, 32, 43, 207, DateTimeKind.Local).AddTicks(4805), new DateTime(2021, 8, 17, 17, 32, 43, 207, DateTimeKind.Local).AddTicks(4806) });
        }
    }
}
