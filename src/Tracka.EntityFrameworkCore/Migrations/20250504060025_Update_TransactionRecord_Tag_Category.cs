using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tracka.Migrations
{
    /// <inheritdoc />
    public partial class Update_TransactionRecord_Tag_Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TransactionRecordTags",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "TransactionRecordTags",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "TransactionRecords",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TransactionRecordCategorys",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "TransactionRecordCategorys",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TransactionRecordTags");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TransactionRecordTags");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TransactionRecords");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TransactionRecordCategorys");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TransactionRecordCategorys");
        }
    }
}
