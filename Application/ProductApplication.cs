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


        public IEnumerable<Bid> GetBids(int productId)
        {
            var bids = _repository.GetBids(productId).Where(bid => bid.LotId == productId);
            return bids;
        }

        public Bid InsertBid(Bid bid)
        {
            _ = new Bid();
            Bid newBid = _repository.InsertBid(bid);
            return newBid;
        }
        public bool DeleteBid(int id)
        {
            throw new NotImplementedException();
        }
    }
}
