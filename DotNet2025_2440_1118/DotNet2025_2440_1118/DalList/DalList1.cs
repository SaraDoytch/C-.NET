using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalList1 : IDal
    {
        public IProduct Product => new ProductImplementation();

        public ISale Sale => new SaleImplementation();

        public IClient Client => new ClientImplementation();

        private static readonly DalList1 instance= new DalList1();
        public static DalList1 Instance {
            get { return instance; }
        }
        private DalList1()
        {
               
        }
    }
}
