using HorseStore.BackEnd.Models;
using HorseStore.BackEnd.Repositories;

namespace HorseStore.BackEnd.Application
{
    public interface ILoginApplication
    {
        public User LogIn(LogInModel login);
    }
}
