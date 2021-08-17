using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAPI.DatabaseAccess.Migrations
{
    public partial class AuthorEntityAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Lahiru Madushanka" },
                    { 2, "Manoshi Ramanayake" },
                    { 3, "Nansara Piyumal" },
                    { 4, "Nimal Premarathne" }
                });

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Created", "Due" },
                values: new object[] { 1, new DateTime(2021, 8, 16, 15, 15, 3, 981, DateTimeKind.Local).AddTicks(6141), new DateTime(2021, 8, 21, 15, 15, 3, 982, DateTimeKind.Local).AddTicks(829) });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 2, 1, new DateTime(2021, 8, 16, 15, 15, 3, 982, DateTimeKind.Local).AddTicks(2555), "Get vegetable for week", new DateTime(2021, 8, 18, 15, 15, 3, 982, DateTimeKind.Local).AddTicks(2563), 0, "Get vegetable" });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "AuthorId", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 3, 2, new DateTime(2021, 8, 16, 15, 15, 3, 982, DateTimeKind.Local).AddTicks(2575), "Water all the plants quickly", new DateTime(2021, 8, 17, 15, 15, 3, 982, DateTimeKind.Local).AddTicks(2576), 0, "Water the plants" });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Authors_AuthorId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Todos_AuthorId",
                table: "Todos");

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Due" },
                values: new object[] { new DateTime(2021, 8, 16, 11, 45, 3, 618, DateTimeKind.Local).AddTicks(6604), new DateTime(2021, 8, 21, 11, 45, 3, 619, DateTimeKind.Local).AddTicks(1167) });
        }
    }
}
