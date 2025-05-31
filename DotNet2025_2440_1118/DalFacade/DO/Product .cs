

namespace DO;

public record Product(int Barcode,
    string Name,
    Categories Category,
    double Price,
    int AmountOfStack)
{
    public Product(int V, string value) :this(0,"",Categories.קלויים,0,0)
    {

    }
}
