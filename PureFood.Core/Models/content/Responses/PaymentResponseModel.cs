namespace PureFood.Core.Models.content.Responses
{
    public class PaymentResponseModel
    {
        public bool Success { get; set; }
        public decimal AmountOfRental { get; set; }

        // public string RentalId {  get; set; }   
        public string PaymentMethod { get; set; }
        public string OrderDescription { get; set; }
        public string OrderId { get; set; }
        public string PaymentId { get; set; }
        public string TransactionId { get; set; }
        public string Token { get; set; }
        public string VnPayResponseCode { get; set; }
        public int AccountId { get; set; }
    }
}
