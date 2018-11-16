using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem:EntityBase
    {
         
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuanity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public  bool Save(OrderItem orderItem)
        {
            var success = true;

            if (orderItem.HasChanges && orderItem.IsValid)
            {
                if (orderItem.IsNew)
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

            if (OrderQuanity <= 0 || ProductId <= 0 || PurchasePrice == null)
                isValid = false;


            return isValid;
        }
    }
}
