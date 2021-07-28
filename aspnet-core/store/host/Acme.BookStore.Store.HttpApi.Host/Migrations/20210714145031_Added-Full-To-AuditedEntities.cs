using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Acme.BookStore.Store.Migrations
{
    public partial class AddedFullToAuditedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "StorePurchases",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "StorePurchases",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StorePurchases",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "StoreBooks",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "StoreBooks",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StoreBooks",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "StorePurchases");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "StorePurchases");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StorePurchases");

            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "StoreBooks");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "StoreBooks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StoreBooks");
        }
    }
}
