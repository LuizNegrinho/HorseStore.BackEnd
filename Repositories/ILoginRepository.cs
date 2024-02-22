using HorseStore.BackEnd.Application;
using HorseStore.BackEnd.Models;

namespace HorseStore.BackEnd.Repositories
{
    public interface ILoginRepository
    {
        User Login(LogInModel login);
    }
}
