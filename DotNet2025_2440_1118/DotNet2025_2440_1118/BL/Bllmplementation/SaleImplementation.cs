using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using BO;

namespace Bllmplementation
{
    internal class SaleImplementation : ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Sale item)
        {
            try
            {
                return _dal.Sale.Create(item.ConvertBOsaleToDOsale());
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
                _dal.Sale.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public BO.Sale? Read(int id)
        {

            try
            {
                return _dal.Sale.Read(id).ConvertDOsaleToBOsale();
            }
            catch
            {
                return null;
            }
        }

        public BO.Sale? Read(Func<BO.Sale, bool>? filter)
        {
            try
            {
                return _dal.Sale.ReadAll().Select(c=>c.ConvertDOsaleToBOsale()).FirstOrDefault(filter);
            }
            catch
            {
                return null;
            }
        }

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            if (filter == null)
                return _dal.Sale.ReadAll().Select(s => s.ConvertDOsaleToBOsale()).ToList();
            return _dal.Sale.ReadAll(s => filter(s.ConvertDOsaleToBOsale())).Select(s => s.ConvertDOsaleToBOsale()).ToList();
        }

        public void Update(BO.Sale item)
        {
            try
            {
                _dal.Sale.Update(item.ConvertBOsaleToDOsale());
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
