using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using System.IO;
using System;

=======
>>>>>>> parent of 098f4b6... commit operation

namespace UiS.Dat240.Lab2
{
    // This class should inherit from the EntityFramework DbContext
    public class ShopContext
    {
<<<<<<< HEAD
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
=======
        
>>>>>>> parent of 098f4b6... commit operation
    }
}