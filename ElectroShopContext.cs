using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectroShop;

public class ElectroShopContext: DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }


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

        List<Product> productsInit = new()
        {
            new Product() { ProductId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4838c"), Description = "Heladera Ciclica Top Mount Hsi-ct291b 273 Lts Blanca" , CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4831c"), WebDescription = "HELADERA CICLICA TOP MOUNT SIAM HSI-CT291B 273 LTS BLANCA 220V CAMBIO EN EL SENTIDO DE APERTURA DE PUERTAS", Weight=250, Width=20, Height=30,Depth=20, Price=2000, MinimunQuantity=2 },
            new Product() { ProductId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4839c"), Description = "Notebook Lenovo IdeaPad 3i Intel I5" , CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4832c"), WebDescription = "La notebook Lenovo 81X700FVUS es una solución tanto para trabajar y estudiar como para entretenerte. Al ser portátil, el escritorio dejará de ser tu único espacio de uso para abrirte las puertas a otros ambientes ya sea en tu casa o en la oficina.", Weight=0.2, Width=1, Height=7,Depth=5, Price=1000, MinimunQuantity=2 },
            new Product() { ProductId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4840c"), Description = "Auriculares in-ear inalámbricos Wave 100TWS" , CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4836c"), WebDescription = "El formato perfecto para vos. Al ser in-ear, mejoran la calidad del audio y son de tamaño pequeño para poder insertarse en tu oreja.", Weight=0.8, Width=10, Height=30,Depth=25, Price=500, MinimunQuantity=2 },
           
        };
        

        modelBuilder.Entity<Category>(category =>{

            category.ToTable("Categories");
            category.HasKey(p=>p.CategoryId);
            category.Property(p=>p.Description).IsRequired().HasMaxLength(15);
            category.HasData(categoriesInit);


        });

        modelBuilder.Entity<Product>(product =>{

            product.ToTable("Products");
            product.HasKey(p=>p.ProductId);
            product.Property(p=>p.Description).IsRequired().HasMaxLength(200);
            product.HasOne(p=>p.Category).WithMany(p=>p.Products).HasForeignKey(p=>p.CategoryId);
            product.Property(p=>p.WebDescription).IsRequired().HasMaxLength(1000);
            product.Property(p=>p.Active).HasDefaultValue(true);
            product.Property(p=>p.Price).IsRequired();
            product.HasData(productsInit);


        });

    }
    
}