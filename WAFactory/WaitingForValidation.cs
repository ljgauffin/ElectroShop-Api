
using ElectroShop.Models;
using ElectroShop.Services;
using ElectroShop.Constants;

public class WaitingForValidation : IWebhookWhatsapp
{
    // IUserService userService;
    // IWAStatusService wAStatusService;
    // public WaitingForValidation(IUserService userService,IWAStatusService wAStatusService)
    // {
    //     this.userService = userService;
    //     this.wAStatusService = wAStatusService;
    // }

    public string Execute (User user, string Message){
        if (user.Email==Message){
            // user.PhoneValidatedAt=DateTime.Now;
            // userService.Update(user.UserId,user);
            
            return ElectroShop.Constants.WAMessages.EmailValidatedSuccesfully;
        }else{

            return ElectroShop.Constants.WAMessages.EmailNotFound;
        }
        
    }


}