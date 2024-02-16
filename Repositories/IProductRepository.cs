using HorseStore.BackEnd.Models;

namespace HorseStore.BackEnd.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Bid> GetBids(int productId);
        IEnumerable<Lot> GetIndex(int id);
    }
}
