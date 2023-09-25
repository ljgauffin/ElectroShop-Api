
using ElectroShop.Models;
using ElectroShop.Services;
using ElectroShop.Constants;

public class WaitingForValidation : IWebhookWhatsapp
{
 
    public IUserService  UserService  { get; set; }
    public IWAStatusService WAStatusService { get; set; }
    public string Execute (User user, string Message){
        WAStatus currentStatus = WAStatusService.Get(user.PhoneNumber);
        if(currentStatus.NumberOfTries > 2)
        {
            return WAMessages.ErrorValidatingEmail;
        }

        if (user.Email==Message){
            user.PhoneValidatedAt=DateTime.Now;
            UserService.Update(user.UserId,user);
            WAStatusService.Delete(user.PhoneNumber);
            
            return WAMessages.EmailValidatedSuccesfully;
        }else{
            currentStatus.NumberOfTries ++; 
            WAStatusService.Update(currentStatus);
            return WAMessages.EmailNotFound;
        }
        
    }


}