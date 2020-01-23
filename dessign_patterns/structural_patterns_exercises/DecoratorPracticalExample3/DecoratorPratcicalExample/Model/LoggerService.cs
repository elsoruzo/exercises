namespace DecoratorPratcicalExample.Model
{
    using System;
    public class LoggerService : ILogger
    {
        public bool Log(ILogEvent logEvent)
        {
            Console.WriteLine($"\n Writting to LOGs data:\n {logEvent.EventType}\n {logEvent.PersonName} \n {logEvent.DateTime}");
            return true;
        }

    }
}
