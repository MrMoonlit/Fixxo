using Api.Models.Entities;
using Api.Repositories.Base;
using FixxoApi.Contexts;

namespace Api.Repositories
{
    public class CategoryRepository : Repository<CategoryEntity, DataContext>
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }
    }
}
