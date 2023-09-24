
using System.Security.Claims;
using System.Text;
using System.Text.Json.Nodes;
using ElectroShop.Models;
using ElectroShop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace ElectroShop.Controllers;

[Route("api/[controller]")]
public class WAController: ControllerBase
{
    
    IWAService wAService;
    IWAHandlerService wAHandlerService;
    private readonly ILogger<ProductController> logger;

    public WAController(IWAService wAService,IWAHandlerService wAHandlerService)
    {
        this.wAService = wAService;
        this.wAHandlerService = wAHandlerService;
    }

    [HttpGet]
    public IActionResult Get(){
        try 
        {
            string mode = HttpContext.Request.Query["hub.mode"];
            string challenge = HttpContext.Request.Query["hub.challenge"];
            string token = HttpContext.Request.Query["hub.verify_token"];
            string verify_token = Constants.WAConstants.token;
            if(!token.IsNullOrEmpty() && !mode.IsNullOrEmpty())
            {
                if(mode=="subscribe" && token == verify_token)
                {
                    return Ok(challenge);
                }else{
                    return StatusCode(403);
                }

            }else{
                return StatusCode(422);
            }

            return Ok(verify_token);

        }
        catch(Exception){
            return StatusCode(500);
          
        }
    }  


    [HttpPost]
    public async Task<IActionResult> Post(){
        string? number ;
        string message;
        string body;
        

        try
        {
            using (var reader = new StreamReader(Request.Body))
            {
                body = await reader.ReadToEndAsync();
                // 'body' contiene el contenido del cuerpo de la solicitud

                // logger.LogError(body);
                
            
            }

            JsonNode bodyNode = JsonNode.Parse(body);
            number = bodyNode["entry"]![0]!["changes"]![0]!["value"]!["messages"]![0]!["from"]!.GetValue<string>();
            number= number.Substring(0,2)=="54"?  number.Remove(2,1):number;


            message = bodyNode["entry"]![0]!["changes"]![0]!["value"]!["messages"]![0]!["text"]!["body"].GetValue<string>();

            Console.WriteLine($"NUMEROOO: {number} --- Mensajeee: {message}");

            string outgoingMessagne = wAHandlerService.Handle(number,"text",message);
            Console.WriteLine(outgoingMessagne);
           
            // Define los datos de la solicitud en formato JSON
            string requestBody =  wAService.getTextMessageInput(number,outgoingMessagne);


            Console.WriteLine(requestBody);

            HttpResponseMessage response = await wAService.sendMessage(requestBody);

            
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al realizar la solicitud: {ex.Message}");
        }

        

        Console.WriteLine("LLEGO MENSAJE--------------------------------------------");
        return Ok();
    }    
}



// // Accepts GET requests at the /webhook endpoint. You need this URL to setup webhook initially.
// // info on verification request payload: https://developers.facebook.com/docs/graph-api/webhooks/getting-started#verification-requests
// whatsappController.get('/webhook', (req, res) => {
//   const verify_token = process.env.WA_VERIFY_TOKEN

//   // Parse params from the webhook verification request
//   const mode = req.query['hub.mode']
//   const token = req.query['hub.verify_token']
//   const challenge = req.query['hub.challenge']

//   // Check if a token and mode were sent
//   if (mode && token) {
//     // Check the mode and token sent are correct
//     if (mode === 'subscribe' && token === verify_token) {
//       // Respond with 200 OK and challenge token from the request
//       res.status(200).send(challenge)
//     } else {
//       // Responds with '403 Forbidden' if verify tokens do not match
//       res.sendStatus(403)
//     }
//   }
// })

