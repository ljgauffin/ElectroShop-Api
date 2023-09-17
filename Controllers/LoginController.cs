
using ElectroShop.Migrations;
using ElectroShop.Models;
using ElectroShop.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace ElectroShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        IUserService userService;

        public LoginController(IUserService userService,IConfiguration config )
        {
            _config = config;
            this.userService=userService;
        }

        [HttpPost]
        public IActionResult Login([FromBody]LogModel login)
        {
             var user = userService.Authenticate(login.Email, login.Password);

            if(user != null )
            {
                // Crear el token

                var token = Generate(user);

                LogResponse response = new LogResponse(){User=user, Token=token};
                return Ok(response);

                
            } 

            return NotFound("Usuario no encontrado");

           
        }

        

        private string Generate(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Creating claims
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Surname, user.Surname),
                new Claim(ClaimTypes.Email, user.Email),
  
               new Claim(ClaimTypes.Role, user.Role.Description)
            };


            // Creating token

            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }


    public class LogModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LogResponse
    {
        public User User { get; set; }
        public string Token { get; set; }
    }
}