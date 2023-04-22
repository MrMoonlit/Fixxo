using Api.Models.Entities;
using Api.Repositories.Base;
using FixxoApi.Contexts;

namespace Api.Repositories
{
    public class ShowcaseRepository : Repository<ShowcaseEntity, DataContext>
    {
        public ShowcaseRepository(DataContext context) : base(context)
        {
        }
    }
}
