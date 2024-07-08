using Serilog;

public class LoggerService : ILoggerService
{
    private readonly ILogger _logger;

    public LoggerService()
    {
        _logger = Log.ForContext<LoggerService>();
    }

    public void LogDebug(string message)
    {
        _logger.Debug(message);
    }

    public void LogInformation(string message)
    {
        _logger.Information(message);
    }

    public void LogWarning(string message)
    {
        _logger.Warning(message);
    }

    public void LogError(string message, Exception ex)
    {
        _logger.Error(ex, message);
    }

    public void LogCritical(string message, Exception ex)
    {
        _logger.Fatal(ex, message);
    }
}