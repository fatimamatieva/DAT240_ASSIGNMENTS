using System;
using UiS.Dat240.Lab3.SharedKernel;

namespace UiS.Dat240.Lab3.Core.Domain.Ordering{

public class OrderLine
    {
    public OrderLine(Guid item, decimal price, int amount){
        
        Item = item;
        Price = price;
        Amount = amount;

  

    }
    public Guid Item{ get; set;}
    public int Id{ get; protected set;}
    public decimal Price{ get; set;}
    public int Amount{ get; set;}
}
}