namespace Domain.Entities
{
    public class ItemIssuance : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }
        public string Recipient { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public DateTime IssuedAt { get; set; } = DateTime.UtcNow;
        //public int IssuedBy { get; set; }//fk
    }
}
