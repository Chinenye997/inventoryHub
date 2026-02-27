namespace Application.DTOs
{
    public class ItemIssuanceRequest
    {
        public int Id { get; set; }
        public int ProductId { get; set; } //fk
        public int Quantity { get; set; }
        public string Recipient { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public DateTime IssuedAt { get; set; }
        public int IssuedBy { get; set; }//fk
    }

    public class ItemIssuanceResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Recipient { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public DateTime IssuedAt { get; set; }
        public int IssuedBy { get; set; }//fk
        public List<ItemIssuanceRequest> Items { get; set; } = new List<ItemIssuanceRequest>();
    }
}
