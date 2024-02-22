using HorseStore.BackEnd.Models;
using HorseStore.BackEnd.Repositories;

namespace HorseStore.BackEnd.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _repository;

        public ProductApplication(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Lot> GetIndex(int userId)
        {
            return _repository.GetIndex(userId);
        }
        public Lot GetProduct(int lotId)
        {
            return _repository.GetProduct(lotId);
        }

        public IEnumerable<Bid> GetBids(int productId)
        {
            var bids = _repository.GetBids().Where(bid => bid.LotId == productId);
            return bids;
        }

        public Bid InsertBid(Bid bid)
        {
            _ = new Bid();
            bid.Date = DateTime.Now.ToShortDateString();
            Bid newBid = _repository.InsertBid(bid);
            return newBid;
        }
        public bool DeleteBid(int id)
        {
            return _repository.DeleteBid(id);
        }


    }
}
