namespace DecoratorPratcicalExample.DecoratorModel
{
    using System;
    public class AuthorizationService
    {
        private IDbService _dbService;
        private ILogger _loggerDecorator;
        private IEmailSender _emailSenderDecorator;
        private ISmsSender _smsSenderDecorator;
        public AuthorizationService(string logMessage, IDbService dbService)
        {
            _dbService = dbService as IDbService;
            if (WriteToDb(logMessage))
                Console.WriteLine("WriteToDb Worked");
            else
                Console.WriteLine("WriteToDb Didnt Work");
        }
        public AuthorizationService(string logMessage, ILogger loggerDecorator)
        {
            _loggerDecorator = loggerDecorator as ILogger;
            if(WriteToDbAndLog(logMessage))
            Console.WriteLine("Logger Decorator Worked");
            else
            Console.WriteLine("Logger Decorator Didnt Work");
        }

        public AuthorizationService(string logMessage, IEmailSender emailSenderDecorator)
        {
            _emailSenderDecorator = emailSenderDecorator as IEmailSender;
            if (WriteToDbAndLogAndSendEmail(logMessage))
                Console.WriteLine("EmailSender Decorator Worked");
            else
                Console.WriteLine("EmailSender Decorator Didnt Work");
        }

        public AuthorizationService(string logMessage, ISmsSender smsSenderDecorator)
        {
            _smsSenderDecorator = smsSenderDecorator as ISmsSender;
            if (WriteToDbAndLogAndSendEmailAndSms(logMessage))
                Console.WriteLine("SmsSender Decorator Worked");
            else
                Console.WriteLine("SmsSender Decorator Didnt Work");
        }

        private bool WriteToDb(string logMessage)
        {
            return _dbService.WriteToDb(logMessage);
        }

        private bool WriteToDbAndLog(string logMessage)
        {
            return _loggerDecorator.WriteToDb(logMessage);
        }

        private bool WriteToDbAndLogAndSendEmail(string logMessage)
        {
            return _emailSenderDecorator.WriteToDb(logMessage);
        }

        private bool WriteToDbAndLogAndSendEmailAndSms(string logMessage)
        {
            return _smsSenderDecorator.WriteToDb(logMessage);
        }
    }
}
