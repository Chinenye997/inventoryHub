using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Category : BaseEntity
{
    [StringLength(20, ErrorMessage = "Category name cannot exceed 20 characters")]
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }


    // Add navigation property for products
    public List<Product> Products { get; set; } = new List<Product>(); // Allows multiple products
    //public ICollection<ProductEntity>Products { get; set; } = new List<ProductEntity>();
}
