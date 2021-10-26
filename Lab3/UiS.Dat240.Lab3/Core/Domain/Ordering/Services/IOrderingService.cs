//using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using UiS.Dat240.Lab3.Core.Domain.Ordering;
using UiS.Dat240.Lab3.Core.Domain.Ordering.Dto;
using UiS.Dat240.Lab3.Core.Domain.Products;
using UiS.Dat240.Lab3.Infrastructure.Data;
using UiS.Dat240.Lab3.Core.Exceptions;
using UiS.Dat240.Lab3.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using static UiS.Dat240.Lab3.Core.Domain.Cart.Pipelines.AddItem;

namespace UiS.Dat240.Lab3.Core.Domain.Ordering.Services
{
    public interface IOrderingService


    {
        Task<int> PlaceOrder(Location location, string customerName, OrderLineDto[] orderLines);
    }
    public class OrderingService : IOrderingService
    {
       
        
        public OrderingService(ShopContext db)
        {
            _db = db;
        }

        private readonly ShopContext _db;
        

        public async Task<int> PlaceOrder(Location location, string customerName, OrderLineDto[] orderLines)
        {
                var newOrder = new Order(location, new Customer(customerName), "");
                foreach (var orderline in orderLines)
                {
                    newOrder.AddOrderLine(orderline.FoodItemId, orderline.Price, orderline.Amount);
                }
                var customer = await _db.Customers.SingleOrDefaultAsync(i => i.Name == customerName);

                if (customer == null){
                    var newCustomer = new Customer(customerName);
                    _db.Customers.Add(newCustomer);
                    newOrder.Customer = newCustomer;
                }else
                {
                    newOrder.Customer = customer;
                }

                
                
        
                _db.Add(newOrder);
                await _db.SaveChangesAsync();
                return newOrder.Id; 
        }
    }

}

