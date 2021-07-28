using Microsoft.EntityFrameworkCore.Migrations;

namespace Acme.BookStore.Store.Migrations
{
    public partial class ChangedBooksToStoreBooksInEFCoreStoreDbContextModelCreatingExtensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreBooks",
                table: "StoreBooks");

            migrationBuilder.RenameTable(
                name: "StoreBooks",
                newName: "StoreStoreBooks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreStoreBooks",
                table: "StoreStoreBooks",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreStoreBooks",
                table: "StoreStoreBooks");

            migrationBuilder.RenameTable(
                name: "StoreStoreBooks",
                newName: "StoreBooks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreBooks",
                table: "StoreBooks",
                column: "Id");
        }
    }
}
