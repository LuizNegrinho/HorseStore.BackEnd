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
            DataDTO data = ReadDB();

            return data.Lots ?? list;          
        }
        public IEnumerable<Bid> GetBids(int productId)
        {
            List<Bid> bids = new();
            DataDTO data = ReadDB();

            return data.Bids ?? bids;
        }

        public Bid InsertBid(Bid bid)
        {
            DataDTO data = ReadDB();

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

            Save(data);
            return bid;           
        }

        public bool DeleteBid(int id)
        {
            try
            {
                DataDTO data = ReadDB();

                if(data != null)
                {
                    var initialCount = data.Bids.Count();
                    data.Bids.RemoveAll(b => b.Id == id);
                    if (initialCount == data.Bids.Count())
                        return false;
                    return Save(data);
                }
                return false;                

            }
            catch (Exception ex)
            {
                return false;
            }
        }   

        private DataDTO ReadDB()
        {
            string data = File.ReadAllText(_dbConnection, Encoding.UTF8);
            return JsonSerializer.Deserialize<DataDTO>(data) ?? throw new Exception("Falha ao acessar banco de dados.");
        }

        private bool Save(DataDTO newDB)
        {
            try
            {
                string data = JsonSerializer.Serialize(newDB);
                File.WriteAllText(_dbConnection, data, Encoding.UTF8);
                return true;

            }
            catch (IOException)
            {
                return false;
            }
            

        }
       


    }
}
