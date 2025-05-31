
namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;
using System.Reflection;
using Tools;


internal class ClientImplementation : IClient
{
    //public int Create(Client item)
    //{

    //    bool e = DataSource.clients.Any(x => x.Id == item.Id);
    //    if (e)
    //        throw new DalIdAlreadyExist("this code already exists");
    //    else
    //        DataSource.clients.Add(item);
    //    Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"insert customer in id:{item.Id}");
    //    return item.Id;

    //}
    public int Create(Client item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + item.Id.ToString());

        foreach (Client i in DataSource.clients)
        {
            if (item.Id == i.Id)
            {
                throw new DalIdNotExist("Customer already exists");
            }
        }
        DataSource.clients.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customer addition successful");
        return item.Id;
    }

    //public void Delete(int id)
    //{
    //    try
    //    {
    //        Client c = Read(id);
    //        if (c != null)
    //        {
    //            DataSource.clients.Remove(c);
    //        }
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Dalrte customer in id:{id}");
    //    }
    //    catch
    //    {
    //        throw new DalIdNotExist("this id is not exist");
    //    }

    //}
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + id);
        Client c = Read(id);
        DataSource.clients.Remove(c);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customer deleted successfully");
    }

    //public Client? Read(Func<Client, bool> filter)
    //{
    //    try
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "readhpend");
    //        Client customer = DataSource.clients.FirstOrDefault(x => filter(x));
    //        if (customer != null)
    //            return customer;
    //    }
    //    catch
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read customer dont hpend");
    //        throw new DalIdNotExist("this id is not exist");
    //    }
    //    return null;
    //}
    public Client? Read(Func<Client, bool>? filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Customer read successfully");

        Client customer = DataSource.clients.FirstOrDefault(c => filter(c));
        if (customer == null)
            throw new DalIdNotExist("The customer is not exists");
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Customer read successfully");
        return customer;
    }
    //public Client? Read(int id)
    //{
    //    try
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"customer {id} read");
    //        Client customer = DataSource.clients.FirstOrDefault(x => x.Id == id);
    //        if (customer != null)
    //            return customer;
    //    }
    //    catch
    //    {
    //        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"customer {id} dont succeed read");
    //        throw new DalIdNotExist("this id is not exist");
    //    }
    //    return null;
    //}
    public Client? Read(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id:" + id.ToString());

        foreach (Client item in DataSource.clients)
        {
            if (item.Id == id)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customer read successfully");
                return item;
            }
        }
        throw new DalIdNotExist("not found!");
    }
    //public List<Client?> ReadAll(Func<Client, bool>? filter = null)
    //{
    //    Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"customer was readAll");
    //    if (filter == null)
    //        return new List<Client?>(DataSource.clients);
    //    else
    //    {
    //        var p = DataSource.clients.Where(x => filter(x));
    //        return p.ToList();
    //    }
    //}
    public List<Client> ReadAll(Func<Client, bool> filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customers were read successfully");
        if (filter == null)
        {
            return new List<Client>(DataSource.clients);
        }
        else
        {
            return DataSource.clients.Where(filter).ToList();
        }
    }

    //public void Update(Client item)
    //{
    //    Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"customer {item.Id} update");
    //    Delete(item.Id);
    //    DataSource.clients.Add(item);
    //}
    public void Update(Client item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "id: " + item.Id.ToString());

        Delete(item.Id);
        DataSource.clients.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().DeclaringType.Name, "Customer updated successfully");
    }
}
