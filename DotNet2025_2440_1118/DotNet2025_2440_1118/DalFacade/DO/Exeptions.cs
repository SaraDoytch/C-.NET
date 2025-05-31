

namespace DO;


[Serializable]

internal class DalIdNotExist : Exception
{

    public DalIdNotExist(string e) : base(e) { }

}
[Serializable]

internal class DalIdAlreadyExist : Exception
{
    public DalIdAlreadyExist(string e) : base() { }


}

