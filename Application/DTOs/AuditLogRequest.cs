namespace Application.DTOs
{
    public class AuditLogRequest
    {
        public int Id { get; set; }
        public string EntityType { get; set; } = string.Empty;
        public int EntityId { get; set; } // fk
        public string Action { get; set; }
        public string oldVaules { get; set; } = string.Empty;
        public string Newvalue { get; set; } = string.Empty;
        public int ReOrderLevel { get; set; }
        //public DateTime Timestamp { get; set; }
        public int PerformedBy { get; set; } // fk
    }


    public class AuditLogResponse
    {
        public int Id { get; set; }
        public string EntityType { get; set; } = string.Empty;
        public int EntityId { get; set; } // fk
        public string Action { get; set; }
        public string oldVaules { get; set; } = string.Empty;
        public string Newvalue { get; set; } = string.Empty;
        public int ReOrderLevel { get; set; }
        //public DateTime Timestamp { get; set; }
        public int PerformedBy { get; set; } // fk
        public List<AuditLogRequest> Requests { get; set; }=new List<AuditLogRequest>();
    }

}
