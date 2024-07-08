using CMS.Core.Domain.Interfaces.Repositories;
using CMS.Core.Domain.Interfaces.Repositories.Commands;
using CMS.Core.Domain.Interfaces.Repositories.Queries;
using CMS.Infrastructure.Data.Repositories;
using CMS.Infrastructure.Data.Repositories.Commands;
using CMS.Infrastructure.Data.UnitOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CMS.Infrastructure.Data;

public static class ConfigurationServices
{
    public static IServiceCollection AddInfrastructureDataServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CMSDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("MyDbContext")));


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
