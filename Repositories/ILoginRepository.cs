using HorseStore.BackEnd.Application;

namespace HorseStore.BackEnd.Repositories
{
    public interface ILoginRepository
    {
        LoginModel Login(string username, string password);
    }
}
