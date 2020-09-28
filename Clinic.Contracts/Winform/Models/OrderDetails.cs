using System;

namespace Clinic.Contracts.Winform.Models
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public int UserOrder { get; set; }
        public string ProductName { get; set; }
        public string SubscriptionStatus { get; set; }
        public int OrderItem { get; set; }
        public int ParentOrderItem { get; set; }
        public int OrderItemSubscription { get; set; }
        public DateTime SubscriptionEnd { get; set; }
        public bool Active { get; set; }
        public string FreeShippingStart { get; set; }
        public DateTime FreeShippingEnd { get; set; }
        public int RenewalPrice { get; set; }
    }
}
