using System;
using UiS.Dat240.Lab3.SharedKernel;

namespace UiS.Dat240.Lab3.Core.Domain.Invoicing{
    public class Customer : BaseEntity{
        public Guid Id{get; set;}
        public string Name{get; set;}
        
    } 
}