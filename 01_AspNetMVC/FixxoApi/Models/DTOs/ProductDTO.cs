using Api.Models.Entities;

namespace Api.Models.DTOs;

public class ProductDTO
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Price { get; set; }
    public int StarRating { get; set; }
    public string Category { get; set; } = null!;
    public string Tag { get; set; } = null!;


    public static implicit operator ProductDTO(ProductEntity model)
    {
        return new ProductDTO
        {
            Id = model.Id,
            Title = model.Title,
            Description = model.Description,
            Price = model.Price,
            StarRating = model.StarRating,
            Category = model.Category.Name, 
            Tag = model.Tag
        };
    }
}
