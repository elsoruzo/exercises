namespace DecoratorPratcicalExample.Models
{
    public class DbServiceMessageDecorator : IDbService
    {
        private readonly IDbService _dbService;
        private readonly IMessageService _messageService;

        public DbServiceMessageDecorator(IDbService dbService, IMessageService messageService)
        {
            _dbService = dbService;
            _messageService = messageService;
        }
        
        /// <summary>
        /// Mapping
        /// </summary>
        /// <param name="todoEvent"></param>
        /// <returns></returns>
        private MessageEvent MapMessageEvent(ITodoEvent todoEvent)
        {
            return new MessageEvent()
            {
                EventType = todoEvent.EventType,
                PersonName = todoEvent.PersonName,
                IsDone = true
            };
        }
        private bool IsSendMessageRule(ITodoEvent todoEvent)
        {
            return todoEvent.EventType == "FEED THE CAT" && todoEvent.PersonName == "YAKOV";
        }
        public bool Save(ITodoEvent todoEvent)
        {
            if(IsSendMessageRule(todoEvent))
            {
                _messageService.SendMessage(MapMessageEvent(todoEvent));
            }
            return _dbService.Save(todoEvent);
        }
    }
}
