using System.Runtime.Serialization;
using System.Security.Claims;
using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ElectroShop.Constants;
using System.Text;

namespace ElectroShop.Services;

public class WAHandlerService:IWAHandlerService
{

    
    IUserService userService ;
    IWAStatusService wAStatusService;
    IWAWebhookFactory wAWebhookFactory;


    public WAHandlerService(IUserService userService,IWAStatusService wAStatusService,IWAWebhookFactory wAWebhookFactory)
    {
        this.userService = userService;
        this.wAStatusService = wAStatusService;
        this.wAWebhookFactory = wAWebhookFactory;
        
    }

    public string Handle (string number, string type, string message)
    {
        User user = userService.GetByPhone(number);
        WAStatus status = wAStatusService.getCurrentStatus(number);

        Console.WriteLine (user);
        Console.WriteLine (status);
        if(user ==null)
        {
            return  Constants.WAMessages.UserNotFound;
        }else if (status==null) //user doesnt have a pending status
        {
            return  Constants.WAMessages.FirstGreeteng;
        }
        return wAWebhookFactory.Create(status.Status, type).Execute(user,message);
        // return "no entiendo nadsa";

    }
}


public interface IWAHandlerService{
    string Handle (string number, string type, string message);
}