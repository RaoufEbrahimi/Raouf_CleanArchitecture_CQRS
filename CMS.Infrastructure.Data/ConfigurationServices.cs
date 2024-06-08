using CMS.Core.Domain.Repositories;
using CMS.Core.Domain.Repositories.Commands;
using CMS.Core.Domain.Repositories.Queries;
using CMS.Infrastructure.Data.Repositories;
using CMS.Infrastructure.Data.Repositories.Commands;
using CMS.Infrastructure.Data.UnitOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CMS.Infrastructure.Data;

public static class ConfigurationServices
{
    public static IServiceCollection RegisterInfrastructureDataServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CMSDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));


        services.AddScoped<IUnitOfWork, AppUnitOfWork>();
        //user
        services.AddScoped<IUserCommandRepository, UserCommandRepository>();
        services.AddScoped<IUserQueryRepository, UserQueryRepository>();
        //blog
        services.AddScoped<IBlogCommandRepository, BlogCommandRepository>();
        services.AddScoped<IBlogQueryRepository, BlogQueryRepository>();

        return services;
    }
}
