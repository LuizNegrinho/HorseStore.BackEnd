namespace HorseStore.BackEnd.Application
{
    public class LoginModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}