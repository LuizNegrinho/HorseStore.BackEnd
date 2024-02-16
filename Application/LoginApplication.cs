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

        public LoginModel Login(string username, string password)
        {

            LoginModel user = _loginRepository.Login(username, password);

            if (user.Id > 0)
                return user;
            throw new Exception("Login Inválido");

                      
        }
    }
}
