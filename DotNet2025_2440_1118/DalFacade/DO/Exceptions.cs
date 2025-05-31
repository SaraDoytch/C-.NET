
namespace DO;

[Serializable]
public class DalIdNotExist : Exception
{
    public DalIdNotExist(string message) : base(message) { }
}

[Serializable]
public class DalIdAlreadyExist : Exception
{
    public DalIdAlreadyExist(string message) : base(message) { }
}
