using HorseStore.BackEnd.Models;
using HorseStore.BackEnd.Repositories;

namespace HorseStore.BackEnd.Application
{
    public interface IProductApplication
    {
        bool DeleteBid(int id);
        IEnumerable<Bid> GetBids(int productId);
        IEnumerable<Lot> GetIndex(int userId);
        Lot GetProduct(int lotId);
        Bid InsertBid(Bid bid);
    }
}
