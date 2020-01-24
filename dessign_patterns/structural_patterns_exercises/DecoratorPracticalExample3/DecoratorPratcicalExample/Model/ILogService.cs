namespace DecoratorPratcicalExample.Model
{
    public interface ILogService
    {
        bool Log(ILogEvent logEvent);
    }
}