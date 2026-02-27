namespace Domain.Entities
{
    public class StockAdjustment : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public string QuantityChange { get; set; } = string.Empty; // +ve = add, -ve = subtract
        public string Reason { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public int PerformedBy { get; set; }//fk
    }
}
