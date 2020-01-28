namespace DecoratorPratcicalExample.Models
{
    public interface IMessageService
    {
         bool SendMessage(IMessageEvent message);
    }
}