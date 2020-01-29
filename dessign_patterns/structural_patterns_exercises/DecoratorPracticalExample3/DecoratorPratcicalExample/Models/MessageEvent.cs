namespace DecoratorPratcicalExample.Models
{
    using System;
    public class MessageEvent : IMessageEvent
    {
        public string EventType { get; set; }
        public string PersonName { get; set; }
        public DateTime DateTime { get; set; }
        public string[] To { get; set; }
    }
}