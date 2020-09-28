using System.ComponentModel;

namespace Clinic.Contracts.Enums
{
    public enum OrderPaymentStatus
    {
        //Unknown = 0,
        Pending = 1,
        Approved = 2,
        Declined = 3,
        Cancelled = 4,
        Uncollectible = 5
    }


    public enum TicketType
    {
        [Description("A")]
        UpdateSubscriptionEndDate = 1,
        ActivateSubscription = 2,
        UpdateSubscriptionStatus = 3,
        UpdatePaymentTransaction = 4,
        UpdateOrderStatus = 5,
        UpdateProcessingStatus = 6,
        MoveRemoveOrderFromAccount = 7,
        DeactivateLZUserAccount = 8,
        UpdatePrice = 9,
        UpdateCompanyName = 10,
        RemoveDuplicateCompany = 11,
        UpdateTOS = 12,
        UpdateCOD = 13,
        UpdateRadbBlank = 14,
        OrderMissingInSF = 15,
        UpdateEmail = 16,
        UpdateInstallmentBill=17,
        UpdateCreditInfo=18
    }

    public enum UpdateType
    {
        [Description("A")]
        UpdateSubscriptionEndDate = 1,
        ActivateSubscription = 2,
        UpdateSubscriptionStatus = 3,
        UpdatePrice = 4,
    }

    public enum Status
    {
        [Description("API call success")]
        APISuccess = 1,
        [Description("Database success")]
        DataBaseSuccess = 2,
        [Description("API Error")]
        APIError = 3,
        [Description("Database Error")]
        DataBaseError = 4,
    }

    public enum SubscriptionStatus
    {   [Description("Pending")]
        Pending = 1,
        [Description("Active")]
        Active = 2,
        [Description("Active Won't Renew")]
        ActiveWontRenew = 3,
        [Description("Expired")]
        Expired = 4,
        [Description("Cancelled")]
        Cancelled = 5,
        [Description("Not Yet Started")]
        NotYetStarted = 6,
        [Description("Payment Due")]
        PaymentDue = 7,
        [Description("Active COC Eligible")]
        ActiveCOCEligible = 8
    }

    public enum TransactionStatus
    {
        //Unknown = 0,
        Pending = 1,
        Posted = 2,
        Approved = 3,
        Declined = 4,
        Error = 5,
        Chargeback = 6
    }

    public enum CardOperation
    {
        Deactivate=1,
        Removed=2
    }
}
