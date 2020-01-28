namespace DecoratorPratcicalExample.Models
{
    public interface ILogService
    {
        bool Log(ILogEvent logEvent);
    }
}