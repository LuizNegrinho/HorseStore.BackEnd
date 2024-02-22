using HorseStore.BackEnd.Models;
using HorseStore.BackEnd.Repositories;

namespace HorseStore.BackEnd.Application
{
    public class LoginApplication : ILoginApplication
    {
        private readonly ILoginRepository _loginRepository;

        public LoginApplication(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public User LogIn(LogInModel login)
        {
            return _loginRepository.Login(login);                      
        }
    }
}
