
namespace DalTest;
using DO;
using DalApi;
public static class Initialization
{
    public static IDal s_dal;
    private static void CreateClient()
    {
        s_dal.Client.Create(new Client(1111111, "", "", "052757574"));
        s_dal.Client.Create(new Client(2222222, "", "", "025558552"));
        s_dal.Client.Create(new Client(3333333, "", "", "055575758"));
        s_dal.Client.Create(new Client(4444444, "", "", "035757555"));
        s_dal.Client.Create(new Client(5555555, "", "", "084576777"));
        s_dal.Client.Create(new Client(6666666, "", "", "033785755"));
        s_dal.Client.Create(new Client(7777777, "", "", "053574575"));
        s_dal.Client.Create(new Client(8888888, "", "", "084545745"));
    }
    private static void CreateProduct()
    {
        s_dal.Product.Create(new Product(0, "פלפל שחור", Categories.תבלינים, 3, 5));
        s_dal.Product.Create(new Product(0, "קינמון", Categories.תבלינים, 3, 5));
        s_dal.Product.Create(new Product(0, "קשיו", Categories.קלויים, 3, 10));
        s_dal.Product.Create(new Product(0, "אגוזי מלך", Categories.קלויים, 3, 10));
        s_dal.Product.Create(new Product(0, "שקד מולבן", Categories.טבעיים, 3, 15));
        s_dal.Product.Create(new Product(0, "אגוזי ברזיל", Categories.טבעיים, 3, 15));
        s_dal.Product.Create(new Product(0, "אננס", Categories.יבשים, 3, 20));
        s_dal.Product.Create(new Product(0, "מנגו", Categories.יבשים, 3, 20));
        s_dal.Product.Create(new Product(0, "פסק זמן", Categories.שוקולדים, 3, 30));
        s_dal.Product.Create(new Product(0, "בננית", Categories.שוקולדים, 3, 30));
    }
    private static void CreateSale()
    {
        s_dal.Sale.Create(new Sale(0, 1111, 5, 54, true, DateTime.Now, DateTime.Now));
        s_dal.Sale.Create(new Sale(0, 2222, 10, 54, true, DateTime.Now, DateTime.Now));
        s_dal.Sale.Create(new Sale(0, 3333, 2, 54, true, DateTime.Now, DateTime.Now));
        s_dal.Sale.Create(new Sale(0, 4444, 8, 54, false, DateTime.Now, DateTime.Now));
        s_dal.Sale.Create(new Sale(0, 5555, 10, 54, false, DateTime.Now, DateTime.Now));
        s_dal.Sale.Create(new Sale(0, 6666, 10, 54, false, DateTime.Now, DateTime.Now));
        s_dal.Sale.Create(new Sale(0, 7777, 3, 54, true, DateTime.Now, DateTime.Now));
        s_dal.Sale.Create(new Sale(0, 8888, 8, 54, false, DateTime.Now, DateTime.Now));
    }
    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;
        CreateClient();
        CreateProduct();
        CreateSale();

    }
}
