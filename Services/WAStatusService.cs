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

    public void  Update(WAStatus wAStatus)
    {
        WAStatus currentStatus = context.WAStatus.FirstOrDefault(p=>p.PhoneNumber == wAStatus.PhoneNumber);
        if(currentStatus !=null)
        {
            currentStatus.NumberOfTries= wAStatus.NumberOfTries;
            currentStatus.Status= wAStatus.Status;
            currentStatus.Email= wAStatus.Email;
            context.SaveChanges();
        }

    }

    public WAStatus? Get(string number)
    {
        WAStatus status = context.WAStatus.FirstOrDefault(p=>p.PhoneNumber==number);
        return status;
    }

    public bool Delete(string number)
    {
        WAStatus status = context.WAStatus.FirstOrDefault(p=>p.PhoneNumber==number);
        if(status!=null)
        {
            context.WAStatus.Remove(status);
            context.SaveChanges();
            return true;
        }
        return false;
    }
}


public interface IWAStatusService{
    WAStatus? getCurrentStatus(string number);
    void Create(string status, User user);
    void Update(WAStatus wAStatus);
    WAStatus? Get(string number);
    bool Delete(string number);
}