namespace DecoratorPratcicalExample.Models
{
    public interface IMessageEvent: ITodoEvent
    {
        string[] To { get; set; }
    }
}