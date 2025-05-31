using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal
{
    internal class SaleImplementation:ISale
    {
        private static string filePath = @"../xml/sales.xml";
        private XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        private List<Sale> sales;

        public int Create(Sale item)
        {

            //serializer = new XmlSerializer(typeof(List<Sale>));
            //    int index = Config.SaleCurrentCode;
            //    sales = ReadAll();
            //    sales.Add(new Sale(item.Id,item.ProductId,item.RequiredAmount,item.SalePrice,item.IsForClubMembers,item.StartDate,item.EndDate));
            //    using (StreamWriter sw = new StreamWriter(filePath))
            //    {
            //        serializer.Serialize(sw, sales);
            //    }
            //    return index;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            List<Sale> listSale;
            using (StreamReader sr = new StreamReader(filePath))
            {
                listSale = serializer.Deserialize(sr) as List<Sale>;
            }
            int code = Config.SaleCurrentCode;
            listSale.Add(item with { Id = code });
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, listSale);
            }
            return item.Id;
        }

        public Sale Read(int id)
        {

            //using (StreamReader sr = new StreamReader(filePath))
            //{
            //    sales = ReadAll();
            //    Sale sale = sales.FirstOrDefault(s => s.Id == id);
            //    if (sale == null)
            //        throw new NotImplementedException("Id Not Found In Sales");

            //    return sale;

            //}
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            List<Sale> listSale;
            using (StreamReader sr = new StreamReader(filePath))
            {
                listSale = serializer.Deserialize(sr) as List<Sale>;
            }
            return listSale.FirstOrDefault(sale => sale.Id == id);

        }

        public Sale? Read(Func<Sale, bool> filter)
        {

            //using (StreamReader sr = new StreamReader(filePath))
            //{
            //    //List<Sale> sales = serializer.Deserialize(sr) as List<Sale>;
            //    sales = ReadAll();
            //    Sale sale = sales.FirstOrDefault(filter);
            //    if (sale == null)
            //        throw new NotImplementedException("Sale Not Found In Sales");

            //    return sale;

            //}
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            List<Sale> listSale;
            using (StreamReader sr = new StreamReader(filePath))
            {
                listSale = serializer.Deserialize(sr) as List<Sale>;
            }
            return listSale.FirstOrDefault(filter);
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {

            //using (StreamReader sr = new StreamReader(filePath))
            //{
            //    sales = serializer.Deserialize(sr) as List<Sale>;
            //    if (filter == null)
            //        return sales;

            //    return sales.Where(filter).ToList();

            //}
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            List<Sale> listSale;
            using (StreamReader sr = new StreamReader(filePath))
            {
                listSale = serializer.Deserialize(sr) as List<Sale>;
            }
            if (filter != null)
                return listSale.Where(filter).ToList();
            return listSale;
        }

        public void Update(Sale item)
        {

            Delete(item.Id);
            //serializer = new XmlSerializer(typeof(List<Sale>));

            sales = ReadAll();
            sales.Add(new Sale(item.Id, item.ProductId, item.RequiredAmount, item.SalePrice, item.IsForClubMembers, item.StartDate, item.EndDate));

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, sales);
            }
            //Delete(item.Id);
            //Create(item);

        }

        public void Delete(int id)
        {

            //Sale curSale = Read(id);
            //DataSource.sales.Remove(curSale);

            //Sale curSale = Read(id);
            //sales = ReadAll();
            //sales.Remove(curSale);

            ////serializer = new XmlSerializer(typeof(List<Sale>));
            //using (StreamWriter sw = new StreamWriter(filePath))
            //{
            //    serializer.Serialize(sw, sales);
            //}
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            List<Sale> listSale;
            using (StreamReader sr = new StreamReader(filePath))
            {
                listSale = serializer.Deserialize(sr) as List<Sale>;
            }
            listSale.Remove(listSale.FirstOrDefault(sale => sale.Id == id));
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, listSale);
            }

        }
    }
}
