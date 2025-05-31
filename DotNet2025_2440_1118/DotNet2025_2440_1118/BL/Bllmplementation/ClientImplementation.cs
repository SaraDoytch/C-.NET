
using BlApi;
using BO;


namespace Bllmplementation
{
    internal class ClientImplementation : IClient
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        //public bool IsCustomerExist { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

     
        public int Create(BO.Client item)
        {
            try
            {
                return _dal.Client.Create(item.ConvertBOcustomerToDOcustomer());
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
                _dal.Client.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public BO.Client? Read(int id)
        {
            try
            {
                DO.Client doRes = _dal.Client.Read(id);
                return doRes.ConvertDOcustomerToBOcustomer();
            }
            catch
            {
                return null;
            }
        }

        public BO.Client? Read(Func<BO.Client, bool>? filter)
        {
            try
            {

                return _dal.Client.ReadAll().Select(c => c.ConvertDOcustomerToBOcustomer()).FirstOrDefault(filter);
            }
            catch
            {
                return null;
            }

        }

        public List<BO.Client?> ReadAll(Func<BO.Client, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                {
                    return _dal.Client.ReadAll().Select(x => x.ConvertDOcustomerToBOcustomer()).ToList();

                }
                return _dal.Client.ReadAll().Select(x => x.ConvertDOcustomerToBOcustomer()).Where(filter).ToList();

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
                _dal.Client.Update(item.ConvertBOcustomerToDOcustomer());
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
        public bool IsExist(BO.Client customer)
        {
            try
            {
                if (_dal.Client.Read(customer.Id) != null)
                {
                    return true;

                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking if customer exists", ex);
            }
        }
    }
}
