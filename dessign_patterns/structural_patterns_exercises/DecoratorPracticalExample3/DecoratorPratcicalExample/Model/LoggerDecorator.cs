namespace DecoratorPratcicalExample.Model
{
    using System;
    using System.Collections.Generic;

    public class LoggerDecorator : IDbService, ILogger
    {
        private IDbService _dbService;
        private ILogger _loggerService;

        public LoggerDecorator(IDbService dbService, ILogger loggerService)
        {
            _dbService = dbService as IDbService;
            _loggerService = loggerService as ILogger;
        }
        
        private bool IsLogNeeded(ITodoEvent todoEvent)
        {
            return todoEvent.EventType == "FEED THE CAT" && todoEvent.PersonName == "YAKOV";
        }
        public bool Log(ITodoEvent todoEvent)
        {
            LogEvent logEvent = new LogEvent()
            {
                EventType = todoEvent.EventType,
                PersonName = todoEvent.PersonName,
                DateTime = DateTime.Now
            };
            return Log(logEvent);
        }

        public bool Save(ITodoEvent todoEvent)
        {
            IsLogNeeded(todoEvent);
            return IsLogNeeded(todoEvent) ? Log(todoEvent) & _dbService.Save(todoEvent): _dbService.Save(todoEvent);
        }

        public bool Log(ILogEvent logEvent)
        {
            return _loggerService.Log(logEvent);
        }

        internal bool Save(IEnumerable<TodoEvent> todoEventList)
        {
            bool operationWentOk = false;

            foreach (var todoEvent in todoEventList)
            {
                operationWentOk = Save(todoEvent);
            }

            return operationWentOk;
        }
    }
}
