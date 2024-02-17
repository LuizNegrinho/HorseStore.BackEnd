using HorseStore.BackEnd.Repositories;

namespace HorseStore.BackEnd.Application
{
    public interface IProductApplication
    {
        bool DeleteBid(int id);
        IEnumerable<Bid> GetBids(int productId);
        Bid InsertBid(Bid bid);
    }
}
