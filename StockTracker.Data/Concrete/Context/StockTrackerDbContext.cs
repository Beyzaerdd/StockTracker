using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StockTracker.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracker.Data.Concrete.Context
{
    public class StockTrackerDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public StockTrackerDbContext(DbContextOptions<StockTrackerDbContext> options) : base(options)
        {
        }

        // Tablolar
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<RentalItem> RentalItems { get; set; }
        public DbSet<DeliveredItem> DeliveredItems { get; set; }
        public DbSet<RemainingItem> RemainingItems { get; set; }
        public DbSet<AccountTransaction> AccountTransactions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<AccountSummary> AccountSummaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Rentals)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.CustomerId);

       
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Payments)
                .WithOne(p => p.Customer)
                .HasForeignKey(p => p.CustomerId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Rentals)
                .WithOne(r => r.Employee)
                .HasForeignKey(r => r.EmployeeId);

         
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Payments)
                .WithOne(p => p.Employee)
                .HasForeignKey(p => p.EmployeeId);


            modelBuilder.Entity<ApplicationRole>().HasData(
               new ApplicationRole { Id = "115c7796-cfac-44de-91b5-916eaae125b5", Name = "AdminUser", NormalizedName = "ADMINUSER", Description = "Administrator role" },
               new ApplicationRole { Id = "811f466c-9d06-43f8-a054-24aedbb4161b", Name = "NormalUser", NormalizedName = "NORMALUSER", Description = "Regular user role" }
           );

            // Default users
            var hasher = new PasswordHasher<ApplicationUser>();
            var adminUser = new ApplicationUser
            {
                Id = "c0b7fef7-df2b-4857-9b3d-bc8967ad19ac",
                UserName = "mehmet@gmail.com",
                NormalizedUserName = "mehmet@GMAIL.COM",
                Email = "adminuser@gmail.com",
                NormalizedEmail = "ADMINUSER@GMAIL.COM",
                EmailConfirmed = true,
                FirstName = "Admin",
                LastName = "User",
                PhoneNumber = "5255",
                PasswordHash = hasher.HashPassword(null, "Qwe123.,")
            };
            var adminUser2 = new ApplicationUser
            {
                Id = "14a0183f-1e96-4930-a83d-6ef5f22d8c09",
                UserName = "normaluser@gmail.com",
                NormalizedUserName = "admin@GMAIL.COM",
                Email = "normaluser@gmail.com",
                NormalizedEmail = "admin@GMAIL.COM",
                EmailConfirmed = true,
                FirstName = "Admin2",
                LastName = "User",
             
                PasswordHash = hasher.HashPassword(null, "Qwe123.,")
            };
            modelBuilder.Entity<ApplicationUser>().HasData(adminUser, adminUser2);

            // Assign roles to users
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = adminUser.Id, RoleId = "115c7796-cfac-44de-91b5-916eaae125b5" },
                new IdentityUserRole<string> { UserId = adminUser2.Id, RoleId = "811f466c-9d06-43f8-a054-24aedbb4161b" }
            );
            modelBuilder.Entity<Customer>().HasData(
       new Customer { Id = 1, Name = "Ali Yılmaz", Phone = "555-111-2233", Email = "ali@example.com", Address = "İstanbul" },
       new Customer { Id = 2, Name = "Mehmet Demir", Phone = "555-222-3344", Email = "mehmet@example.com", Address = "Ankara" },
       new Customer { Id = 3, Name = "Ayşe Çelik", Phone = "555-333-4455", Email = "ayse@example.com", Address = "İzmir" },
       new Customer { Id = 4, Name = "Zeynep Korkmaz", Phone = "555-444-5566", Email = "zeynep@example.com", Address = "Bursa" },
       new Customer { Id = 5, Name = "Mustafa Kaya", Phone = "555-555-6677", Email = "mustafa@example.com", Address = "Antalya" }
   );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, FullName = "Ahmet Karaca", Phone = "544-123-4567", Email = "ahmet@example.com", Position = "Satış Temsilcisi", Salary = 15000, HireDate = new DateTime(2022, 5, 10), IsActive = true },
                new Employee { Id = 2, FullName = "Elif Yıldız", Phone = "544-234-5678", Email = "elif@example.com", Position = "Muhasebe", Salary = 18000, HireDate = new DateTime(2021, 7, 15), IsActive = true },
                new Employee { Id = 3, FullName = "Caner Doğan", Phone = "544-345-6789", Email = "caner@example.com", Position = "Depo Sorumlusu", Salary = 17000, HireDate = new DateTime(2020, 3, 20), IsActive = true },
                new Employee { Id = 4, FullName = "Gizem Arslan", Phone = "544-456-7890", Email = "gizem@example.com", Position = "Müşteri Temsilcisi", Salary = 16000, HireDate = new DateTime(2019, 8, 5), IsActive = true },
                new Employee { Id = 5, FullName = "Murat Şahin", Phone = "544-567-8901", Email = "murat@example.com", Position = "Teknik Destek", Salary = 14000, HireDate = new DateTime(2023, 1, 10), IsActive = true }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Ahşap Masa", SquareMeters = 2.5, Price = 4500, UnitRentalPrice = 200, Description = "Dayanıklı ve şık ahşap masa" },
                new Product { Id = 2, Name = "Metal Sandalye", SquareMeters = 1.2, Price = 1200, UnitRentalPrice = 100, Description = "Dayanıklı metal sandalye" },
                new Product { Id = 3, Name = "Koltuk Takımı", SquareMeters = 5.0, Price = 15000, UnitRentalPrice = 500, Description = "Konforlu ve geniş koltuk takımı" },
                new Product { Id = 4, Name = "Laminant Parke", SquareMeters = 20.0, Price = 3500, UnitRentalPrice = 150, Description = "Modern laminant parke döşeme" },
                new Product { Id = 5, Name = "Projektör", SquareMeters = 0.5, Price = 5000, UnitRentalPrice = 250, Description = "Yüksek çözünürlüklü projektör" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}

