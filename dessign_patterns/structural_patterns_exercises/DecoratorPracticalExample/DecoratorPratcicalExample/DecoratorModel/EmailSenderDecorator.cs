namespace DecoratorPratcicalExample.DecoratorModel
{
    using System;
    public class EmailSenderDecorator : IEmailSender
    {
        private ILogger _loggerDecorator;

        public EmailSenderDecorator(ILogger loggerDecorator)
        {
            _loggerDecorator = loggerDecorator;
        }

        public bool SendEmail(string logMessage)
        {
            Console.WriteLine($"\n Sending an email with data: \n {logMessage}");
            return true;
        }

        public bool WriteToDb(string logMessage)
        {
           return SendEmail(logMessage) && _loggerDecorator.WriteToDb(logMessage);
        }

    }
}
