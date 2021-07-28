using Microsoft.EntityFrameworkCore.Migrations;

namespace Acme.BookStore.Store.Migrations
{
    public partial class AddedBookIdToPurchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StorePurchases_PBookId",
                table: "StorePurchases",
                column: "PBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_StorePurchases_StoreStoreBooks_PBookId",
                table: "StorePurchases",
                column: "PBookId",
                principalTable: "StoreStoreBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StorePurchases_StoreStoreBooks_PBookId",
                table: "StorePurchases");

            migrationBuilder.DropIndex(
                name: "IX_StorePurchases_PBookId",
                table: "StorePurchases");
        }
    }
}
