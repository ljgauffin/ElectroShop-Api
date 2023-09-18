
using System.Security.Claims;
using ElectroShop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ElectroShop.Controllers;

[Route("api/[controller]")]
public class ProductController: ControllerBase
{
    IProductService productService;
    IUserService userService;

    public ProductController(IProductService service,IUserService userService)
    {
        productService = service;
        this.userService = userService;
    }

    [HttpGet]
    public IActionResult Get(){
        return Ok (productService.Get());
    }

    [HttpGet("{id}")]
    //[Authorize(Roles = ("Admin"))]
    [Authorize]
    public IActionResult Get(Guid id){
        var identity = HttpContext.User.Identity as ClaimsIdentity;
        var user = userService.GetUserContext(HttpContext);
        // return Ok (user);
       return Ok (productService.Get(id));
    }
}