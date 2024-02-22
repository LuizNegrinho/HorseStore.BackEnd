using HorseStore.BackEnd.Application;
using HorseStore.BackEnd.Models;

namespace HorseStore.BackEnd.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ICommonService _commonService;

        public LoginRepository(ICommonService commonService)
        {
            _commonService = commonService;            
        }

        public User Login(LogInModel login)
        {
            DataDTO data = _commonService.ReadDB();
            User? user = data.Users.FirstOrDefault(u => u.Username == login.username && u.Password == login.password);
            if (user != null)
                return user;
            return new User();
        }      
    }

}
