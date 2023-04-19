using FixxoApi.Contexts;
using FixxoApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using WebApi.Repositories;

namespace FixxoApi.Repositories
{
    public class UserProfileRepository : Repository<UserProfileEntity>
    {
        private readonly IdentityContext _identityContext;

        public UserProfileRepository(IdentityContext identity) : base (identity)
        {
            _identityContext = identity;
        }

        public override async Task<IEnumerable<UserProfileEntity>> GetAllAsync()
        {
            return await _identityContext.UserProfiles
                .Include(x => x.User)
                .ToListAsync();
        }
    }
}
