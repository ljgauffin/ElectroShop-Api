
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
        try{
            var user = userService.GetUserContext(HttpContext);
            cart.UserId = user.UserId;
            Guid guid = cartService.Save(cart);
            if(guid!=Guid.Empty)
            {
                return Ok(guid);
            }
            return StatusCode(500, new ErrorResponse
                {
                    Status = 500,
                    Message = "Internal server error."
                });

        }catch{
            return StatusCode(500, new ErrorResponse
                {
                    Status = 500,
                    Message = "Internal server error."
                });
        }
        
    }

    [HttpPut("{id}")]
    [Authorize(Roles = ("User"))]
    public IActionResult Put(Guid id,[FromBody] Cart cart)
    {
        try
        {
            var user = userService.GetUserContext(HttpContext);
            cart.UserId = user.UserId;
            if(cartService.Update(id, cart)) 
            {
                return StatusCode(201);
            }
            
            else return NotFound();

        }catch(Exception ex)
        {
            return StatusCode(500, new ErrorResponse
            {
                Status = 500,
                Message = "Internal server error."
            });

        }

        
        
        
    }
 
}