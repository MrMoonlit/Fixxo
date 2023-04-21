using Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FixxoApi.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<CustomerCommentEntity> Comments { get; set; } 
    }
}
