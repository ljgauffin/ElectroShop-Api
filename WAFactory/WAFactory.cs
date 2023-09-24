using ElectroShop.Services;
using ElectroShop.Constants;
using System.Reflection.Metadata;
using System;
using System.Collections.Generic;


public  class WAWebhookFactory
{
    private static readonly Dictionary<string, Dictionary<string, Type>> webhooks = new Dictionary<string, Dictionary<string, Type>>
        {
            ["text"] = new Dictionary<string, Type>
            {
                [ElectroShop.Constants.WAStatus.WAITING_FOR_VALIDATION] = typeof(WaitingForValidation)
            }
        };
    private static WAWebhookFactory instance = null;

    public static WAWebhookFactory getInstance(){
        if (instance ==null){
            instance = new WAWebhookFactory();
        }
        return instance;
    }

    public IWebhookWhatsapp? Create (string status, string type)
    {
        if (webhooks.ContainsKey(type) && webhooks[type].ContainsKey(status))
            {
                var webhookType = webhooks[type][status];
                return (IWebhookWhatsapp)Activator.CreateInstance(webhookType);
            }
            else
            {
                return new NotFoundWhatsappMessage();
            }

    }


}