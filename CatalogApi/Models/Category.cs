using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogApi.Models;

[Table("Categories")]
public class Category
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string? Name { get; set; }

    [Required]
    [StringLength(500)]
    public string? ImageUrl { get; set; }

    public ICollection<Product>? Products { get; set; }

    public Category()
    {
        Products = new Collection<Product>();
    }
}
