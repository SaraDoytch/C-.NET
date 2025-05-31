
namespace DO;

[Serializable]
public class DalIdNotExist : Exception
{
    public DalIdNotExist(string e) : base(e) { }
}
[Serializable]
public class DalIdAlreadyExist : Exception
{
    public DalIdAlreadyExist(string e) : base() { }
}