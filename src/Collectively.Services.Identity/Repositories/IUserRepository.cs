using System.Threading.Tasks;
using Collectively.Common.Types;
using Collectively.Services.Identity.Domain;

namespace Collectively.Services.Identity.Repositories
{
    public interface IUserRepository
    {
        Task<Maybe<User>> GetByUserIdAsync(string userId);
        Task<Maybe<User>> GetByExternalUserIdAsync(string externalUserId);
        Task<Maybe<User>> GetByEmailAsync(string email, string provider);
        Task<Maybe<User>> GetByNameAsync(string name);
        Task AddAsync(User user);
        Task UpdateAsync(User user);         
    }
}