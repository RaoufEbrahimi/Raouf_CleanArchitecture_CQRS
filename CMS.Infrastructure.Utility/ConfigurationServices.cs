using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using Serilog;
using System.Collections.ObjectModel;
using System.Data;

namespace CMS.Infrastructure.Utility;

public static class ConfigurationServices
{
    public static IServiceCollection AddInfrastructureUtilityServices(this IServiceCollection services,  IConfiguration configuration)
    {
        services.AddSingleton<ILoggerService, LoggerService>();
        return services;
    }
    public static IHostBuilder AddLoggingConfig(this IHostBuilder host, IConfiguration configuration)
    {
        var columnOptions = new ColumnOptions
        {
            AdditionalColumns = new Collection<SqlColumn>
            {
                new SqlColumn { ColumnName = "EventId", DataType = SqlDbType.Int },
                new SqlColumn { ColumnName = "Message", DataType = SqlDbType.NVarChar, DataLength = 4000 },
                new SqlColumn { ColumnName = "Level", DataType = SqlDbType.NVarChar, DataLength = 128 },
                new SqlColumn { ColumnName = "TimeStamp", DataType = SqlDbType.DateTimeOffset },
                new SqlColumn { ColumnName = "Exception", DataType = SqlDbType.NVarChar, DataLength = 2000 },
                new SqlColumn { ColumnName = "Properties", DataType = SqlDbType.Xml },
            }
        };

        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()          
            .WriteTo.MSSqlServer(
                connectionString: configuration.GetConnectionString("ConnectionString"),
                sinkOptions: new MSSqlServerSinkOptions
                {
                    TableName = "Logs",
                    AutoCreateSqlTable = true
                },
                columnOptions: columnOptions)
            .CreateLogger();
    
        host.UseSerilog(Log.Logger);
        return host;
    }
}
