using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal static class Config
    {
        private const string NAME_FILE = @"..\xml\data-config.xml";
        private const string PRODUCT_CURRENT_CODE = "ProductCurrentCode";
        private const string SALE_CURRENT_CODE = "SaleCurrentCode";


        public static int ProductCurrentCode
        {
            get
            {
                XElement root = XElement.Load(NAME_FILE);
                int currentCode = int.Parse(root.Element(PRODUCT_CURRENT_CODE).Value);
                root.Element(PRODUCT_CURRENT_CODE).SetValue(++currentCode);
                root.Save(NAME_FILE);
                return currentCode;

            }
        }

        public static int SaleCurrentCode
        {
            get
            {
                XElement root = XElement.Load(NAME_FILE);
                int currentCode = int.Parse(root.Element(SALE_CURRENT_CODE).Value);
                root.Element(SALE_CURRENT_CODE).SetValue(++currentCode);
                root.Save(NAME_FILE);
                return currentCode;
            }
        }
    }
}
