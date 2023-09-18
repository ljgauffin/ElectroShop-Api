
using System.Security.Claims;
using ElectroShop.Models;
using ElectroShop.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;

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

    /// <summary>
    /// Gets cart item from the token user.
    /// </summary>
    /// 
    /// <returns>A list of cart objects</returns>
    [HttpGet]
    [Authorize(Roles = ("User"))]

    public IActionResult Get(){
        
        var user = userService.GetUserContext(HttpContext);
        return Ok (cartService.Get(user));
    }

    [HttpPost]
    [Authorize(Roles = ("User"))]
    public IActionResult Post([FromBody] Cart cart)
    {
        var user = userService.GetUserContext(HttpContext);
        cart.UserId = user.UserId;
        return Ok(cartService.Save(cart));
    }

    [HttpPut("{id}")]
    [Authorize(Roles = ("User"))]
    public IActionResult Put(Guid id,[FromBody] Cart cart)
    {

        var user = userService.GetUserContext(HttpContext);

        cart.UserId = user.UserId;
        if(cartService.Update(id, cart)) return Ok();
        else return NotFound();
        
        
    }
 
}