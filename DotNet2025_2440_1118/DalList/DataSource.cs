

using DalApi;

namespace Dal;
using DO;
internal static class DataSource
{
    internal static List<Sale?> sales = new List<Sale?>();
    internal static List<Client?> clients = new List<Client?>();
    internal static List<Product?> products = new List<Product?>();


    internal static class Config
    {
        internal const int MinCodeOfProduct = 100;
        internal const int MinCodeOfSale = 100;
        private static int ProductIndex = MinCodeOfProduct;
        private static int SaleIndex = MinCodeOfSale;
        public static int ProductCode
        {
            get
            {
                return ProductIndex++;
            }
        }
        public static int SaleCode
        {
            get
            {
                return SaleIndex++;
            }
        }
    }
}
