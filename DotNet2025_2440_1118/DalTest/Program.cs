using DalApi;
using DO;
using System.Numerics;
using System.Reflection;
using Tools;
namespace DalTest
{
    internal class Program
    {
        public delegate void CreateUpdateDel();


        private static readonly IDal s_dal = DalApi.Factory.Get;
        //new DalList1()
        private static void PrintMenu()
        {
            int select = 1;
            while (select > 0)
            {
                try
                {
                    Console.WriteLine("select:");
                    Console.WriteLine("for client press 1");
                    Console.WriteLine("for product press 2");
                    Console.WriteLine("for sale press 3");
                    Console.WriteLine("to delete a log folder press 4");
                    Console.WriteLine("to exit press 0");
                    if (!int.TryParse(Console.ReadLine(), out select))
                        select = -1;
                    switch (select)
                    {
                        case 0:
                            Console.WriteLine("exit");
                            break;
                        case 1:
                            //ClientMenu();
                            SubMenu<Client>("Client", s_dal.Client, AddClient, updateClient);
                            break;
                        case 2:
                            //ProductMenu();
                            SubMenu<Product>("product", s_dal.Product, AddProduct, updateProduct);
                            break;
                        case 3:
                            //SaleMenu(); 
                            SubMenu<Sale>("Sale", s_dal.Sale, AddSale, updateSale);
                            break;
                        case 4:
                            //SaleMenu(); 
                            LogManager.Delete();
                            break;
                        default:
                            Console.WriteLine("press again");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        private static int printSubMenu(string s)
        {
            int select = 1;
            Console.WriteLine($"to add {s} press 1");
            Console.WriteLine($"to read {s} press 2");
            Console.WriteLine($"to read all {s}es press 3");
            Console.WriteLine($"to update {s} press 4");
            Console.WriteLine($"to delete {s} press 5");
            Console.WriteLine($"to go back press 0");
            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;
            return select;

        }
        public static void ReadAll<T>(ICrud<T> crud)
        {
            //Console.WriteLine(crud.ReadAll().Count());
            foreach (var item in crud.ReadAll())
            {
                Console.WriteLine(item);
            }
        }
        public static void Read<T>(ICrud<T> crud)
        {
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(crud.Read(id));
        }

        public static void updateClient()
        {
            try
            {
                int code = -1;
                Console.WriteLine("enter code");
                int.TryParse(Console.ReadLine(), out code);

                Console.WriteLine(s_dal.Client.Read(code));
                Client c = DrawClient(code);
                s_dal.Client.Update(c);
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);

                Console.WriteLine(ex.Message);
            }
        }
        public static void updateSale()
        {
            try
            {
                int code = -1;
                Console.WriteLine("enter code");
                int.TryParse(Console.ReadLine(), out code);

                Console.WriteLine(s_dal.Sale.Read(code));
                Sale s = DrawSale(code);
                s_dal.Sale.Update(s);
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);

                Console.WriteLine(ex.Message);
            }
        }
        public static void updateProduct()
        {
            try
            {
                int code = -1;
                Console.WriteLine("enter code");
                int.TryParse(Console.ReadLine(), out code);
                Console.WriteLine(s_dal.Product.Read(code));
                Product p = DrawProdut(code);
                s_dal.Product.Update(p);
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);

                Console.WriteLine(ex.Message);
            }
        }
        public static Client DrawClient(int code = 0)
        {
            int Id;
            string Name;
            string Address;
            string Phone;
            Console.WriteLine("enter id");
            if (!int.TryParse(Console.ReadLine(), out Id))
                Id = 100;
            Console.WriteLine("enter name");
            Name = Console.ReadLine();
            Console.WriteLine("enter adress");
            Address = Console.ReadLine();
            Console.WriteLine("enter phoneNumber");
            Phone = Console.ReadLine();

            return new Client(Id, Name, Address, Phone);
        }


        public static Product DrawProdut(int code = 0)
        {
            int Id;
            string Name;
            Categories Category;
            double Price;
            int InStock;
            int select;
            int cat;
            Console.WriteLine("enter Barcode");
            if (!int.TryParse(Console.ReadLine(), out Id))
                Id = 100;
            Console.WriteLine("enter name");
            Name = Console.ReadLine();
            Console.WriteLine("enter category between 0-3");
            if (!int.TryParse(Console.ReadLine(), out cat))
                Category = 0;
            else
                Category = (Categories)cat;
            Console.WriteLine("enter price");
            Price = int.Parse(Console.ReadLine());
            Console.WriteLine("enter AmountOfStock");
            if (!int.TryParse(Console.ReadLine(), out InStock))
                InStock = 0;
            return new Product(Id, Name, Category, Price, InStock);

            return new Product();
        }
        public static void AddSale()
        {
            Sale sale = DrawSale();
            int code = s_dal.Sale.Create(sale);
            sale = sale with { Id = code };
            Console.WriteLine("sale create in successfully!!");
            Console.WriteLine(sale);

        }
        public static void AddProduct()
        {
            Product p = DrawProdut();
            int code = s_dal.Product.Create(p);
            p = p with { Id = code };
            Console.WriteLine("product create in successfully!!");
            Console.WriteLine(p);

        }
        public static void AddClient()
        {
            Client c = DrawClient();
            int code = s_dal.Client.Create(c);
            c = c with { Id = code };
            Console.WriteLine("client create in successfully!!");
            Console.WriteLine(c);

        }
        public static void Delete<T>(ICrud<T> crud)
        {
            try
            {
                Console.WriteLine("enter code");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine(crud.Read(code));
                crud.Delete(code);
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);

                Console.WriteLine(ex.Message);
            }

        }

