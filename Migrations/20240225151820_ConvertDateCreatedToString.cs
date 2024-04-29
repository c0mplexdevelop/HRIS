using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS.Migrations
{
    /// <inheritdoc />
    public partial class ConvertDateCreatedToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateCreated",
                table: "AccessCodes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateCreated",
                table: "AccessCodes",
                type: "date",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");
        }
    }
}
