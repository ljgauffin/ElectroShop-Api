using ElectroShop.Models;

namespace ElectroShop.Constants;

public class Seeds
    {
        public static List<Category> categoriesInit = new()
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

        public static List<Product> productsInit = new()
        {
            new Product() { ProductId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4838c"), Description = "Heladera Ciclica Top Mount Hsi-ct291b 273 Lts Blanca" , CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4831c"), WebDescription = "HELADERA CICLICA TOP MOUNT SIAM HSI-CT291B 273 LTS BLANCA 220V CAMBIO EN EL SENTIDO DE APERTURA DE PUERTAS", Weight=250, Width=20, Height=30,Depth=20, Price=2000, MinimunQuantity=2 },
            new Product() { ProductId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4839c"), Description = "Notebook Lenovo IdeaPad 3i Intel I5" , CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4832c"), WebDescription = "La notebook Lenovo 81X700FVUS es una solución tanto para trabajar y estudiar como para entretenerte. Al ser portátil, el escritorio dejará de ser tu único espacio de uso para abrirte las puertas a otros ambientes ya sea en tu casa o en la oficina.", Weight=0.2, Width=1, Height=7,Depth=5, Price=1000, MinimunQuantity=2 },
            new Product() { ProductId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4840c"), Description = "Auriculares in-ear inalámbricos Wave 100TWS" , CategoryId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4836c"), WebDescription = "El formato perfecto para vos. Al ser in-ear, mejoran la calidad del audio y son de tamaño pequeño para poder insertarse en tu oreja.", Weight=0.8, Width=10, Height=30,Depth=25, Price=500, MinimunQuantity=2 },
           
        };

        public static List<Role> rolesInit = new()
        {
            new Role() {RoleId= Guid.Parse("b3a3096e-4274-4799-a843-380868d4844c"), Description="User" },
            new Role() {RoleId= Guid.Parse("b3a3096e-4274-4799-a843-380868d4845c"), Description="Seller" },
            new Role() {RoleId= Guid.Parse("b3a3096e-4274-4799-a843-380868d4846c"), Description="Admin" }
            
        };

        public static List<User> usersInit = new()
        {
            new User() {UserId= Guid.Parse("b3a3096e-4274-4799-a843-380868d4841c"), Name="Juan", Surname="Perez",Email="juan@perez.com",Password="12345678", RoleId=Guid.Parse("b3a3096e-4274-4799-a843-380868d4844c"), PhoneNumber="455454554", PhoneValidatedAt = DateTime.Now },
            new User() {UserId= Guid.Parse("b3a3096e-4274-4799-a843-380868d4842c"), Name="Pedro", Surname="Gonzales",Email="pedro@gozales.com",Password="12345678", RoleId=Guid.Parse("b3a3096e-4274-4799-a843-380868d4845c"), PhoneNumber="1234567899", PhoneValidatedAt = DateTime.Now},
            new User() {UserId= Guid.Parse("b3a3096e-4274-4799-a843-380868d4843c"), Name="Mario", Surname="Ramirez",Email="Mario@ramirez.com",Password="12345678", RoleId=Guid.Parse("b3a3096e-4274-4799-a843-380868d4846c"), PhoneNumber="1234567878", PhoneValidatedAt = DateTime.Now },
        };

        public static List<Cart> cartsInit = new()
        {
            new Cart() {CartId=Guid.Parse("b3a3096e-4274-4799-a843-380868d4843c"), UserId= Guid.Parse("b3a3096e-4274-4799-a843-380868d4841c"),ProductId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4838c"), DateTime= DateTime.Now },
            new Cart() {CartId=Guid.Parse("b3a3096e-4274-4799-a843-380868d4844c"), UserId= Guid.Parse("b3a3096e-4274-4799-a843-380868d4841c"),ProductId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4839c"), DateTime= DateTime.Now },
            new Cart() {CartId=Guid.Parse("b3a3096e-4274-4799-a843-380868d4845c"), UserId= Guid.Parse("b3a3096e-4274-4799-a843-380868d4841c"),ProductId = Guid.Parse("b3a3096e-4274-4799-a843-380868d4840c"), DateTime= DateTime.Now }    
            
         };

        
    }