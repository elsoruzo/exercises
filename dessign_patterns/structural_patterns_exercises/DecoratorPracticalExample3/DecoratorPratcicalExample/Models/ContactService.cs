namespace DecoratorPratcicalExample.Models
{
    public class ContactService : IContactService
    {
        public bool IsPersonOnLine(IMessageEvent message)
        {
            return message.PersonName == "YAKOV";
        }

    }
}
