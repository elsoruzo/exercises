namespace DecoratorPratcicalExample.Model
{
    public interface ILogger
    {
        bool Log(ILogEvent logEvent);
    }
}