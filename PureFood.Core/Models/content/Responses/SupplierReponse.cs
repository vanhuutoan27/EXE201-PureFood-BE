namespace PureFood.Core.Models.content.Responses
{
    public class SupplierReponse
    {
        public Guid SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt
        { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
