using HelloWorld.Service.Models;

namespace HelloWorld.Service
{
    public static class ServiceConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDateTime, SystemDateTime>();
        }
    }
}
