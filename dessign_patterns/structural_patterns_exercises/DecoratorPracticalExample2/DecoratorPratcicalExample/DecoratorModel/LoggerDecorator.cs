namespace DecoratorPratcicalExample.DecoratorModel
{
    using System;
    public class LoggerDecorator : ILogger
    {
        private DbService _dbService;

        public LoggerDecorator(DbService dbService)
        {
            _dbService = dbService;
        }
        public bool LogData(string logMessage)
        {
            Console.WriteLine($"\n Writting to LOGs data: \n {logMessage}");
            return true;
        }

        public bool WriteToDb(string logMessage)
        {
           return LogData(logMessage) && _dbService.WriteToDb(logMessage);
        }

    }
}
