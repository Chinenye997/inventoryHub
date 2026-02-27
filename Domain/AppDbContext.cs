using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Domain
{
    // Database context for EF Core
    public class AppDbContext : IdentityDbContext  //Inherits EF's DbContext (database handler).
    {
        // Constructor - required for EF Core
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }                                //Constructor takes config
                                                                                                                       //(e.g., connection string).

        // DbSets - one for each table/entity
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users {  get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StockAdjustment> StockAdjustmentsx { get; set; }
        public DbSet<ItemIssuance> ItemIssuances { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        // This method runs automatically when EF Core builds the database model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call the base method first
            base.OnModelCreating(modelBuilder);

            // Seed the 3 default roles (this is what creates them automatically)
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = "1",                    // Fixed ID for Admin
                    Name = "Admin",
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                },
                new Role
                {
                    Id = "2",                    // Fixed ID for Staff
                    Name = "Staff",
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                },
                new Role
                {
                    Id = "3",                    // Fixed ID for User
                    Name = "User",
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                }
        
            );

            //var adminUser = new IdentityUser
            //{
            //    UserName = "admin@inventory.com",
            //    Email = "admin@inventory",
            //    EmailConfirmed = true,
            //};

            //adminUser.PasswordHash = new Microsoft.AspNetCore.Identity.PasswordHasher<IdentityUser>()
            //    .HashPassword(adminUser, "Admin123!"); // change this password later

            //modelBuilder.Entity<IdentityUser>().HasData(adminUser);

            //// Link user to Admin role
            //modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            //    new IdentityUserRole<string>
            //    {
            //        UserId = adminUser.Id,
            //        RoleId = "1",    // matches your "Admin" role Id
            //    }
            //);
        }
    }
}
