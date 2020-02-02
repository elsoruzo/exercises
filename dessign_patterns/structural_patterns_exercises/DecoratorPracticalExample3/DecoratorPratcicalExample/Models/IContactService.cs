namespace DecoratorPratcicalExample.Models
{
    public interface IContactService
    {
        bool IsPersonOnLine(IMessageEvent message);
    }
}