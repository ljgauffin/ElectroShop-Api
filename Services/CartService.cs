using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectroShop.Services;

public class CartService: ICartService
{
    ElectroShopContext context;
    public CartService(ElectroShopContext context)
    {
        this.context = context; 
    }

    public IEnumerable<Cart> Get(){
        return context.Carts.Include(p=>p.Product);
    }
    public IEnumerable<Cart> Get(User user){
        return context.Carts.Include(p=>p.Product).Where(p=>p.UserId==user.UserId);
    }
    

}


public interface ICartService{
    IEnumerable<Cart> Get();
    IEnumerable<Cart> Get(User user);
    

}