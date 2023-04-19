using Api.Models.Entities;

namespace Api.Models.DTOs;

public class ProductDTO
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public int StarRating { get; set; }
    public string Category { get; set; } = null!;
    public string Tag { get; set; } = null!;


    public static implicit operator ProductDTO()
}
