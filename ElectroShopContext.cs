using ElectroShop.Models;
using Microsoft.EntityFrameworkCore;


namespace ElectroShop;

public class ElectroShopContext: DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users {get; set;}
    public DbSet<Cart> Carts {get; set;}


    public ElectroShopContext(DbContextOptions<ElectroShopContext> options): base (options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Seed data-----------------------------
        List<Category> categoriesInit = Constants.Seeds.categoriesInit;
        

        List<Product> productsInit = Constants.Seeds.productsInit;

        List<Role> rolesInit = Constants.Seeds.rolesInit;

        List<User> usersInit = Constants.Seeds.usersInit;

        List<Cart> cartsInit = Constants.Seeds.cartsInit;
        

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
            product.Property(p=>p.Price).IsRequired().HasColumnType("DECIMAL").HasPrecision(15,2);
            product.HasData(productsInit);


        });
        modelBuilder.Entity<Role>(role=>{
            role.ToTable("Roles");
            role.HasKey(p=>p.RoleId);
            role.Property(p=>p.Description).IsRequired().HasMaxLength(20);
            role.HasData(rolesInit);
            
           

        });

        modelBuilder.Entity<User>(user=>{
            user.ToTable("Users");
            user.HasKey(p=>p.UserId);
            user.HasOne(p=>p.Role).WithMany(p=>p.Users).HasForeignKey(p=>p.RoleId).IsRequired(false);
            user.Property(p=>p.Name).IsRequired().HasMaxLength(20);
            user.Property(p=>p.Surname).IsRequired().HasMaxLength(20);
            user.HasAlternateKey(p=>p.Email);
            user.Property(p=>p.RoleId).IsRequired();
            user.Property(p=>p.Password).IsRequired().HasMaxLength(20);
            user.HasData(usersInit);

        });

         modelBuilder.Entity<Cart>(cart=>{
            cart.ToTable("Carts");
            cart.HasKey(p=>p.CartId);
            cart.HasOne(p=>p.Product).WithMany(p=>p.Carts).HasForeignKey(p=>p.ProductId);
            cart.HasOne(p=>p.User).WithMany(p=>p.Carts).HasForeignKey(p=>p.UserId);
            cart.Property(p=>p.DateTime).IsRequired();
            cart.Property(p=>p.Quantity).IsRequired();
            cart.HasData(cartsInit);

        });

    }
    
}