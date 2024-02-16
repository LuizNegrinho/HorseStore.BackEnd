﻿using HorseStore.BackEnd.Application;
using HorseStore.BackEnd.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HorseStore.BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductApplication _productApplication;

        public ProductsController(IProductRepository productRepository, IProductApplication productApplication)
        {
            _productRepository = productRepository;
            _productApplication = productApplication;
        }
                

        [HttpGet("GetIndex")]
        public IActionResult Index([FromQuery] int userId)
        {
            return Ok(_productRepository.GetIndex(userId));
        }

        [HttpGet("GetBids")]
        public IActionResult GetBids([FromQuery] int productId)
        {
            return Ok(_productApplication.GetBids(productId));
        }
    }
}
