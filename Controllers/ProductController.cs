
using System.Security.Claims;
using ElectroShop.Models;
using ElectroShop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace ElectroShop.Controllers;

[Route("api/[controller]")]
public class ProductController: ControllerBase
{
    IProductService productService;
    IUserService userService;
    private readonly ILogger<ProductController> logger;

    public ProductController(IProductService service,IUserService userService, ILogger<ProductController> logger)
    {
        productService = service;
        this.userService = userService;
        this.logger = logger;
    }

    [HttpGet]
    public IActionResult Get(){
        try 
        {
            IEnumerable<Product> products = productService.Get();
            if (products.IsNullOrEmpty()){
                
                return NotFound(new ErrorResponse
                {
                    Status = 404,
                    Message = "Product not found."
                });
                
            }

            logger.LogInformation($"Returning {products.Count()} products");
            return Ok (products);
            
            

        }
        catch(Exception ex){
            logger.LogError($"Error getting products: {ex.Message}");
            
            return StatusCode(500, new ErrorResponse
            {
                Status = 500,
                Message = "Internal server error."
            });
        }
        
        
    }

    [HttpGet("{id}")]
    //[Authorize(Roles = ("Admin"))]
    [Authorize]
    public IActionResult Get(Guid id){
        try
        {
            Product product = productService.Get(id);
            // var identity = HttpContext.User.Identity as ClaimsIdentity;
            // var user = userService.GetUserContext(HttpContext);
            if (product==null){
                return NotFound(new ErrorResponse
                {
                    Status = 404,
                    Message = "Product not found."
                });
            }
            return Ok (product);

            
        // return Ok (user);
        }catch(Exception ex){
            logger.LogError($"Error getting product: {ex.Message}");
            
            return StatusCode(500, new ErrorResponse
            {
                Status = 500,
                Message = "Internal server error."
            });
        }
       
    }
}