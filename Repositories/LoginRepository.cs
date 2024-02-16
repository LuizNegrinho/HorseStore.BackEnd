using HorseStore.BackEnd.Application;

namespace HorseStore.BackEnd.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public LoginModel Login(string username, string password)
        {
            LoginModel user = new()
            {
                Id = 1,
                Name = "Luiz",
                Password = "oikatombo",
                CreatedDate = DateTime.Today,
                ExpirationDate = DateTime.Today.AddDays(1)
            };

            if (username == user.Name && password == user.Password)
                return user;
            
            return new LoginModel();             
        }
    }
}
