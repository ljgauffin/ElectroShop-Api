using System.Security.Claims;
using ElectroShop.Models;
using ElectroShop.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;

namespace ElectroShop.Controllers;

[Route("api/[controller]")]
public class UserController: ControllerBase
{
    
    IUserService userService;

    public UserController(IUserService userService)
    {
        
        this.userService = userService;
    }

    /// <summary>
    /// Gets cart item from the token user.
    /// </summary>
    /// 
    /// <returns>A list of cart objects</returns>
    [HttpGet("{id}")]
    [Authorize(Roles = ("Admin"))]
    public IActionResult Get(Guid id){
        try
        {
            User user = userService.Get(id);
            if(user!=null)
            {
                return Ok(user);
            }else
            {
                return NotFound(new ErrorResponse(){Status=404, Message="User Not Found."});
            }
            
        }catch{
            return StatusCode(500, new ErrorResponse(){Status=500,Message="Internal Server Error."});
        }

    }
    [HttpGet]
    [Authorize]
    public IActionResult Get(){
        try
        {
            return Ok(userService.GetUserContext(HttpContext));
        }catch{
            return StatusCode(500, new ErrorResponse(){Status=500,Message="Internal Server Error."});
        }

    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] User user)
    {
        try
        {
            return Ok(await userService.Save(user));
            

        }catch (Exception ex){
            return StatusCode(500, new ErrorResponse
                {
                    Status = 500,
                    Message = ex.Message
                });
        }
        
    }
    
    //Only users can update themselves
    [HttpPut]
    public IActionResult Put([FromBody] User user)
    {
        try
        {
            Guid id = userService.GetUserContext(HttpContext).UserId; //get id off the user from token
            if(userService.Update(id, user)) 
            {
                return StatusCode(201);
            }
            
            else return NotFound();

        }catch(Exception ex)
        {
            return StatusCode(500, new ErrorResponse
            {
                Status = 500,
                Message = ex.Message
            });

        }

        
        
        
    }
 
}