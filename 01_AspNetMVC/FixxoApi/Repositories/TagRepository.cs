using Api.Models.Entities;
using Api.Repositories.Base;
using FixxoApi.Contexts;

namespace Api.Repositories
{
    public class TagRepository : Repository<TagEntity, DataContext>
    {
        public TagRepository(DataContext context) : base(context)
        {
        }
    }
}
