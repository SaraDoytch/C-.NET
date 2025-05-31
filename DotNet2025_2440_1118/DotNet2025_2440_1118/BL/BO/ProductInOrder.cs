

namespace BO
{
    public class ProductInOrder
    {
        public int productId { get; init; }
        public string? productName { get; init; }
        public double? basePrice { get; set; }
        public int AmountOfOrder { get; set; }
        public List<SaleInProduct> listSales { get; set; }
        public double finalPrice { get; set; }
        public Enum Enum { get; set; }
        public ProductInOrder()
        {
            productId = 0;
            productName = null;
            basePrice = 0;
            AmountOfOrder = 0;
            listSales = new List<SaleInProduct>();
            finalPrice = 0;

        }
        public ProductInOrder(int productId, string productName, double basePrice, int count,Enum @enum)
        {
            this.productId = productId;
            this.productName = productName;
            this.basePrice = basePrice;
            this.AmountOfOrder = count;
            listSales = new List<SaleInProduct>();
            Enum = @enum;
        }

        public object ToStringProperty()
        {
            throw new NotImplementedException();
        }
    }
}
