using System.Text.Json;
using System.Text;

namespace HorseStore.BackEnd.Repositories
{
    public interface ICommonService
    {
        DataDTO ReadDB();
        bool Save(DataDTO newDB);
    }
}
