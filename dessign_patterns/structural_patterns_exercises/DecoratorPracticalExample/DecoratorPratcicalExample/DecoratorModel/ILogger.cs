namespace DecoratorPratcicalExample.DecoratorModel
{
    public interface ILogger : IDbService
    {
        bool LogData(string logMessage);
    }
}
