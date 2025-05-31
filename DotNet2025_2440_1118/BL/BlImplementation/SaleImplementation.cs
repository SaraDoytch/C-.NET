using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class SaleImplementation:ISale
    {
        private DalApi.IDal dal = DalApi.Factory.Get;
        public int Create(BO.Sale sale)
        {
            try
            {
                return dal.Sale.Create(sale.Convert());
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating customer", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                dal.Sale.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting customer", ex);
            }
        }

        public BO.Sale Read(int id)
        {
            try
            {
                return dal.Sale.Read(id).Convert();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading customer", ex);
            }
        }

        public BO.Sale? Read(Func<BO.Sale, bool> filter)
        {
            try
            {
                return dal.Sale.ReadAll().Select(c => c.Convert()).FirstOrDefault(filter);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading customer with filter", ex);
            }
        }

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                {
                    return dal.Sale.ReadAll().Select(x => x.Convert()).ToList();

                }
                return dal.Sale.ReadAll().Select(x => x.Convert()).Where(filter).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception("Error reading customers", ex);
            }
        }

        public void Update(BO.Sale item)
        {
            try
            {
                dal.Sale.Update(item.Convert());
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating customer", ex);
            }
        }

    }
}
