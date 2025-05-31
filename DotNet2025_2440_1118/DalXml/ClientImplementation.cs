using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal class ClientImplementation:IClient
    {
        private static string filePath = @"../xml/clients.xml";

        const string CLIENT = "Client";
        const string CLIENT_ID = "ClientId";
        const string CLIENT_NAME = "ClientName";
        const string ADDRESS = "Address";
        const string PHONE = "Phone";

        public int Create(Client item)
        {

            XElement file = XElement.Load(filePath);
            object customer = file.Descendants(CLIENT).FirstOrDefault(c => int.Parse(c.Element(CLIENT_ID)?.Value) == (item.Id));
            if (customer != null)
                throw new NotImplementedException("Id Already Exists In Customers");

            file.Add(new XElement(CLIENT,
                        new XElement(CLIENT_ID, item.Id),
                        new XElement(CLIENT_NAME, item.Name),
                        new XElement(ADDRESS, item.Address),
                        new XElement(PHONE, item.Phone)));

            file.Save(filePath);
            return item.Id;
        }

        public Client Read(int id)
        {
            XElement file = XElement.Load(filePath);
            XElement customer = file.Descendants(CLIENT).FirstOrDefault(c => int.Parse(c.Element(CLIENT_ID).Value) == (id));
            if (customer == null)
                throw new NotImplementedException("Id Not Found In Customers");

            return new Client(int.Parse(customer.Element(CLIENT_ID).Value),
                                customer.Element(CLIENT_NAME).Value,
                                customer.Element(ADDRESS).Value,
                                customer.Element(PHONE).Value);
        }

        public Client? Read(Func<Client, bool> filter)
        {

            XElement file = XElement.Load(filePath);
            List<Client> customers = file.Descendants(CLIENT)
        .Select(c => new Client(
            int.Parse(c.Element(CLIENT_ID).Value)
            , c.Element(CLIENT_NAME).Value,
            c.Element(ADDRESS).Value,
            c.Element(PHONE).Value)).ToList();

            return customers.FirstOrDefault(filter);
            //Client customer = ReadAll().FirstOrDefault(filter);

            //if (customer == null)
            //    throw new NotImplementedException("Customer Not Found In Customers");

            //return customer;
        }

        public List<Client?> ReadAll(Func<Client, bool>? filter = null)
        {

            XElement file = XElement.Load(filePath);
            List<Client> customer = file.Descendants(CLIENT).Select(c => new Client
            (int.Parse(c.Element(CLIENT_ID).Value),
                 c.Element(CLIENT_NAME).Value,
                 c.Element(ADDRESS).Value,
                  c.Element(PHONE).Value)
                
            
            ).ToList();

            if (filter == null)
                return customer;

            return customer.Where(filter).ToList();

        }

        public void Update(Client item)
        {

            Delete(item.Id);
            XElement file = XElement.Load(filePath);

            file.Add(new XElement(CLIENT,
                new XElement(CLIENT_ID, item.Id),
            new XElement(CLIENT_NAME, item.Name),
            new XElement(ADDRESS, item.Address),
            new XElement(PHONE, item.Phone)));

            //Delete(item.Id);
            //Create(item);


            file.Save(filePath);

            //file.Save(filePath);
        }

        public void Delete(int id)
        {
            Read(id);

            XElement file = XElement.Load(filePath);

            file.Descendants(CLIENT_ID).First(x => int.Parse(x.Value) == (id))
            .Parent.Remove();

            file.Save(filePath);
        }
    }
}
