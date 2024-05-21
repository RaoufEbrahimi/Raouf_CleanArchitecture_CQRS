using CMS.Core.Domain.Repositories;
using CMS.Infrastructure.Data.Context;
using CMS.Infrastructure.Data.Repositories;
using CMS.Infrastructure.Data.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CMS.Infrastructure.Data;

public static class ConfigurationServices
{
    public static IServiceCollection RegisterInfrastructureDataServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CMSDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));


        services.AddScoped<IUnitOfWork, AppUnitOfWork>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IBlogRepository, BlogRepository>();

        return services;
    }
}
