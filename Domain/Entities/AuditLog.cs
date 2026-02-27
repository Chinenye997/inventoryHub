namespace Domain.Entities
{
    public class AuditLog : BaseEntity
    {
        public string EntityType { get; set; } = string.Empty; 
        public int EntityId { get; set; } // fk
        public string Action { get; set; } = string.Empty;
        public string? oldVaules { get; set; } //= string.Empty;
        public string? NewValue { get; set; }// = string.Empty;
        public int ReOrderLevel { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        //public int PerformedBy { get; set; } // fk
    }
}
