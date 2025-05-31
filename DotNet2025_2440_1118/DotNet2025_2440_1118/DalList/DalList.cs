using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalList : IDal
    {
        public ISale Sale => new SaleImplementation();
        public IClient Client => new ClientImplementation();
        public IProduct Product => new ProductImplementation();
        private static readonly DalList instance = new DalList();
        public static DalList Instance
        {
            get { return instance; }
        }
        private DalList()
        {

        }
    }
}
