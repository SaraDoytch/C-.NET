using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class ProductImplementation:IProduct
    {
        private DalApi.IDal dal = DalApi.Factory.Get;
        public int Create(BO.Product products)
        {
            try
            {
                return dal.Product.Create(products.Convert());
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
                dal.Product.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting customer", ex);
            }
        }

    

        public List<BO.Product> getListSales(int id, bool favorite)
        {
            try
            {
                return dal.Product.ReadAll().Select(x => x.Convert()).Where(p => p.SaleInProduct != null && p.SaleInProduct.Any(p => p.SaleId == id && favorite)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading customers", ex);
            }
        }

        public void GetSalesToProduct(Product product, bool isPreferred)
        {
            throw new NotImplementedException();
        }

        public BO.Product Read(int id)
        {
            try
            {
                return dal.Product.Read(id).Convert();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading customer", ex);
            }
        }

        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try
            {
                return dal.Product.ReadAll().Select(c => c.Convert()).FirstOrDefault(filter);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading customer with filter", ex);
            }
        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                {
                    return dal.Product.ReadAll().Select(x => x.Convert()).ToList();

                }
                return dal.Product.ReadAll().Select(x => x.Convert()).Where(filter).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception("Error reading customers", ex);
            }
        }

        public void Update(BO.Product item)
        {
            try
            {
                dal.Product.Update(item.Convert());
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating customer", ex);
            }
        }

        //public void Update(Client client)
        //{
        //    throw new NotImplementedException();
        //}
    }

}

