using HorseStore.BackEnd.Models;

namespace HorseStore.BackEnd.Repositories
{
    public interface IHorseRepository
    {
        public IEnumerable<Lot> GetIndex(int id);
    }
}
