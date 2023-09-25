
using ElectroShop.Models;
using ElectroShop.Services;

public interface IWebhookWhatsapp{
    IUserService  UserService  { get; set; }
    IWAStatusService WAStatusService { get; set; }
    string Execute(User user, string Message);

}