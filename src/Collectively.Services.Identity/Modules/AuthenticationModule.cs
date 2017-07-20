using System.Threading.Tasks;
using Collectively.Common.Security;
using Collectively.Messages.Commands.Users;

namespace Collectively.Services.Identity.Modules
{
    public class AuthenticationModule : ModuleBase
    {
        public AuthenticationModule(IJwtTokenHandler jwtTokenHandler) 
            : base("auth", requireAuthentication: false)
        {
            Post("", async args => 
            {
                var request = this.BindRequest<SignIn>();
                var token = jwtTokenHandler.Create("user1", "admin");
                await Task.CompletedTask;

                return new 
                {
                    token = token.Value.Token,
                    expires = token.Value.Expires
                };
            });
        }
    }
}