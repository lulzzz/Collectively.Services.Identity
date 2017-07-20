namespace Collectively.Services.Identity.Modules
{
    public class HomeModule : ModuleBase
    {
        public HomeModule() : base(requireAuthentication: false)
        {
            Get("", args => "Welcome to the Collectively.Services.Identity API!");
        }
    }
}