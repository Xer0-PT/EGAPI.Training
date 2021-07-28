using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Acme.BookStore.Store.Migrations
{
    public partial class book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreBooks",
                table: "StoreBooks");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "StoreBooks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "StoreBooks",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "StoreBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "StoreBooks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "StoreBooks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "StoreBooks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "StoreBooks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreBooks",
                table: "StoreBooks",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreBooks",
                table: "StoreBooks");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StoreBooks");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "StoreBooks");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "StoreBooks");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "StoreBooks");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "StoreBooks");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "StoreBooks");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "StoreBooks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreBooks",
                table: "StoreBooks",
                column: "BookId");
        }
    }
}
