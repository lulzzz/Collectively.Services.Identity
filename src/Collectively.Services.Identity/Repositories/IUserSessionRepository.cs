using System;
using System.Threading.Tasks;
using Collectively.Common.Types;
using Collectively.Services.Identity.Domain;

namespace Collectively.Services.Identity.Repositories
{
    public interface IUserSessionRepository
    {
        Task<Maybe<UserSession>> GetByIdAsync(Guid id);
        Task AddAsync(UserSession session);
        Task UpdateAsync(UserSession session);
    }
}