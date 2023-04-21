using Api.Models.DTOs;
using Api.Repositories;

namespace Api.Services;

public class ProductService
{
    private readonly ProductRepository _productRepo;

    public ProductService(ProductRepository productRepo)
    {
        _productRepo = productRepo;
    }

    public async Task<IEnumerable<ProductDTO>> GetAllAsync()
    {
        var productList = await _productRepo.GetAllAsync();

        var dtoList = new List<ProductDTO>();
        foreach (var product in productList) 
        {
            ProductDTO item = product;
            if (item != null)
                dtoList.Add(item);
        }
        return dtoList;
    }
}
