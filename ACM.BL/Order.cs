using ACME.Common;
using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order:EntityBase, ILoggable
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }

        public List<OrderItem> orderItems { get; set; }
        
        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges && order.IsValid)
            {
                if (order.IsNew)
                {

                }
                else
                {

                }
            }

            return success;
        }
          

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null)
                isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return $"{OrderDate.Value.Date} ({OrderId})";
        }

        public string Log()
        {
            return $"{this.OrderId}: Date: {this.OrderDate.Value.Date.ToShortDateString()} Status: {this.EntityState.ToString()}";
        }
    }
}
