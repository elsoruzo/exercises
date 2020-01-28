namespace DecoratorPratcicalExample.Models
{
    public interface IMessageEvent: ITodoEvent
    {
        bool IsDone { get; set; }
    }
}