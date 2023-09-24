using ElectroShop.Models;

 public class NotFoundWhatsappMessage:IWebhookWhatsapp
{
     public string Execute (User user, string Message){
        return "mensaje2";
        
    }
    
}