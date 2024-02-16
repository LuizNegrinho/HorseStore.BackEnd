using HorseStore.BackEnd.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HorseStore.BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IHorseRepository _horseRepository;

        public ProductsController(IHorseRepository horseRepository)
        {
            _horseRepository = horseRepository;
        }
                

        [HttpGet("GetIndex")]
        public IActionResult Index([FromQuery] int userId)
        {
            return Ok(_horseRepository.GetIndex(userId));
        }
    }
}
