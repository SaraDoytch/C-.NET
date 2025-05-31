
using BlApi;

namespace Bllmplementation
{
    internal class Bl : IBl
    {
        public IClient customer => new ClientImplementation();

        public IOrder order => new OrderImplementation();

        public IProduct product => new ProductImplementation();

        public ISale sale => new SaleImplementation();
    }
}
