using HorseStore.BackEnd.Application;
using HorseStore.BackEnd.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HorseStore.BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductApplication _application;

        public ProductsController(IProductRepository productRepository, IProductApplication productApplication)
        {
            _productRepository = productRepository;
            _application = productApplication;
        }
                

        [HttpGet("GetIndex")]
        public IActionResult Index([FromQuery] int userId)
        {
            return Ok(_application.GetIndex(userId));
        }

        [HttpGet("GetLot")]
        public IActionResult GetLot([FromQuery] int productId)
        {
            return Ok(_application.GetProduct(productId));
        }

        [HttpGet("GetBids")]
        public IActionResult GetBids([FromQuery] int productId)
        {
            return Ok(_application.GetBids(productId));
        }

        [HttpPost("InsertBid")]
        public IActionResult InsertBid(Bid bid)
        {
            try
            {
                var newBid = _application.InsertBid(bid);
                return Ok(newBid);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteBid")]
        public IActionResult DeleteBid([FromQuery] int id) 
        {
            bool deleted = _application.DeleteBid(id);
            return Ok(deleted);
        }
    }
}
