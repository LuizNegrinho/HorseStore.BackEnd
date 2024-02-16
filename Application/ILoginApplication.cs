namespace HorseStore.BackEnd.Application
{
    public interface ILoginApplication
    {
        public LoginModel Login(string username, string password);
    }
}
