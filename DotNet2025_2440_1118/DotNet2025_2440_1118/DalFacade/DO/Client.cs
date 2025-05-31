

namespace DO
{
    public record Client(
    int Id,
    string Name,
    string Address,
    string Phone
)
    {
        public Client() : this(0, "", "", "000")
        {

        }
    }
}
