namespace DecoratorPratcicalExample.DecoratorModel
{
    using System;
    public class SmsSenderDecorator : ISmsSender
    {
        private IEmailSender _emailSenderDecorator;

        public SmsSenderDecorator(IEmailSender emailSenderDecorator)
        {
            _emailSenderDecorator = emailSenderDecorator;
        }

        public bool SendSms(string logMessage)
        {
            Console.WriteLine($"\n Sending SMS with data: \n {logMessage}");
            return true;
        }

        public bool WriteToDb(string logMessage)
        {
           return SendSms(logMessage) && _emailSenderDecorator.WriteToDb(logMessage);
        }

    }
}
