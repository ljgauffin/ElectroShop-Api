using System.Net.Http.Headers;
using System.Text.Json.Serialization;

namespace ElectroShop.Models;

public class Category
{
    public Guid CategoryId { get; set; }
    public string Description { get; set; }

    [JsonIgnore]
    public virtual ICollection<Product> Products { get; set; }
}