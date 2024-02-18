using HorseStore.BackEnd.Models;

namespace HorseStore.BackEnd.Repositories
{
    public interface IProductRepository
    {
        bool DeleteBid(int id);
        IEnumerable<Bid> GetBids(int productId);
        IEnumerable<Lot> GetIndex(int id);
        Bid InsertBid(Bid bid);
    }
}
