namespace DecoratorPratcicalExample.Models
{
    public interface ITodoEvent
    {
        string EventType { get; set; }
        string PersonName { get; set; }
    }
}
