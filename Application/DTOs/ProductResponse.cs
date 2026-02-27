using System.ComponentModel.DataAnnotations;

namespace Application.DTOs
{

    public class ProductRequest
    {
        public string Id { get; set; } = string.Empty;

        [Required(ErrorMessage = "Product name is required.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "initialQuantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "initialQuantity must be at least 1.")]
        public int initialQuantity { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string CategoryId { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int ReOrederLevel { get; set; }

        // public List<IFormFile> ProductPhotos { get; set; } = new List<IFormFile>();
        public List<string> PhotoUrls { get; set; } = new();
        public List<CategoryResponse> Categories { get; set; } = new List<CategoryResponse>();

    }


    public class ProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int initialQuantity { get; set; }
        public int CategoryId { get; set; } //fk
        public string CategoryName { get; set; } = string.Empty; //fk
        public string? LowStockThreshold { get; set; }
        public int ReOrederLevel { get; set; }
        public bool IsArchived { get; set; }
        public List<string> PhotoUrls { get; set; } = new List<string>();

    }
}
