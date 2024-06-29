using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Application.Admin
{
    public static class ConfigurationServices
    {
        public static IServiceCollection RegisterMediatRAdmin(this IServiceCollection services)
        {
            return services;
        }
    }
}
