using System.Data;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string RoleId { get; set; } = string.Empty;
        public Role Role { get; set; } = null!;

        public DateTime? ApprovedAt { get; set; }
        public string? ApprovedBy { get; set; }
        public User? Approver { get; set; }

        // Navigation: Users this user approved
        public ICollection<User> ApprovedUsers { get; set; } = new List<User>();

        // Actions performed
        public ICollection<Product> CreatedProducts { get; set; } = new List<Product>();
        public ICollection<StockAdjustment> StockAdjustments { get; set; } = new List<StockAdjustment>();
        public ICollection<ItemIssuance> ItemIssuances { get; set; } = new List<ItemIssuance>();
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();

    }
}