        public static Sale DrawSale(int code = 0)
        {
            int Id;
            int ProductId;
            int AdAmount_product;
            double Total_Price;
            bool Promotion_Sale;
            DateTime Start_Date;
            DateTime End_Date;
            int select;
            Console.WriteLine("enter Unique_Id");
            if (!int.TryParse(Console.ReadLine(), out Id))
                Id = 100;
            Console.WriteLine("enter Id");
            if (!int.TryParse(Console.ReadLine(), out ProductId))
                ProductId = 100;
            Console.WriteLine("enter AdAmount_product");
            if (!int.TryParse(Console.ReadLine(), out AdAmount_product))
                AdAmount_product = 100;
            Console.WriteLine("enter Total_Price");
            if (!double.TryParse(Console.ReadLine(), out Total_Price))
                Total_Price = 0;
            Console.WriteLine("enter for who the sale(0/1)");
            if (!int.TryParse(Console.ReadLine(), out select))
                select = 1;
            Promotion_Sale = select == 1;
            Console.WriteLine("enter start date of the sale!");
            if (!int.TryParse(Console.ReadLine(), out select))
                select = 0;
            Start_Date = DateTime.Now.AddDays(select);
            Console.WriteLine("enter end  date of the sale!");
            if (!int.TryParse(Console.ReadLine(), out select))
                select = 0;
            End_Date = Start_Date.AddDays(select);

            return new Sale(Id, ProductId, AdAmount_product, Total_Price, Promotion_Sale, Start_Date, End_Date);
        }

        private static Product SubMenu<T>(string item, ICrud<T> crud, CreateUpdateDel createDel, CreateUpdateDel updateDel)
        {
            int select = printSubMenu(item);
            while (select > 0)
            {

                switch (select)
                {
                    case 0:
                        PrintMenu();
                        break;
                    case 1:
                        createDel();
                        break;
                    case 2:
                        Read<T>(crud);
                        break;
                    case 3:
                        ReadAll<T>(crud);
                        break;
                    case 4:
                        updateDel();
                        break;
                    case 5:
                        Delete<T>(crud);
                        break;
                    default:
                        Console.WriteLine("הקשה שגויה");
                        break;
                }
                select = printSubMenu(item);
            }
            return new Product();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Initialization.Initialize();
            PrintMenu();
        }
    }
}

