using Api.Models.DTOs;
using Api.Models.Entities;
using Api.Repositories.Base;
using FixxoApi.Contexts;
using FixxoApi.Migrations;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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
    public override async Task<ProductEntity> GetAsync(Expression<Func<ProductEntity, bool>> predicate)
    {
        var entity = await _context.Set<ProductEntity>().Include("Category").Include("Tag").FirstOrDefaultAsync(predicate);
        if (entity != null)
            return entity;

        return null!;
    }

    public override async Task<IEnumerable<ProductEntity>> GetListAsync(Expression<Func<ProductEntity, bool>> predicate)
    {
        var entities = await _context.Set<ProductEntity>().Include("Category").Include("Tag").Where(predicate).ToListAsync();
        if (entities != null)
            return entities;

        return null!;
    }

}
