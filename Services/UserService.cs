using System.Runtime.Serialization;
using System.Security.Claims;
using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


namespace ElectroShop.Services;

public class UserService:IUserService
{
    ElectroShopContext context;
    IRoleService roleService ;
    IWAService wAService;
    public UserService(ElectroShopContext context, IRoleService roleService,IWAService wAService)
    {
        this.context = context; 
        this.roleService = roleService; 
        this.wAService = wAService;
    }
    public IEnumerable<User> Get(User user){
        return context.Users.Include(p=>p.Role).Where(p=>p.Email==user.Email);
    }

    public User Get(string email){
        return context.Users.Include(p=>p.Role).FirstOrDefault(p=>p.Email==email);
    }

    public User Get (Guid id){
        return context.Users.Find(id);
    }
    public User? Authenticate(string email, string password){
        return  context.Users.Include(p=>p.Role)
                .Include(p=>p.Carts.Where(o=>o.PurchaseId==Guid.Empty))
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

    public async  Task<Guid> Save(User user)
    {
        
        
            if(context.Users.FirstOrDefault(p=>p.Email==user.Email || p.PhoneNumber==user.PhoneNumber)==null){
                user.UserId= new Guid();
                user.PhoneValidatedAt=null;

                context.Add(user);
                context.SaveChanges();
                await this.TriggerWhatsappValidation(user);

                return user.UserId;
            }else{
                throw new Exception("Email or phone already exists");
            }
        
    }

    public bool Update(Guid id, User user)
    {
        User currentUser = context.Users.Find(id);
        
        if(currentUser!=null){
            if(context.Users.FirstOrDefault(p=>p.UserId!=id && p.Email==user.Email)!=null){
                throw new Exception("Phone is already in use.");
            }
            currentUser.Surname= user.Surname;
            currentUser.Name = user.Name;
            currentUser.Password = user.Password;
            if (user.PhoneNumber!=currentUser.PhoneNumber){
                currentUser.PhoneNumber= user.PhoneNumber;
                currentUser.PhoneValidatedAt=null;          //if the phone is updated then it should be validated

                //TODO - add phone validation bot process
            }

            context.SaveChanges();
            return true;
        }else return false;
    }

    public User? GetByPhone(string number)
    {
        return context.Users.FirstOrDefault(p=>p.PhoneNumber==number);

    }

    private async Task<bool> TriggerWhatsappValidation (User user)
    {
        HttpResponseMessage response = await wAService.startValidation(user);
        return response.IsSuccessStatusCode;
    }

 
}


public interface IUserService{
    IEnumerable<User> Get(User user);
    User Get(Guid id);
    public User Authenticate(string email, string password);
    User? GetUserContext(HttpContext context);
    User Get(string email);
    User GetByPhone(string number);
    Task<Guid> Save (User user);
    bool Update(Guid id, User user);
}