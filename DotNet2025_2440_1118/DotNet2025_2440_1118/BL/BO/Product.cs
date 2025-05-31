using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        public List<SaleInProduct> SaleInProduct = new List<SaleInProduct>();

        public int Id { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }

        public override string ToString() => this.ToStringProperty();
        public Product(int id, string name, double price, int amount, Categories cat)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.InStock = amount;
            this.Category = cat;
            SaleInProduct = new List<SaleInProduct>();
        }
        public Product(string name, double price, int amount, Categories cat)
        {
            //this.Id = id;
            this.Name = name;
            this.Price = price;
            this.InStock = amount;
            this.Category = cat;
            SaleInProduct = new List<SaleInProduct>();
        }
        public Product()
        {
            this.Id = 0;
            this.Name = null;
            this.Price = 0;
            this.InStock = 0;
            this.Category =0;
            SaleInProduct = null;
        }
    }
}
