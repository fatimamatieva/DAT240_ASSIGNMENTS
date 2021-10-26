using UiS.Dat240.Lab3.SharedKernel;

namespace UiS.Dat240.Lab3.Core.Domain.Fulfillment
{
    public class Shipper : BaseEntity
    {
        public Shipper(string name, int id)
        {

            Name = name;
            Id = id;


        }
        public int Id { get; protected set; }
        public string Name { get; set; }
    }
}