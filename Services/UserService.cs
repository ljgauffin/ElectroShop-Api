using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;


namespace ElectroShop.Services;

public class UserService:IUserService
{
    ElectroShopContext context;
    public UserService(ElectroShopContext context)
    {
        this.context = context; 
    }
    public IEnumerable<User> Get(User user){
        return context.Users.Include(p=>p.Role).Where(p=>p.Email==user.Email);
    }
    public User Authenticate(string email, string password){
        return  context.Users.Include(p=>p.Role).FirstOrDefault(p => p.Email == email && p.Password == password);
    }

    
}

public interface IUserService{
    IEnumerable<User> Get(User user);
    public User Authenticate(string email, string password);
}