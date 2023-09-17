

using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectroShop.Services;

public class RoleService: IRoleService
{
    ElectroShopContext context;
    public RoleService(ElectroShopContext context)
    {
        this.context = context; 
    }

    public IEnumerable<Role> Get(){
        return context.Roles;
    }
    public Role? Get(Guid id){
        return context.Roles.FirstOrDefault(p=>p.RoleId ==id);
    }
    public Role? Get(String roleDescription){
        return context.Roles.FirstOrDefault(p=>p.Description ==roleDescription);
    }


    

}


public interface IRoleService{
    IEnumerable<Role> Get();
    Role? Get(Guid id);
    Role? Get(String roleDescription);
}