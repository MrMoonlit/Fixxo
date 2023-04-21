using Api.Repositories.Base;
using FixxoApi.Contexts;
using FixxoApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FixxoApi.Repositories
{
    public class UserProfileRepository : Repository<UserProfileEntity, IdentityContext>
    {

        public UserProfileRepository(IdentityContext identity) : base (identity)
        {
        }

        public override async Task<IEnumerable<UserProfileEntity>> GetAllAsync()
        {
            return await _context.UserProfiles
                .Include(x => x.User)
                .ToListAsync();
        }
    }
}
