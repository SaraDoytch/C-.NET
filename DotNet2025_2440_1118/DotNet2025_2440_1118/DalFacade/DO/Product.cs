

namespace DO
{
    public record Product(
    int Id,
    string Name,
    Categories Categoryies,
    double Price,
    int InStock
)
    {
        public Product() : this(0, "", Categories.שוקולדים, 0, 0)
        {

        }
    }
}
