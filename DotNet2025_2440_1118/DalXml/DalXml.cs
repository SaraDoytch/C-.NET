using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalXml:IDal
    {
        private DalXml() { }
        private static readonly DalXml instanca = new DalXml();
        public static DalXml Instance
        {
            get
            {
                return instanca;
            }
        }
        public IProduct Product => new ProductImplementation();

        public ISale Sale => new SaleImplementation();

        public IClient Client => new ClientImplementation();
    }
}
