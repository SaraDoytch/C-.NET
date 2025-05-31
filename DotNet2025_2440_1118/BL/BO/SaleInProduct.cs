using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int SaleId  { get; init; }
        public int count { get; set; }
        public double price { get; set; }
        public bool AllCustomers { get; set; }
        public override string ToString() => this.ToStringProperty();

        public SaleInProduct(int SaleId, int count, double price, bool allClients)
        {
            this.SaleId = SaleId;
            this.count = count;
            this.price = price;
            this.AllCustomers = allClients;
        }
        public SaleInProduct()
        {
            SaleId = 0;
            count = 0;
            price = 0;
            AllCustomers = false;
        }
    }
}
