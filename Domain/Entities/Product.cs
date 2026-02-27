namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int initialQuantity { get; set; }
        public int CategoryId { get; set; } //fk
        public Category Category { get; set; } = null!;
        public string CategoryName { get; set; } = string.Empty; //fk
        public string? LowStockThreshold { get; set; }
        public int ReOrederLevel { get; set; }
        public bool IsArchived { get; set; }

        // Navigation property
        public ICollection<StockAdjustment> Adjustments { get; set; } = new List<StockAdjustment>();
        public ICollection<ItemIssuance> Issuance { get; set; } = new List<ItemIssuance>();
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
    }
}
