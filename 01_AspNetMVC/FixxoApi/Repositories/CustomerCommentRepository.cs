using Api.Models.Entities;
using Api.Repositories.Base;
using FixxoApi.Contexts;

namespace Api.Repositories
{
    public class CustomerCommentRepository : Repository<CustomerCommentEntity, DataContext>
    {
        public CustomerCommentRepository(DataContext context) : base(context)
        {
        }
    }
}
