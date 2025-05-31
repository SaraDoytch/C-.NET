using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool favorite { get; set; }
        public List<ProductInOrder> productInOrder { get; set; }
        public double finalPrice { get; set; }
        public override string ToString() => this.ToStringProperty();
        public Order(bool PreferredCustomer, List<ProductInOrder> ProductList, double TotalPrice)
        {
            this.favorite = PreferredCustomer;
            this.productInOrder = ProductList;
            this.finalPrice = TotalPrice;
        }
        public Order()
        {
            favorite = false;
            productInOrder = new List<ProductInOrder>();
            finalPrice = 0;
        }
        public Order(bool favorite1)
        {
            favorite = favorite1;
            productInOrder = new List<ProductInOrder>();
            finalPrice = 0;
        }
    }
}
