

using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectroShop.Services;

public class ProductService: IProductService
{
    ElectroShopContext context;
    public ProductService(ElectroShopContext context)
    {
        this.context = context; 
    }

    public IEnumerable<Product> Get(){
        return context.Products.Include(p=>p.Category);
    }
    public IEnumerable<Product> Get(Guid id){
        return context.Products.Include(p=>p.Category).Where(p=>p.ProductId ==id);
    }

}


public interface IProductService{
    IEnumerable<Product> Get();
    IEnumerable<Product> Get(Guid id);

}