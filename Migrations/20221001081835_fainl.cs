using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanySystem.Migrations
{
    public partial class fainl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PageSection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageSection", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PageSection",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsDeleted", "ModifiedBy", "ModifiedOn", "OrderNumber", "Title" },
                values: new object[] { 1, "Musab", new DateTime(2022, 10, 1, 11, 18, 34, 881, DateTimeKind.Local).AddTicks(2265), "First Description", false, "SALAH", new DateTime(2022, 10, 1, 11, 18, 34, 881, DateTimeKind.Local).AddTicks(2297), 0, "Musab" });

            migrationBuilder.InsertData(
                table: "PageSection",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "IsDeleted", "ModifiedBy", "ModifiedOn", "OrderNumber", "Title" },
                values: new object[] { 2, "Musab", new DateTime(2022, 10, 1, 11, 18, 34, 881, DateTimeKind.Local).AddTicks(2300), "First Description", true, "SALAH", new DateTime(2022, 10, 1, 11, 18, 34, 881, DateTimeKind.Local).AddTicks(2303), 0, "test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PageSection");
        }
    }
}
