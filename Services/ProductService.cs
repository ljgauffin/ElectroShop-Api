

using ElectroShop.Models;

namespace ElectroShop.Services;

public class ProductService: IProductService
{
    ElectroShopContext context;
    public ProductService(ElectroShopContext context)
    {
        this.context = context; 
    }

    public IEnumerable<Product> Get(){
        return context.Products;
    }

}


public interface IProductService{

}