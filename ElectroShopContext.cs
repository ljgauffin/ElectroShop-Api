using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectroShop;

public class ElectroShopContext: DbContext
{
    public DbSet<Category> Categories { get; set; }


    public ElectroShopContext(DbContextOptions<ElectroShopContext> options): base (options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Seed data-----------------------------
        List<Category> categoriesInit = new()
        {
            new Category() { CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4831c"), Description = "Heladeras" },
            new Category() { CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4832c"), Description = "Notebooks" },
            new Category() { CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4833c"), Description = "Celulares" },
            new Category() { CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4834c"), Description = "Mouses" },
            new Category() { CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4835c"), Description = "Teclados" },
            new Category() { CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4836c"), Description = "Auriculares" },
            new Category() { CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4837c"), Description = "Tablets" },
            new Category() { CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4838c"), Description = "TVs" }
        };
        

        modelBuilder.Entity<Category>(category =>{

            category.ToTable("Categories");
            category.HasKey(p=>p.CategoryId);
            category.Property(p=>p.Description).IsRequired().HasMaxLength(15);
            category.HasData(categoriesInit);


        });

    }
    
}