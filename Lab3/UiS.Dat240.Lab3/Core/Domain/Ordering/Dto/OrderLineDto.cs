using System;
using System.Threading.Tasks;

namespace UiS.Dat240.Lab3.Core.Domain.Ordering.Dto
{
    public record OrderLineDto
    (
        Guid FoodItemId,
        string FoodItemName,
        int Amount,
        decimal Price
    );
}