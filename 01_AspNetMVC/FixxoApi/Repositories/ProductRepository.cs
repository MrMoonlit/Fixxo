using Api.Models.DTOs;
using Api.Models.Entities;
using Api.Repositories.Base;
using FixxoApi.Contexts;
using FixxoApi.Migrations;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories;

public class ProductRepository : Repository<ProductEntity, DataContext>
{
    public ProductRepository(DataContext context) : base(context)
    {
    }

    public override async Task<IEnumerable<ProductEntity>> GetAllAsync()
    {
        return await _context.Products.Include("Category").Include("Tag").ToListAsync();
    }
    
}
