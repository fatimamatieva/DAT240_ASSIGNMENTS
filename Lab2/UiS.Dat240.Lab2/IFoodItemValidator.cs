using System.Collections.Generic;

namespace UiS.Dat240.Lab2
{
    public interface IFoodItemValidator
    {
        string[] IsValid(FoodItem foodItem);
    }


    // Both name and description should contain a value which is not only whitespaces
    // The price must be greater than 0.
    public class FoodItemValidator : IFoodItemValidator
    {
        public string[] IsValid(FoodItem foodItem)
        {
            List<string> errors = new List<string>();
            if (string.IsNullOrWhiteSpace(foodItem.Name)) {
                errors.Add("Name cannot contain whitespaces");
                
            }
            if (string.IsNullOrWhiteSpace(foodItem.Description)) {
                errors.Add("Description cannot contain whitespaces");
            }
            if (foodItem.CookTime < 0) {
                errors.Add("Cooktime cannot be less than 0");
            }
            if (foodItem.Price <= 0) {
                errors.Add("Price cannot be less than 0");
            }
            return errors.ToArray();


        }
    }
}
