
using ElectroShop.Models;

public interface IWebhookWhatsapp{
    string Execute(User user, string Message);
}