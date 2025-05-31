

namespace DO
{
    public record Sale(
    int Id,
    int ProductId,
    int RequiredAmount,
    double SalePrice,
    bool IsForClubMembers,
    DateTime StartDate,
    DateTime EndDate
)
    {
        public Sale() : this(0, 0, 0, 0, true, DateTime.Now, DateTime.Now)
        {

        }
    }
}
