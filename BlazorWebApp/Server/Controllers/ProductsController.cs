using Microsoft.AspNetCore.Mvc;

namespace BlazorWebApp.Server.Controllers
{
    // "[constroller]" means the name of the class without the Controller word
    // class name ->  "ProductsController"   ->  "Products"       so   -> api url "..../api/Products"
    [Route("/api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public static List<Product> ProductsList = new List<Product>
        {
            new Product {
                            Id= 13232,
                            Title= "Product 1 TRASH FRAMEWORK",
                            Description= "sajdlasjdlkajd",
                            ImageUrl="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            Price= 121.22m
                        },

            new Product {
                            Id= 2,
                            Title= "Product 2",
                            Description= "lllllllllllllllllll",
                            ImageUrl="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            Price= 87.22m
                        },

            new Product {
                            Id= 2,
                            Title= "Product 3",
                            Description= "oooooooooooooooooooooooo",
                            ImageUrl="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            Price= 9997.22m
                        }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return Ok(ProductsList);
        } 
    }
}
