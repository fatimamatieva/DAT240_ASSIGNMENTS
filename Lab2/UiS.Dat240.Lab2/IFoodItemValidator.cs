﻿using System.Collections.Generic;

namespace UiS.Dat240.Lab2
{
    public interface IFoodItemValidator
    {
        string[] IsValid(FoodItem foodItem);
    }



    public class FoodItemValidator : IFoodItemValidator
    {

    }
}
