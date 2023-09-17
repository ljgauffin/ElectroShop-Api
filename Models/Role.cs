using System.Text.Json.Serialization;

namespace ElectroShop.Models;

public class Role{
    public Guid RoleId { get; set; }
    public string Description { get; set; }
    [JsonIgnore]
    public virtual IEnumerable<User> Users { get; set; }
}