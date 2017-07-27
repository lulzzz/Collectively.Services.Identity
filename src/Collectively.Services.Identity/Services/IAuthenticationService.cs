using System;
using System.Threading.Tasks;

namespace Collectively.Services.Identity.Services
{
    public interface IAuthenticationService
    {
        Task SignInAsync(Guid sessionId, string email, string password,
            string ipAddress = null, string userAgent = null);

        Task SignInViaFacebookAsync(Guid sessionId, string accessToken,
            string ipAddress = null, string userAgent = null);
    }
}