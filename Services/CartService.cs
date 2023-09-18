using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

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
        return context.Carts.Include(p=>p.Product).Where(p=>p.UserId==user.UserId && p.PurchaseId==Guid.Empty);
    }

    public bool Update(Guid id, Cart cart){
        var currentCart = context.Carts.Find(id);
        
        if(currentCart!=null){
            currentCart.Quantity= cart.Quantity;
            currentCart.DateTime= DateTime.Now;

             context.SaveChanges();
             return true;

        }
        else return false;
        
    }

    public  Guid Save(Cart cart){

        Guid id = this.Exists(cart);

        if (id!=Guid.Empty){

            this.Update(id,cart);
            return id;

        }else{
            cart.CartId= Guid.NewGuid();
            cart.DateTime = DateTime.Now;
            
            context.Add(cart);
            context.SaveChanges();
            return cart.CartId;
        }
        


    }

    private Guid Exists(Cart cart){
        Cart currentCart = context.Carts.FirstOrDefault(p=>p.UserId==cart.UserId&& p.ProductId==cart.ProductId && cart.PurchaseId==Guid.Empty);
        if (currentCart!=null){
            return currentCart.CartId;
        }else return Guid.Empty;
       

    }

   
    

}


public interface ICartService{
    IEnumerable<Cart> Get();
    IEnumerable<Cart> Get(User user);
    bool Update(Guid id, Cart cart);
    Guid Save(Cart cart);
    

}