using ElectroShop.Models;

namespace ElectroShop.Constants;

public class WAConstants
    {

        public static string token = "HAPPY";
        public static string WAId = "123178304216809";
        public static string WAToken = "EAAmruZBfhruoBOyCHXntK9LCZCZBJTDCiUqeuIAhFaCgnDc34B0NdQGUHvSgZBv4hEUCsmL0Q8MEmjgwHRFcy2IOUh3jnzWddM77d8euBluCY311aVvY70kJpz0Qi3mEDqoJbNw7KmetrVLKMSzh5c9EzZCcMTKtjd0WVdU8ZCrZBvrGg8H4NyZAnyUBMXJlVBvDh4Y1pO0GYZBZCe7c5uLsAZD";
        public static string requestBody = $@"
                {{
                  ""messaging_product"": ""whatsapp"",
                  ""recipient_type"": ""individual"",
                  ""to"": """",
                  ""type"": ""text"",
                  ""text"": {{
                    ""preview_url"": false,
                    ""body"": """"
                  }}
                }}
            ";
        public static string endpointUrl = $"https://graph.facebook.com/v18.0";
        
    }

public class WAMessages{
        public static string GeneralError = "No pudimos procesar el mensaje, intente luego nuevamente.";
        public static string UserNotFound = "Hola, soy ElectroBot! No tengo tu teléfono agendado. Ingresá a ElectroShop para crear tu nuevo usuario o configurar tu numeor de teléfono en tu usuario existente.";
        public static string EmailNotFound = "Error en validación, intente nuevamente.";
        public static string FirstGreeteng = "Hola! Tu telefono está validado correctamente. Pronto podrás consultar cosas como envíos pendientes, productos y mas!.";
        public static string ErrorValidatingEmail = "Ha superado la cantidad de intentos permitidos. Inicie el proceso de validación desde la web.";
        public static string EmailValidatedSuccesfully = "Tu telefono fue validado! Ahora podrás consultar tus carritos y envíos pendientes por éste medio.";

}

public class WAStatus{
        public static string WAITING_FOR_VALIDATION = "WAITING_FOR_VALIDATION";
      

}