using ElectroShop.Models;
using ElectroShop.Services;

 public class NotFoundWhatsappMessage:IWebhookWhatsapp
{

    public IUserService  UserService  { get; set; }
    public IWAStatusService WAStatusService { get; set; }
     public string Execute (User user, string Message){
        return "mensaje2";
        
    }
    
}