using BlApi;
using BO;
using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class OrderImplementation:IOrder
    {
        private DalApi.IDal dal = DalApi.Factory.Get;
        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int id, int count)
        {
            try
            {
                BO.Product p = dal.Product.Read(id).Convert();
                BO.ProductInOrder product = order.productInOrder.FirstOrDefault(p => p.productId == id);
                if (product != null)
                {
                    if (count > p.InStock)
                        Console.WriteLine("there is not enough in the stock");
                    else
                    {
                        p.InStock = p.InStock - count;
                        order.productInOrder.Add(product);
                    }
                }
                else
                {
                    if (count > p.InStock)
                        Console.WriteLine("there is not enough in the stock");
                    else
                    {
                        product = new ProductInOrder(id, p.Name, (double)p.Price, count, p.Category);
                        SearchSaleForProduct(product, order.favorite);
                        CalcTotalPriceForProduct(product);
                        CalcTotalPrice(order);
                        Console.WriteLine("the product added successfully");
                        return product.listSales;
                    }
                }
                return p.SaleInProduct;
            }
            catch
            {

                throw new Exception("Error in ");


            }

        }
        public void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
        {
            int count = productInOrder.AmountOfOrder;
            double sum = 0;
            List<BO.SaleInProduct> sales = new List<BO.SaleInProduct>();
            foreach (var s in productInOrder.listSales)
            {
                if (count < s.count)
                    continue;
                int times = count / s.count;
                double price = s.price * times;
                sum += price;
                sales.Add(s);
                if (count == 0)
                    break;
            }
            sum += count * (productInOrder.basePrice ?? 0);
            productInOrder.listSales = sales;
            productInOrder.finalPrice = sum;
        }
        public void CalcTotalPrice(BO.Order order)

        {
            order.finalPrice = order.productInOrder.Sum(p => p.finalPrice);
        }
        public void DoOrder(Order order)
        {
            var update = order.productInOrder.Select(p =>
            {
                var x = dal.Product.Read(p.productId);
                if (x.InStock < p.AmountOfOrder)
                    throw new Exception("אין מספיק מלאי למוצר");
                return x with { InStock = x.InStock - p.AmountOfOrder };
            }).ToList();
            foreach (var x in update)
            {
                dal.Product.Update(x);
            }
        }
        public void SearchSaleForProduct(ProductInOrder product, bool isFavorite)
        {
            try
            {
                product.listSales = dal.Sale.ReadAll(s =>
                    s.ProductId == product.productId &&
                    s.StartDate <= DateTime.Now &&
                    s.EndDate >= DateTime.Now &&
                    product.AmountOfOrder >= s.RequiredAmount &&
                    (!s.IsForClubMembers || isFavorite))
                    .Select(s => new SaleInProduct
                    {
                        SaleId = s.Id,
                        count = s.RequiredAmount,
                        AllCustomers = !s.IsForClubMembers,
                        price = s.SalePrice
                    })
                    .OrderBy(s => s.price)
                    .ToList();
            }
            catch (Exception e)
            {
                throw new Exception("Failed to search sales for product", e);
            }
        }


    }
}
