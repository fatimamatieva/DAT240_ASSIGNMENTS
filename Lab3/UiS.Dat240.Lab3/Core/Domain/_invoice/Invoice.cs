// må lage invoice.cs
using System;
using System.Collections.Generic;
using System.Linq;
using UiS.Dat240.Lab3.SharedKernel;
namespace UiS.Dat240.Lab3.Core.Domain.Invoicing{
    public class Invoice : BaseEntity
    {
        public Invoice(int Id, Customer customer, Address address, int Amount,int OrderId, Status status){

        }
        public int Id{get; protected set;}
        public Customer Customer{get; protected set;}
        public Address Address{get; set;}
        public int Amount{get; set;}
        public int OrderId{get; set;}
        public Status Status{get; set;}

    }
    



}