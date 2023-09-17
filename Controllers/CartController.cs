
using System.Security.Claims;
using ElectroShop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ElectroShop.Controllers;

[Route("api/[controller]")]
public class CartController: ControllerBase
{
    ICartService cartService;
    IUserService userService;

    public CartController(ICartService cartService,IUserService userService)
    {
        this.cartService = cartService;
        this.userService = userService;
    }

    [HttpGet]
    [Authorize(Roles = ("User"))]

    public IActionResult Get(){
        var identity = HttpContext.User.Identity as ClaimsIdentity;
        var user = userService.GetUserContext(HttpContext);
        return Ok (cartService.Get(user));
    }

 
}