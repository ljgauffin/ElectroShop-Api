
using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectroShop.Services;

public class CategoryService: ICategoryService
{
    ElectroShopContext context;
    public CategoryService(ElectroShopContext context)
    {
        this.context = context; 
    }

    public IEnumerable<Category> Get(){
        return context.Categories;
    }
    public IEnumerable<Category> Get(Guid id){
        return context.Categories.Where(p=>p.CategoryId ==id);
    }
    

}


public interface ICategoryService{
    IEnumerable<Category> Get();
    IEnumerable<Category> Get(Guid id);
    

}