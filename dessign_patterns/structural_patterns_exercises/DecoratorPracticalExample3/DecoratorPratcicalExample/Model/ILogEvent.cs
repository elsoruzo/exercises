namespace DecoratorPratcicalExample.Model
{
    public interface ILogEvent 
    {
        string EventType { get; set; }
        string PersonName { get; set; }
        System.DateTime DateTime { get; set; }
    }
}
