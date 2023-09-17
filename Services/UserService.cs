using System.Security.Claims;
using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;


namespace ElectroShop.Services;

public class UserService:IUserService
{
    ElectroShopContext context;
    IRoleService roleService ;
    public UserService(ElectroShopContext context, IRoleService roleService)
    {
        this.context = context; 
        this.roleService = roleService; 
    }
    public IEnumerable<User> Get(User user){
        return context.Users.Include(p=>p.Role).Where(p=>p.Email==user.Email);
    }

    public User Get(string email){
        return context.Users.Include(p=>p.Role).FirstOrDefault(p=>p.Email==email);
    }
    public User? Authenticate(string email, string password){
        return  context.Users.Include(p=>p.Role)
                .Include(p=>p.Carts)
                .ThenInclude(p=>p.Product)
                .FirstOrDefault(p => p.Email == email && p.Password == password);
    }

    public User? GetUserContext(HttpContext context){
        
        var identity = context.User.Identity as System.Security.Claims.ClaimsIdentity;
        var user = new User();
        if(identity!=null){
            var userClaims = identity.Claims;
            user= this.Get(userClaims.FirstOrDefault(p=>p.Type==ClaimTypes.Email)?.Value);

            // var role = roleService.Get(userClaims.FirstOrDefault(p=>p.Type==ClaimTypes.Role)?.Value);
            // user = new User
            // {
            //     Name = userClaims.FirstOrDefault(p=>p.Type== ClaimTypes.Name)?.Value,
            //     Surname = userClaims.FirstOrDefault(p=>p.Type==ClaimTypes.Surname)?.Value,
            //     Email = userClaims.FirstOrDefault(p=>p.Type==ClaimTypes.Email)?.Value,
            //     RoleId = role.RoleId,
            //     Role = role

            // };

            return user;

        }
        return null;
    }

    
}

public interface IUserService{
    IEnumerable<User> Get(User user);
    public User Authenticate(string email, string password);
    User? GetUserContext(HttpContext context);
    User Get(string email);
}