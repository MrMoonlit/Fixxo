using Api.Models.DTOs;
using Api.Models.Entities;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Api.Services;

public class ProductService
{
    private readonly ProductRepository _productRepo;
    private readonly CategoryRepository _categoryRepo;
    private readonly TagRepository _tagRepo;


    public ProductService(ProductRepository productRepo, CategoryRepository categoryRepo, TagRepository tagRepo)
    {
        _productRepo = productRepo;
        _categoryRepo = categoryRepo;
        _tagRepo = tagRepo;
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

    public async Task<bool> AddAsync(NewProductDTO model)
    {
        ProductEntity product = model;
        product.Category = await _categoryRepo.GetAsync(x => x.Name == model.Category);
        product.Tag = await _tagRepo.GetAsync(x => x.Name == model.Tag);
        product.TimeCreated = DateTime.Now;

        try
        {
            await _productRepo.AddAsync(product);
            return true;
        }
        catch { return false; }
    }


}
