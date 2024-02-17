using HorseStore.BackEnd.Models;
using System.Text;
using System.Text.Json;

namespace HorseStore.BackEnd.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private string _dbConnection = "Repositories/data.json";


        public IEnumerable<Lot> GetIndex(int id)
        {
            var list = new List<Lot>();
            string data = File.ReadAllText(_dbConnection, Encoding.UTF8);
            var converted = JsonSerializer.Deserialize<DataDTO>(data);

            return converted.Lots ?? list;          
        }
        public IEnumerable<Bid> GetBids(int productId)
        {
            List<Bid> bids = new();
            string data = File.ReadAllText(_dbConnection, Encoding.UTF8);
            var converted = JsonSerializer.Deserialize<DataDTO>(data);

            return converted.Bids ?? bids;
        }

        public Bid InsertBid(Bid bid)
        {
            string data = File.ReadAllText(_dbConnection, Encoding.UTF8);
            var converted = JsonSerializer.Deserialize<DataDTO>(data);

            if (converted != null)
            {
                var maxId = converted.Bids.Max(b => b.Id);
                bid.Id = maxId + 1;

                if (converted.Bids != null)
                    converted.Bids.Add(bid);
                else
                    converted.Bids = new List<Bid> { bid };
            }
            else
                throw new Exception("Falha no sistema de arquivos.");

            string newData = JsonSerializer.Serialize(converted);
            File.WriteAllText(_dbConnection, newData, Encoding.UTF8);


            return bid;

            
        }
    }
}
