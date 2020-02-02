namespace DecoratorPratcicalExample.Models
{
    public class MessageServiceContactDecorator : IContactService
    {
        private readonly IContactService _contactService;
        private readonly IMessageService _messageService;

        public MessageServiceContactDecorator(IContactService contactService, IMessageService messageService)
        {
            _contactService = contactService;
            _messageService = messageService;
        }


        public bool Send(IMessageEvent message)
        {
            return _messageService.Send(message);
        }

        public bool IsPersonOnLine(IMessageEvent message)
        {
            return _contactService.IsPersonOnLine(message) ? Send(message) : false;
        }

    }
}
