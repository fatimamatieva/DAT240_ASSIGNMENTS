namespace UiS.Dat240.Lab3.Core.Domain.Fulfillment
{
    public class Reimbursement
    {
        public Reimbursement(string name, int id, int amount, int invoiceId)
        {

            Name = name;
            Id = id;
            Amount = amount;
            InvoiceId = invoiceId;
            


        }
        public int Id { get; protected set; }
        public string Name { get; set; }
        public int Amount{get; set;}
        public int InvoiceId{get; set;}
        public Shipper? Shipper{get; set;}


    }
}