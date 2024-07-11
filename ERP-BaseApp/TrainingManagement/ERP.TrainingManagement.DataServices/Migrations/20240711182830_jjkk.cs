using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ERP.TrainingManagement.DataServices.Migrations
{
    /// <inheritdoc />
    public partial class jjkk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("89885c30-945c-484b-bd78-49d45d92305b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("dc04ab4f-ec33-43a6-a05f-1b9c4eebe869"));

            migrationBuilder.AddColumn<string>(
                name: "Company_Person",
                table: "InternshipVacancies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "InternshipVacancies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5b742949-7234-4d42-b946-de4488932885"), null, "Coordinator", "COORDINATOR" },
                    { new Guid("f016c238-0ede-4ccb-9260-e3455f88dad5"), null, "Student", "STUDENT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5b742949-7234-4d42-b946-de4488932885"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f016c238-0ede-4ccb-9260-e3455f88dad5"));

            migrationBuilder.DropColumn(
                name: "Company_Person",
                table: "InternshipVacancies");

            migrationBuilder.DropColumn(
                name: "address",
                table: "InternshipVacancies");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("89885c30-945c-484b-bd78-49d45d92305b"), null, "Student", "STUDENT" },
                    { new Guid("dc04ab4f-ec33-43a6-a05f-1b9c4eebe869"), null, "Coordinator", "COORDINATOR" }
                });
        }
    }
}
