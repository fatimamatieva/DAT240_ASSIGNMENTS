using System;
using System.Collections;
using System.Collections.Generic;
using UiS.Dat240.Lab3.SharedKernel;

namespace UiS.Dat240.Lab3.Core.Domain.Fulfillment{
    public class Offer : BaseEntity{
        public Offer(Reimbursement reim, int orderid){
                Reimbursement = reim;
                OrderId = orderid;
        }
        public Offer(){}
        public int Id{get; protected set;}
        public int OrderId{get; set;}
        public Shipper Shipper{get; set;}
        public Reimbursement Reimbursement{get; set;}
    }
}