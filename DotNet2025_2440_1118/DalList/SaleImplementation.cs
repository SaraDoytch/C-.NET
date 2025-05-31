
namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;
using Tools;
using System.Reflection;
internal class SaleImplementation : ISale
{
    //public int Create(Sale item)
    //{
    //    Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"sale {item.Id} create");
    //    Sale sale = item with { Id = DataSource.Config.SaleCode };
    //    DataSource.sales.Add(sale);
    //    return sale.Id;
    //}
    public int Create(Sale item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, item.Id.ToString());
        Sale p = item with { Id = DataSource.Config.SaleCode };

        DataSource.sales.Add(p);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale created successful");
        return p.Id;
    }


    //public void Delete(int id)
    //{
    //    try
    //    {   
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"product {id} deleted");
    //        Sale s = Read(id);
    //        if (s != null)
    //        {
    //            DataSource.sales.Remove(s);
    //        }
    //    }
    //    catch
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"product {id} dont deleted");
    //        throw new DalIdNotExist("this id is not exist");
    //    }
    //}
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + id);
        Sale s = Read(id);
        DataSource.sales.Remove(s);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale deleted successful");
    }
    //public Sale? Read(int id)
    //{
    //    try
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"product {id} read");
    //        Sale sale = DataSource.sales.FirstOrDefault(x => x.Id == id);
    //        if (sale != null)
    //            return sale;
    //    }
    //    catch
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"product {id} dont read");
    //        throw new DalIdNotExist("this id is not exist");
    //    }
    //    return null;
    //}
    public Sale? Read(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + id);
        foreach (Sale item in DataSource.sales)
        {
            if (item.Id == id)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale read successfully");
                return item;
            }
        }
        throw new DalIdNotExist("not found!");
    }

    //public Sale? Read(Func<Sale, bool>? filter = null)
    //{
    //    try
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"product read");
    //        Sale sale = DataSource.sales.FirstOrDefault(x => filter(x));
    //        if (sale != null) return sale;
    //    }
    //    catch
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"product dont read");
    //        throw new DalIdNotExist("this id is not exist");
    //    }
    //    return null;
    //}
    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "sale read successfully");
        Sale sale = DataSource.sales.FirstOrDefault(c => filter(c));
        if (sale == null)
            throw new DalIdNotExist("The sale is not exists");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "sale read successfully");
        return sale;
    }

    //public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
    //{
    //    Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"product dont readAll");
    //    if (filter == null)
    //        return new List<Sale>(DataSource.sales);
    //    return DataSource.sales.Where(x => filter(x)).ToList();
    //}
    public List<Sale> ReadAll(Func<Sale, bool> filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sales read successfully");
        if (filter == null)
        {
            return new List<Sale>(DataSource.sales);
        }
        else
        {
            return DataSource.sales.Where(filter).ToList();
        }
    }
    //    public void Update(Sale item)
    //    {
    //        
    //        //LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    //        //                      MethodBase.GetCurrentMethod().Name,
    //        //                      "sale updated successfully");

    //        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    //                              MethodBase.GetCurrentMethod().Name,
    //                              "id: " + item.Id);

    //        int index = DataSource.sales.FindIndex(s => s.Id == item.Id);
    //        if (index == -1)
    //            throw new Exception("מבצע לא נמצא");

    //        DataSource.sales[index] = item;

    //        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    //                              MethodBase.GetCurrentMethod().Name,
    //                              "sale updated successfully");


    //}

    public void Update(Sale item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");
        Sale? Sale = DataSource.sales.FirstOrDefault(c => c.Id == item.Id);
        if (Sale == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, " sale not found");
            throw new DalIdNotExist("sale not found");
        }
        DataSource.sales.Remove(Sale);
        DataSource.sales.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale" + item.ToString());
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");

        //    LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
        //                          MethodBase.GetCurrentMethod().Name,
        //                          "id: " + item.Id);

        //    Sale existing = DataSource.sales.FirstOrDefault(s => s.Id == item.Id);
        //    if (existing == null)
        //        throw new Exception("מבצע לא קיים");

        //    // עדכון השדות בלבד
        //    existing.ProductId = item.ProductId;
        //    existing.RequiredAmount = item.RequiredAmount;
        //    existing.SalePrice = item.SalePrice;
        //    existing.IsForClubMembers = item.IsForClubMembers;
        //    existing.StartDate = item.StartDate;
        //    existing.EndDate = item.EndDate;

        //    LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
        //                          MethodBase.GetCurrentMethod().Name,
        //                          "sale updated successfully");
        //}

        //public void Update(Sale item)
        //{
        //    LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + item.Id.ToString());
        //    Delete(item.Id);
        //    DataSource.sales.Add(item);
        //    LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "sale created successful");
    }
}

