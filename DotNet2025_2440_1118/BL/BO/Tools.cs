using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal static class Tools
    {
        public static string ToStringProperty<T>(this T obj, string prefix = "")
        {
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                if (prop.PropertyType.IsPrimitive
                    || prop.PropertyType == typeof(string)
                    || prop.PropertyType == typeof(DateTime))
                    sb.AppendLine($"{prefix}{prop.Name} = {prop.GetValue(obj)}");
                else
                    sb.Append($"{prefix}{prop.Name} = \n{prop.GetValue(obj).ToStringProperty(prefix + "\t")}");
            }

            return sb.ToString();
        }
        public static DO.Client Convert(this BO.Client c)
        {
            return new DO.Client(c.Id, c.Name, c.Address, c.Phone);
        }
        public static DO.Product Convert(this BO.Product c)
        {
            return new DO.Product(c.Id, c.Name, (DO.Categories)(c.Category), (double)(c.Price), c.InStock);
        }
        public static DO.Sale Convert(this BO.Sale c)
        {
            return new DO.Sale(c.Id, (int)c.ProductId, c.RequiredAmount, c.SalePrice, (bool)c.IsForClubMembers, (DateTime)c.StartDate, (DateTime)c.EndDate);
        }
        public static BO.Client Convert(this DO.Client c)
        {
            return new BO.Client(c.Id, c.Name, c.Address, c.Phone);
        }
        public static BO.Product Convert(this DO.Product c)
        {
            return new BO.Product(c.Barcode,c.Name, c.Price, c.AmountOfStack, (BO.Categories)(c.Category));
        }
        public static BO.Sale Convert(this DO.Sale c)
        {
            return new BO.Sale( c.Id,c.ProductId,c.RequiredAmount, c.SalePrice, c.IsForClubMembers, c.StartDate, c.EndDate);
        }
        public static DO.Client ConvertBOcustomerToDOcustomer(this BO.Client customer)
        {
            return new DO.Client(customer.Id, customer.Name, customer.Address, customer.Phone);
        }
        public static DO.Product ConvertBOproductToDOproduct(this BO.Product product)
        {
            return new DO.Product(product.Id, product.Name, (DO.Categories)product.Category, product.Price, product.InStock);
        }
        public static DO.Sale ConvertBOsaleToDOsale(this BO.Sale sale)
        {
            return new DO.Sale(sale.Id, sale.ProductId, sale.RequiredAmount, sale.SalePrice, sale.IsForClubMembers, sale.StartDate, sale.EndDate);
        }



        public static BO.Client ConvertDOcustomerToBOcustomer(this DO.Client customer)
        {
            return new BO.Client(customer.Id, customer.Name, customer.Address, customer.Phone);
        }
        public static BO.Product ConvertDOproductToBOproduct(this DO.Product product)
        {
            return new BO.Product(product.Barcode, product.Name, product.Price, product.AmountOfStack, (BO.Categories)product.Category);
        }
        public static BO.Sale ConvertDOsaleToBOsale(this DO.Sale sale)
        {
            return new BO.Sale(sale.Id, sale.Id, sale.RequiredAmount, sale.SalePrice, sale.IsForClubMembers, sale.StartDate, sale.EndDate);
        }

    }
}
