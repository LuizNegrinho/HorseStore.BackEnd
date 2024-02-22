using HorseStore.BackEnd.Models;
using System.Text;
using System.Text.Json;

namespace HorseStore.BackEnd.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICommonService _commonService;

        public ProductRepository(ICommonService commonService)
        {
            _commonService = commonService;                
        }

        public IEnumerable<Lot> GetIndex(int id)
        {
            DataDTO data = _commonService.ReadDB();
            return data.Lots ?? new List<Lot>();          
        }

        public Lot GetProduct(int id)
        {
            DataDTO data = _commonService.ReadDB();
            return data.Lots.Where(lot => lot.Id == id).FirstOrDefault() ?? new Lot();
        }
        public IEnumerable<Bid> GetBids()
        {
            List<Bid> bids = new();
            DataDTO data = _commonService.ReadDB();

            return data.Bids ?? bids;
        }
        public Bid GetBid(int bidId)
        {
            var bid = GetBids().FirstOrDefault(b => b.Id == bidId);            

            return bid ?? new Bid();
        }

        public Bid InsertBid(Bid bid)
        {
            DataDTO data = _commonService.ReadDB();

            if (data != null)
            {
                var maxId = data.Bids.Max(b => b.Id);
                bid.Id = maxId + 1;

                if (data.Bids != null)
                    data.Bids.Add(bid);
                else
                    data.Bids = new List<Bid> { bid };
            }
            else
                throw new Exception("Falha no sistema de arquivos.");

            _commonService.Save(data);

            return GetBid(bid.Id);           
        }

        public bool DeleteBid(int id)
        {
            try
            {
                DataDTO data = _commonService.ReadDB();

                if(data != null)
                {
                    var initialCount = data.Bids.Count();
                    data.Bids.RemoveAll(b => b.Id == id);
                    if (initialCount == data.Bids.Count())
                        return false;
                    return _commonService.Save(data);
                }
                return false;                

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
