namespace DecoratorPratcicalExample.Models
{
    public interface IMessageService
    {
         bool Send(IMessageEvent message);
    }
}