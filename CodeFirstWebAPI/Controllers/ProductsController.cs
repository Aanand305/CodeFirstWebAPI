using CodeFirstWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CodeFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ProductsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var products = dbContext.Products.ToList();
            return Ok(products);

        }
        [HttpPost]
        public IActionResult Post(Products products)
        {
            dbContext.Products.Add(products);
            dbContext.SaveChanges();
            return Ok(new {Ok=true,message="Product Created"});
        }
    }

}
