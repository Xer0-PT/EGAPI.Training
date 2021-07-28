using Microsoft.EntityFrameworkCore.Migrations;

namespace Acme.BookStore.Store.Migrations
{
    public partial class AddedUpdateFlagStockToUpdateToPurchaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockToUpdate",
                table: "StorePurchases",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "UpdateFlag",
                table: "StorePurchases",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockToUpdate",
                table: "StorePurchases");

            migrationBuilder.DropColumn(
                name: "UpdateFlag",
                table: "StorePurchases");
        }
    }
}
