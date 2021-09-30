using Microsoft.EntityFrameworkCore;
using System.IO;
using System;


namespace UiS.Dat240.Lab2
{
    // This class should inherit from the EntityFramework DbContext
    public class ShopContext : DbContext
    {
       /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Shop.db");
        } */
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {}
        public DbSet<FoodItem> FoodItems {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            /*FakeData.Init();

            modelBuilder.Entity<FoodItem>().HasData(FakeData.FoodItems);*/
        }

        public string DbPath {get; private set;}
    }
}