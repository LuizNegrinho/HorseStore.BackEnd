using HorseStore.BackEnd.Application;
using HorseStore.BackEnd.Models;
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
        public IActionResult LogIn([FromBody]LogInModel login)
        {
            try
            {
                var user = _loginApplication.LogIn(login);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(401, ex.Message);                
            }
            
        }
    }
}
