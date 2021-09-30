using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UiS.Dat240.Lab2
{
    public interface IFoodItemProvider
    {
        Task<FoodItem[]> GetItems();
        Task AddFoodItem(FoodItem item);
        Task<FoodItem> GetFoodItem(int id);
        Task UpdateFoodItem(int id, FoodItem item);
        Task RemoveFoodItem(int id);
    }


    // : inherite from 
    public class FoodItemProvider : IFoodItemProvider
    {
        // ShopContext is where you create the database table
        private readonly ShopContext _db;
        
        public FoodItemProvider (ShopContext db) {
            _db = db;
        }



        public async Task AddFoodItem(FoodItem item)
        {
            _db.FoodItems.Add(item);
            await _db.SaveChangesAsync();
        }

        // green: type value thats gonna return
        // food item with id nr. 
        public async Task<FoodItem> GetFoodItem(int id)
        {
            return await _db.FoodItems.FirstOrDefaultAsync(x => x.Id == id);
        }

        // return list with items
        public async Task<FoodItem[]> GetItems()
        {
            return await _db.FoodItems.ToArrayAsync();
        }

        // check if item id is there. if not null, remove and savechanges. 
        public async Task RemoveFoodItem(int id)
        {
            var foodItem = await _db.FoodItems.FindAsync(id);
            if (foodItem != null) {
                _db.FoodItems.Remove(foodItem);
                await _db.SaveChangesAsync();
            }
        }


        //Just update the info, id remains the same
        public async Task UpdateFoodItem(int id, FoodItem item)
        {
            var foodItem = await _db.FoodItems.FindAsync(id);
            if (foodItem != null) {
                foodItem.Name = item.Name;
                foodItem.Description = item.Description;
                foodItem.Price = item.Price;
                foodItem.CookTime = item.CookTime;
                await _db.SaveChangesAsync();
            }

        }
    }
}
