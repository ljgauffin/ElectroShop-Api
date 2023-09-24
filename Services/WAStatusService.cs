using System.Runtime.Serialization;
using System.Security.Claims;
using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ElectroShop.Constants;
using System.Text;

namespace ElectroShop.Services;

public class WAStatusService:IWAStatusService
{

    ElectroShopContext context;
    // IUserService userService ;


    public WAStatusService(ElectroShopContext context)
    {
        this.context = context; 
        // this.userService = userService; 
    }
    public WAStatus? getCurrentStatus(string number)
    {
        return context.WAStatus.FirstOrDefault(p=>p.PhoneNumber==number);
    }

    public void Create(string status, User user)
    {
        context.WAStatus.Add(new WAStatus (){
            PhoneNumber = user.PhoneNumber,
            Status = Constants.WAStatus.WAITING_FOR_VALIDATION,
            NumberOfTries = 0,
            Email = null,
        });

        context.SaveChanges();

    }
}


public interface IWAStatusService{
    WAStatus? getCurrentStatus(string number);
    void Create(string status, User user);
}