using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using BO;

namespace Bllmplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal dal = DalApi.Factory.Get;
        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int id, int count)
        {
            try
            {
                BO.Product p = dal.Product.Read(id).ConvertDOproductToBOproduct();
                BO.productInOrder product = order.ProductsOnOrder.FirstOrDefault(p => p.productId == id);
                if (product != null)
                {
                    if (count > p.AmountOfStack)
                        Console.WriteLine("there is not enough in the stock");
                    else
                    {
                        p.AmountOfStack = p.AmountOfStack - count;
                        order.ProductsOnOrder.Add(product);
                    }
                }
                else
                {
                    if (count > p.AmountOfStack)
                        Console.WriteLine("there is not enough in the stock");
                    else
                    {
                        product = new productInOrder(id, p.Name, (double)p.Price, count, p.Category);
                        SearchSaleForProduct(product, order.PreferredCustomer);
                        CalcTotalPriceForProduct(product);
                        CalcTotalPrice(order);
                        Console.WriteLine("the product added successfully");
                        return product.listSales;
                    }
                }
                return p.saleInProduct;
            }
            catch
            {

                throw new Exception("Error in ");


            }

        }
        public void CalcTotalPriceForProduct(BO.productInOrder productInOrder)
        {
            int count = productInOrder.count;
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
            productInOrder.TotalPrice = sum;
        }
        public void CalcTotalPrice(BO.Order order)

        {
            order.TotalPrice = order.productInOrder.Sum(p => p.finalPrice);
        }
        public void DoOrder(Order order)
        {
            var update = order.productInOrder.Select(p =>
            {
                var x = dal.Product.Read(p.productId);
                if (x.amount < p.count)
                    throw new Exception("אין מספיק מלאי למוצר");
                return x with { amount = x.amount - p.count };
            }).ToList();
            foreach (var x in update)
            {
                dal.Product.Update(x);
            }
        }
        public void SearchSaleForProduct(ProductInOrder p, bool favorite)
        {
            var sales = dal.Sale.ReadAll(s =>
               s.Code == p.productId &&
               s.StartSaleDate <= DateTime.Now &&
               DateTime.Now <= s.EndSaleDate &&
               p.count >= s.Count);
            if (!favorite)
                sales = sales.Where(s => s.Club == false).ToList();
            var sort = sales.OrderBy(s => s.Price).ToList();
            p.listSales = sort.Select(s => s.ConvertToSaleInProduct()).ToList();
        }
    }
}
