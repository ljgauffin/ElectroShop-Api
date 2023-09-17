
namespace ElectroShop.Models;

public class User
{
    public Guid UserId { get; set; }  
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password {get;set;}

    public Guid RoleId { get; set; }
    
    public virtual Role? Role {get;set;}

}

// public enum Role
// {
//     Admin,
//     User,
//     Seller

// }

