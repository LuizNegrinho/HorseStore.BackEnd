using HorseStore.BackEnd.Models;
using System.Text;
using System.Text.Json;

namespace HorseStore.BackEnd.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private string _dbConnection = "Repositories/data.json";

        public IEnumerable<Bid> GetBids(int productId)
        {
            List<Bid> bids = new();
            string data = File.ReadAllText(_dbConnection, Encoding.UTF8);
            var converted = JsonSerializer.Deserialize<DataDTO>(data);

            return converted.Bids ?? bids;
        }

        public IEnumerable<Lot> GetIndex(int id)
        {
            var list = new List<Lot>();
            string data = File.ReadAllText(_dbConnection, Encoding.Latin1);
            var converted = JsonSerializer.Deserialize<DataDTO>(data);

            return converted.Lots ?? list;          
        }
    }
}
