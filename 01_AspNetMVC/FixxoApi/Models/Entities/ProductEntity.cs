using System.ComponentModel.DataAnnotations;

namespace Api.Models.Entities;

public class ProductEntity
{
    [Key]
    public int Id { get; set; }

    [MaxLength(100)]
    public string Title { get; set; } = null!;

    [MaxLength(400)]
    public string Description { get; set; } = null!;

    [Range(0, double.MaxValue)]
    [DataType(DataType.Currency)]
    public double Price { get; set; }

    [Range(1, 5)]
    public int StarRating { get; set; }
    public string Tag { get; set; } = null!;

    public int CategoryId { get; set;}
    public CategoryEntity Category { get; set; } = null!;
}
