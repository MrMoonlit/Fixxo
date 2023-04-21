using Api.Models.Entities;
using FixxoApi.Contexts;
using FixxoApi.Migrations;
using Microsoft.EntityFrameworkCore;
using WebApi.Repositories;

namespace Api.Repositories;

public class ProductRepository : Repository<ProductEntity, DataContext>
{
    public ProductRepository(DataContext context) : base(context)
    {
    }

    public DbSet<ProductEntity> Products { get; set; } = null!;

   
}
