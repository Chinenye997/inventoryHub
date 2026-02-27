namespace Application.DTOs
{
    public class StockAdjustmentResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string QuantityChange { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        //public DateTime Timestamp { get; set; }
        public int PerformedBy { get; set; }//fk
    }
}
