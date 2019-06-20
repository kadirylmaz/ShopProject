using Microsoft.EntityFrameworkCore;
using ShopProject.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.DataAccess.Concrete.EntityFramework
{
    public class ShopContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-4IMGOMO\KADIR; Database=ShopProjectDb; Integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .HasKey(x => new { x.OrderID, x.ProductID });
        }
        public DbSet<MenuItem> MenuItems  { get; set; }

        public DbSet<SubMenu> SubMenus { get; set; }

        public DbSet<SubSubMenu> SubSubMenus { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Shipper> Shippers { get; set; }

        public DbSet<Customer> Customers { get; set; }
       
    }
}
