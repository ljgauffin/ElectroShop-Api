using System.Data.SqlTypes;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using Microsoft.Identity.Client;

namespace ElectroShop.Models;

public class Product
{
    public Guid ProductId { get; set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }
    public string WebDescription { get; set; }
    public bool Active { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }  
    public double Width { get; set; }
    public double Depth { get; set; }
    public Decimal Price { get; set; }
    public int MinimunQuantity { get; set; }

public Product()
{
    Active=true;
}

    
     public virtual Category Category { get; set; }
}