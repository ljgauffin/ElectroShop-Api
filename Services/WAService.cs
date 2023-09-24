using System.Runtime.Serialization;
using System.Security.Claims;
using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ElectroShop.Constants;
using System.Text;

namespace ElectroShop.Services;

public class WAService:IWAService
{

    ElectroShopContext context;
    // IUserService userService ;

    IWAStatusService wAStatusService;
    
    private string endpointUrl = $"{Constants.WAConstants.endpointUrl}/{Constants.WAConstants.WAId}/messages";

 
    private string accessToken = Constants.WAConstants.WAToken;


    public WAService(ElectroShopContext context,IWAStatusService wAStatusService)
    {
        this.context = context; 
        // this.userService = userService;
        
        this.wAStatusService = wAStatusService;
    }

    // public string Handle (string number, string type, string message)
    // {
    //     User user = userService.GetByPhone(number);
    //     WAStatus status = wAStatusService.getCurrentStatus(number);
    //     if(user ==null)
    //     {
    //         return  Constants.WAMessages.UserNotFound;
    //     }else if (status==null) //user doesnt have a pending status
    //     {
    //         return  user.Name + Constants.WAMessages.FirstGreeteng;
    //     }
    //     return WAWebhookFactory.getInstance().Create(Constants.WAStatus.WAITING_FOR_VALIDATION, type).Execute(user,message);

    // }



    public string getTextMessageInput (string number, string message)
    {
        return $@"
                {{
                  ""messaging_product"": ""whatsapp"",
                  ""recipient_type"": ""individual"",
                  ""to"": ""{number}"",
                  ""type"": ""text"",
                  ""text"": {{
                    ""preview_url"": false,
                    ""body"": ""{message}""
                  }}
                }}
            ";

    }

    public async Task<HttpResponseMessage> sendMessage(string requestBody)
    {
        // Crea una instancia de HttpClient
            using (var httpClient = new HttpClient())
        {
            // Configura el encabezado de autorización
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

            // Crea el contenido de la solicitud y establece el encabezado "Content-Type"
            var content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            // Realiza una solicitud POST al endpoint
            HttpResponseMessage response = await httpClient.PostAsync(endpointUrl, content);

            return response;
        }  
          
    }

    public async Task<HttpResponseMessage> startValidation(User user)
    {
        string requestBody = this.getValidateUserMessage(user.PhoneNumber,user.Name);
        HttpResponseMessage response = await this.sendMessage(requestBody);
        if(response.IsSuccessStatusCode){
            wAStatusService.Create(Constants.WAStatus.WAITING_FOR_VALIDATION,user);
        }
        return response;
    }

    public string getValidateUserMessage (string number, string name)
    {
            return $@"
                    {{
                        ""messaging_product"": ""whatsapp"",
                        ""to"": ""{number}"",
                        ""type"": ""template"",
                        ""template"": {{
                            ""name"": ""validate_user"",
                            ""language"": {{
                                ""code"": ""es_AR""
                            }},
                            ""components"": [
                                {{
                                    ""type"": ""body"",
                                    ""parameters"": [
                                        {{
                                            ""type"": ""text"",
                                            ""text"": ""{name}""
                                        }}
                                    ]
                                }}
                            ]
                        }}
                    }}
                    ";


    }
}


public interface IWAService{
    // string Handle (string number, string type, string message);
    string getTextMessageInput (string number, string message);
    Task<HttpResponseMessage> sendMessage(string requestBody);
    Task<HttpResponseMessage> startValidation(User user);

}