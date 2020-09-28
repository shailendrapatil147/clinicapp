namespace Clinic.Contracts.ServiceModels
{
    public class UpdateOrderPaymentRequest
    {
        public int OrderId { get; set;}
        public string PaymentStatus { get; set;}
        public string UpdatedBy { get; set; }
    }
}