namespace DecoratorPratcicalExample.Models
{
    public class LogServiceMessageDecorator : ILogService
    {
        private readonly ILogService _logService;
        private readonly IContactService _contactService;

        public LogServiceMessageDecorator(ILogService logService, IContactService contactService)
        {
            _logService = logService;
            _contactService = contactService;
        }

        private MessageEvent MapToMessageEvent(ILogEvent logEvent)
        {
            return new MessageEvent()
            {
                EventType = logEvent.EventType,
                PersonName = logEvent.PersonName,
                DateTime = logEvent.DateTime,
                To = new string[] { "Husband", "Wife", "Child" }
            };
        }
        private bool IsSendMessageRule(ILogEvent logEvent)
        {
            return logEvent.EventType == "FEED THE CAT" && logEvent.PersonName == "YAKOV";
        }

        public bool Log(ILogEvent logEvent)
        {
            if (IsSendMessageRule(logEvent))
            {
                _contactService.IsPersonOnLine(MapToMessageEvent(logEvent));
            }
            return _logService.Log(logEvent);
        }
    }
}
