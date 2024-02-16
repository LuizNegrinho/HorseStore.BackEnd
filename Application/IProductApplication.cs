using HorseStore.BackEnd.Repositories;

namespace HorseStore.BackEnd.Application
{
    public interface IProductApplication
    {
       IEnumerable<Bid> GetBids(int productId);
    }
}
