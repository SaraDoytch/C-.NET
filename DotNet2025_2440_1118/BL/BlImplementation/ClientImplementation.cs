using BO;
using BlApi;
using DalApi;
using System.Linq;
//using static BO.Exceptions;

namespace BlImplementation
{
    internal class ClientImplementation : BlApi.IClient
    {
        private DalApi.IDal dal = DalApi.Factory.Get;
        public int Create(BO.Client client)
        {
            try
            {
                return dal.Client.Create(client.Convert());
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
                dal.Client.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting customer", ex);
            }
        }

        public bool IsExsist(int id)
        {
            try
            {
                if (dal.Client.Read(id).Convert() != null)
                {
                    return true;

                }
                return false;
            }
            catch (DO.DalIdNotExist)
            {
                return false;
            }
        }


        public BO.Client Read(int id)
        {
            try
            {
                return dal.Client.Read(id).Convert();
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading customer", ex);
            }
        }

        public BO.Client? Read(Func<BO.Client, bool> filter)
        {
            try
            {
                return dal.Client.ReadAll().Select(c => c.Convert()).FirstOrDefault(filter);
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading customer with filter", ex);
            }
        }
        public List<BO.Client?> ReadAll(Func<BO.Client, bool>? filter = null)
        {

            try
            {
                if (filter == null)
                
                    return dal.Client.ReadAll().Select(x => x.Convert()).ToList();
                else
                return dal.Client.ReadAll().Select(x => x.Convert()).Where(filter).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception("Error reading customers", ex);
            }
        }

        public void Update(BO.Client item)
        {
            try
            {
                dal.Client.Update(item.Convert());
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating customer", ex);
            }
        }
    }
}
