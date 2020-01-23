namespace DecoratorPratcicalExample.Model
{
    public interface ITodoEvent
    {
        string EventType { get; set; }
        string PersonName { get; set; }
    }
}
