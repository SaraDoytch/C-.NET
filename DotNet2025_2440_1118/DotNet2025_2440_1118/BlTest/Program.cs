using BO;

namespace BlTest
{
    internal class Program
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

        public static void CreateCustomer()
        {
            BO.Client c = AskCustomer();
            s_bl.Client.Create(c);
            Console.WriteLine("Customer created successfuly");
        }
        public static BO.Client AskCustomer(int id = 0)
        {
            string name;
            string address;
            string phone;
            Console.WriteLine("Enter customer id");
            if (!int.TryParse(Console.ReadLine(), out id))
                id = 123456789;
            Console.WriteLine("Enter customer name");
            name = Console.ReadLine();
            Console.WriteLine("Enter address");
            address = Console.ReadLine();
            Console.WriteLine("Enter phone");
            phone = Console.ReadLine();

            return new BO.Client(id, name, address, phone);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Order order = new BO.Order();
            Console.WriteLine("enter your id, if you dont exist here press 0");
            int tz = int.Parse(Console.ReadLine());
            if (tz == 0)
            {

                CreateCustomer();
            }
            else
            {
                BO.Client c = s_bl.Client.Read(tz);
            }
            int id = 1, amount = 0;
            while (id != 0)
            {
                Console.WriteLine("For adding product to the order press the product id");
                id = int.Parse(Console.ReadLine());
                if (id != 0)
                {
                    Console.WriteLine("enter amount");
                    amount = int.Parse(Console.ReadLine());
                    s_bl.Order.AddProductToOrder(order, id, amount);

                }

            }
            s_bl.Order.DoOrder(order);
            //int select = 1;
            //while (select != 0)
            //{
            //    Console.WriteLine("Enter your customer ID or 0");
            //    int customerId = int.Parse(Console.ReadLine());
            //    Order order = new Order(customerId != 0 && s_bl.client.IsExsist(customerId), new List<ProductInOrder>(), customerId);
            //    int toContinue = 1;
            //    while (toContinue != 0)
            //    {
            //        Console.WriteLine("Enter product code: ");
            //        int productId = int.Parse(Console.ReadLine());
            //        Console.Write("Enter amount: ");
            //        int amount = int.Parse(Console.ReadLine());
            //        try
            //        {
            //            List<SaleInProduct> sales = s_bl.order.AddProductToOrder(order, productId, amount);
            //            Console.WriteLine("Product added successfully");
            //            Console.WriteLine("Sales applied:");
            //            if (sales.Count > 0)
            //            {
            //                foreach (SaleInProduct sale in sales)
            //                {
            //                    Console.WriteLine($"Sale: {sale.SaleId}: {sale.count} units for {sale.price}");
            //                }
            //            }
            //        }
            //        catch (Exception e)
            //        {
            //            Console.WriteLine("Error: " + e.Message);
            //        }

            //        Console.WriteLine("Add another product?");
            //        Console.WriteLine("press 1 to continue");
            //        Console.WriteLine("press 0 to exit");
            //        toContinue = int.Parse(Console.ReadLine());
            //    }
            //    s_bl.order.DoOrder(order);
            //    Console.WriteLine($"Order completed! Final price: {order.finalPrice}");
            //    Console.WriteLine("Do you want to place another order?");
            //    Console.WriteLine("press 1 to continue");
            //    Console.WriteLine("press 0 to exit");
            //    select = int.Parse(Console.ReadLine());

            //}
        }
    }
}
