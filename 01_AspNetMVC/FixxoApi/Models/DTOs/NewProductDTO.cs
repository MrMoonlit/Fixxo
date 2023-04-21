using Api.Models.Entities;

namespace Api.Models.DTOs;

public class NewProductDTO
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Price { get; set; }
    public int StarRating { get; set; }
    public string Category { get; set; } = null!;
    public string Tag { get; set; } = null!;

    public static implicit operator ProductEntity(NewProductDTO model)
    {
        return new ProductEntity
        {
            Title = model.Title,
            Description = model.Description,
            Price = model.Price,
            StarRating = model.StarRating,
        };
    }
}
