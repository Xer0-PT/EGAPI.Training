namespace Acme.BookStore.Store
{
    public static class StoreDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Store";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Store";
    }
}
