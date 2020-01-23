namespace DecoratorPratcicalExample.Model
{
    class TodoEvent : ITodoEvent
    {
        public string EventType { get; set; }
        public string PersonName { get; set; }
    }
}
