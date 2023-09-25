using ElectroShop.Services;
using ElectroShop.Constants;
using System.Reflection.Metadata;
using System;
using System.Collections.Generic;

namespace ElectroShop.Services;
public  class WAWebhookFactory: IWAWebhookFactory
{
    IUserService userService;
    IWAStatusService wAStatusService;

    public WAWebhookFactory(IUserService userService, IWAStatusService wAStatusService)
    {
        this.userService = userService;
        this.wAStatusService =wAStatusService;
        
    }
    private static readonly Dictionary<string, Dictionary<string, Type>> webhooks = new Dictionary<string, Dictionary<string, Type>>
        {
            ["text"] = new Dictionary<string, Type>
            {
                [ElectroShop.Constants.WAStatus.WAITING_FOR_VALIDATION] = typeof(WaitingForValidation)
            }
        };

    
    // private static WAWebhookFactory instance = null;

    // public static WAWebhookFactory getInstance(){
    //     if (instance ==null){
    //         instance = new WAWebhookFactory();
    //     }
    //     return instance;
    // }

    public IWebhookWhatsapp? Create (string status, string type)
    {
        if (webhooks.ContainsKey(type) && webhooks[type].ContainsKey(status))
            {
                var webhookType = webhooks[type][status];
                IWebhookWhatsapp webhook = (IWebhookWhatsapp)Activator.CreateInstance(webhookType);
                webhook.WAStatusService = wAStatusService;
                webhook.UserService = userService;
                return webhook;
            }
            else
            {
                return new NotFoundWhatsappMessage();
            }

    }


}

public interface IWAWebhookFactory{
    IWebhookWhatsapp? Create (string status, string type);

}