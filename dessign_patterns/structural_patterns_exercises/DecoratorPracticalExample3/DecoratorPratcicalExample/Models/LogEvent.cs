namespace DecoratorPratcicalExample.Models
{
    using System;
    public class LogEvent : ILogEvent
    {
        public string EventType { get; set; }
        public string PersonName { get; set; }
        public DateTime DateTime { get; set; }
    }
}