// lage payment.cs
namespace UiS.Dat240.Lab3.Core.Domain.Invoicing{
    public class Payment    {
        public Payment(int id, int amount)
        {
            Id = id;
            Amount = amount;
        }
        public int Id { get; protected set; }
        public int Amount { get; protected set; }
       

        
    }
}
