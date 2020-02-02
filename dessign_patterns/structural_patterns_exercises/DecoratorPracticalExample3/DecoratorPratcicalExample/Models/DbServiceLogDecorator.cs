namespace DecoratorPratcicalExample.Models
{
    using System;

    public class DbServiceLogDecorator : IDbService
    {
        private readonly IDbService _dbService;
        private readonly ILogService _logService;

        public DbServiceLogDecorator(IDbService dbService, ILogService loggerService)
        {
            _dbService = dbService;
            _logService = loggerService;
        }

          private LogEvent MapToLogEvent(ITodoEvent todoEvent)
        {
            return new LogEvent()
            {
                EventType = todoEvent.EventType,
                PersonName = todoEvent.PersonName,
                DateTime = DateTime.Now
            };
        }

        public bool Save(ITodoEvent todoEvent)
        {
            _logService.Log(MapToLogEvent(todoEvent));
            return _dbService.Save(todoEvent);
        }
    }
}
