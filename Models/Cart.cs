using System.Data.SqlTypes;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using Microsoft.Identity.Client;

namespace ElectroShop.Models;

public class Cart
{
    public Guid CartId { get; set; }

    public Guid UserId { get; set; }
    public Guid ProductId { get; set; }
    public Guid PurchaseId { get; set; }
    public DateTime DateTime { get; set; }
    public int Quantity { get; set; }


    
     public virtual Product Product { get; set; }
     [JsonIgnore]
     public virtual User User { get; set; }


}