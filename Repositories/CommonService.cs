using System.Text.Json;
using System.Text;

namespace HorseStore.BackEnd.Repositories
{
    public class CommonService : ICommonService
    {
        private string _dbConnection = "Repositories/data.json";
        public DataDTO ReadDB()
        {
            string data = File.ReadAllText(_dbConnection, Encoding.UTF8);
            return JsonSerializer.Deserialize<DataDTO>(data) ?? throw new Exception("Falha ao acessar banco de dados.");
        }

        public bool Save(DataDTO newDB)
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
