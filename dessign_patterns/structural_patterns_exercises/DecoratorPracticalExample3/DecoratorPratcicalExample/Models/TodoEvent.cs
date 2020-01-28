namespace DecoratorPratcicalExample.Models
{
    class TodoEvent : ITodoEvent
    {
        public string EventType { get; set; }
        public string PersonName { get; set; }
    }
}
