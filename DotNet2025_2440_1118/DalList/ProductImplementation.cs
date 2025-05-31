
namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;
using System.Reflection;
using Tools;
internal class ProductImplementation : IProduct
{
    //public int Create(Product item)
    //{
    //    Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"product {item.Id} create");
    //    Product product = item with { Id = DataSource.Config.ProductCode };
    //    DataSource.products.Add(product);
    //    return product.Id;
    //}
    public int Create(Product item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + item.Id.ToString());
        Product product = item with { Id = DataSource.Config.ProductCode };
        DataSource.products.Add(product);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Product addition successful");
        return product.Id;
    }
    //public void Delete(int id)
    //{
    //    try
    //    {
    //        Product p = Read(id);
    //        if (p != null)
    //        {
    //            DataSource.products.Remove(p);
    //        }
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"product {id} read");
    //    }
    //    catch
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete product dont happend");
    //        throw new DalIdNotExist("this id is not exist");
    //    }
    //}
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + id);
        Product product = Read(id);
        DataSource.products.Remove(product);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Product deleted successfully");
    }
    //public Product? Read(int id)
    //{
    //    try
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "product readhpend");
    //        Product products = DataSource.products.FirstOrDefault(x => x.Id == id);
    //        if (products != null)
    //            return products;
    //    }
    //    catch
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "product dont read");
    //        throw new DalIdNotExist("this id is not exist");
    //    }
    //    return null;
    //}
    public Product? Read(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + id);

        foreach (Product item in DataSource.products)
        {
            if (item.Id == id)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "\"Product readed successful\"\r\n");
                return item;
            }
        }
        throw new DalIdNotExist("not found!");
    }
    //public Product? Read(Func<Product, bool>? filter = null)
    //{
    //    try
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "product read");
    //        Product products = DataSource.products.FirstOrDefault(x => filter(x));
    //        if (products != null)
    //            return products;
    //    }
    //    catch
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "product dont readhpend");
    //        throw new DalIdNotExist("this id is not exist");
    //    }
    //    return null;
    //}

    public Product? Read(Func<Product, bool>? filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Product read successful");
        Product product = DataSource.products.FirstOrDefault(c => filter(c));
        if (product == null)
            throw new DalIdNotExist("The product does not exist");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Product read successful");
        return product;
    }

    public List<Product> ReadAll(Func<Product, bool> filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Products were read successfully");
        if (filter == null)
        {
            return new List<Product>(DataSource.products);
        }
        else
        {
            return DataSource.products.Where(filter).ToList();
        }
    }


    //public void Update(Product item)
    //{
    //    try
    //    {
    //        Delete(item.Id);
    //        DataSource.products.Add(item);
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"product {item.Id} update");
    //    }
    //    catch
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"product {item.Id} dont succeed to update");
    //        throw new Exception("this id is not exist");
    //    }
    //}
    public void Update(Product item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + item.Id.ToString());
        Delete(item.Id);
        DataSource.products.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Product updated successfully");
    }
}
