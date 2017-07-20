namespace Collectively.Services.Identity.Modules
{
    public class AccountModule : ModuleBase
    {
        public AccountModule() : base("account", requireAuthentication: true)
        {
            Get("", args => 
            {
                return $"Hello: " + this.Context.CurrentUser.Identity.Name;
            });
        }
    }
}