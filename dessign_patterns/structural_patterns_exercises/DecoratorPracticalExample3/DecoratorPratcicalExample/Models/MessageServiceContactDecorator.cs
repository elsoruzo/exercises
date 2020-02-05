namespace DecoratorPratcicalExample.Models
{
    public class MessageServiceContactDecorator : IMessageService
    {
        private readonly IMessageService _messageService;
        private readonly IContactService _contactService;

        public MessageServiceContactDecorator( IMessageService messageService, IContactService contactService)
        {
            _messageService = messageService;
            _contactService = contactService;
        }


        public bool Send(IMessageEvent message)
        {
            return _contactService.IsPersonOnLine(message) ? _messageService.Send(message) : false;
        }

    }
}
