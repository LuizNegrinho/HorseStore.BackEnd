using HorseStore.BackEnd.Application;
using Microsoft.AspNetCore.Mvc;

namespace HorseStore.BackEnd.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly ILoginApplication _loginApplication;

        public LoginController(ILoginApplication loginApplication)
        {
            _loginApplication = loginApplication;
        }

        [HttpPost("Login")]
        public IActionResult Login(string username, string password)
        {
            try
            {
                var login = _loginApplication.Login(username, password);
                return Ok(login);
            }
            catch (Exception ex)
            {
                return StatusCode(403, ex.Message);                
            }
            
        }
    }
}
