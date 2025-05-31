using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;

namespace Bllmplementation
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product item)
        {
            try
            {
                return _dal.Product.Create(item.ConvertBOproductToDOproduct());
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public void GetSalesToProduct(BO.Product product, bool isPreferred)
        {
            try
            {
                product.Sales = _dal.Sale.ReadAll(s => s.Id == product.Id
                && s.StartSaleDate <= DateTime.Now && s.End_Date >= DateTime.Now
                && product.Amount >= s.MinAmount
                && (isPreferred || s.Club))
                    .Select(s => new BO.Sale() { Id = s.codeIndex, Amount = s.MinAmount, IsIntendedForAll = s.Club, Price = s.Price })
                    .OrderBy(s => s.Price)
                    .ToList();
            }
            catch (Exception ex)
            {


            }
        }

        public BO.Product? Read(int id)
        {
            try
            {
                DO.Product doRes = _dal.Product.Read(id);
                return doRes.ConvertDOproductToBOproduct();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public BO.Product? Read(Func<BO.Product, bool>? filter)
        {
            try
            {
                DO.Product product = _dal.Product.Read(c => filter(c.ConvertDOproductToBOproduct()));
                return product.ConvertDOproductToBOproduct();
            }
            catch
            {
                return null;
            }

        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            if (filter == null)


                return _dal.Product.ReadAll().Select(p => p.ConvertDOproductToBOproduct()).ToList();
            return _dal.Product.ReadAll(p => filter(p.ConvertDOproductToBOproduct())).Select(p => p.ConvertDOproductToBOproduct()).ToList();
        }

        public void Update(BO.Product item)
        {
            try
            {
                _dal.Product.Update(item.ConvertBOproductToDOproduct());
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
