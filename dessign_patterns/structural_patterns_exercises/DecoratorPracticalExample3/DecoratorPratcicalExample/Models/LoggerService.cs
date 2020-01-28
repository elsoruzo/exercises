namespace DecoratorPratcicalExample.Models
{
    using System;
    public class LoggerService : ILogService
    {
        public bool Log(ILogEvent logEvent)
        {
            Console.WriteLine($"\n Logged data:\n {logEvent.EventType}\n {logEvent.PersonName} \n {logEvent.DateTime}");
            return true;
        }

    }
}
