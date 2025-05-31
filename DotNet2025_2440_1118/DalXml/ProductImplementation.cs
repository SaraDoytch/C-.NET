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
    internal class ProductImplementation:IProduct
    {
        private static string filePath = @"../xml/products.xml";
        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        List<Product> products;
        public int Create(Product item)
        {

            //serializer = new XmlSerializer(typeof(List<Sale>));
            //int index = Config.ProductCurrentCode;
            //products = ReadAll();
            //products.Add(new Product(index,
            //                                item.Name,
            //                                item.Categoryies,
            //                                item.Price,
            //                                item.InStock));
            //using (StreamWriter sw = new StreamWriter(filePath))
            //{
            //    serializer.Serialize(sw, products);
            //}
            //return index;
        
            using (StreamReader sr = new StreamReader(filePath))
            {
                products = serializer.Deserialize(sr) as List<Product>;
            }
            if (item.Barcode == 0)
            {
                int code = Config.ProductCurrentCode;
                products.Add(item with { Barcode = code });
            }
            else
            {
                products.Add(item);
            }
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, products);
            }
            return item.Barcode;
        }

        public Product Read(int id)
        {

            //using (StreamReader sr = new StreamReader(filePath))
            //{
            //    products = ReadAll();
            //    Product product = products.FirstOrDefault(s => s.Id == id);
            //    if (product == null)
            //        throw new NotImplementedException("Id Not Found In Sales");

            //    return product;

            //}
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            List<Product> listProduct;
            using (StreamReader sr = new StreamReader(filePath))
            {
                listProduct = serializer.Deserialize(sr) as List<Product>;
            }
            return listProduct.FirstOrDefault(product => product.Barcode == id);

        }

        public Product? Read(Func<Product, bool> filter)
        {

            //using (StreamReader sr = new StreamReader(filePath))
            //{
            //    //List<Sale> sales = serializer.Deserialize(sr) as List<Sale>;
            //    products = ReadAll();
            //    Product product = products.FirstOrDefault(filter);
            //    if (product == null)
            //        throw new NotImplementedException("Sale Not Found In Sales");

            //    return product;
            //}

            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            List<Product> listProduct;
            using (StreamReader sr = new StreamReader(filePath))
            {
                listProduct = serializer.Deserialize(sr) as List<Product>;
            }
            return listProduct.FirstOrDefault(filter);
        }

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {

            //using (StreamReader sr = new StreamReader(filePath))
            //{
            //    products = serializer.Deserialize(sr) as List<Product>;
            //    if (filter == null)
            //        return products;

            //    return products.Where(filter).ToList();

            //}
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            //List<Product> listProduct;
            using (StreamReader sr = new StreamReader(filePath))
            {
                products = serializer.Deserialize(sr) as List<Product>;
            }
            if (filter != null)
                return products.Where(filter).ToList();
            return products;
        }

        public void Update(Product item)
        {
         
            Delete(item.Barcode);
            //serializer = new XmlSerializer(typeof(List<Sale>));

            products = ReadAll();
            products.Add(new Product(item.Barcode, item.Name, item.Category, item.Price, item.AmountOfStack));

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, products);
            }
            //Delete(item.Id);
            //Create(item);

        }

        public void Delete(int id)
        {

            ////Sale curSale = Read(id);
            ////DataSource.sales.Remove(curSale);

            //Product product = Read(id);
            //products = ReadAll();
            //products.Remove(product);

            ////serializer = new XmlSerializer(typeof(List<Sale>));
            //using (StreamWriter sw = new StreamWriter(filePath))
            //{
            //    serializer.Serialize(sw, products);
            //}
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            List<Product> listProduct;
            using (StreamReader sr = new StreamReader(filePath))
            {
                listProduct = serializer.Deserialize(sr) as List<Product>;
            }
            listProduct.Remove(listProduct.FirstOrDefault(product => product.Barcode == id));
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, listProduct);
            }
        }
        }
    }
