using BLL.Repository;
using SRV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class AddRegister
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddScoped<UserService, UserService>();
            services.AddScoped<SuggestService, SuggestService>();
        }


        public static void AddReporsitory(this IServiceCollection services)
        {
            services.AddScoped<UserReporsitory, UserReporsitory>();
            services.AddScoped<SuggestReporsitory, SuggestReporsitory>();
        }
    }
}
