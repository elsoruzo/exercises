namespace ConsoleImplementationOfDecorator
{
    using System;
    using DecoratorPratcicalExample.DecoratorModel;
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("To exit press E or Press any key to START decorating");
            char command = Console.ReadKey().KeyChar;

            Console.WriteLine("START RUNNING DECORATOR.");

            Console.WriteLine("Enter the Message you want to performe manipulation on");
            string message = Console.ReadLine();
            Console.WriteLine($"The Message you entered was: {message}");
            while (command != 'E')
            {
                Console.WriteLine("To write to db press 1");
                Console.WriteLine("To write to db and to logs press 2");
                Console.WriteLine("To write to db, to logs and send an email press 3");
                Console.WriteLine("To write to db, to logs, send an email and an SMS notification press 4");
                Console.WriteLine("To exit press E");
                command = Console.ReadKey().KeyChar;

                switch (command)
                {
                    case '1':
                        Console.WriteLine("\n App: writing to db.");
                        var dbservice = new DbService();
                        new AuthorizationService(message, new DbService());
                        break;
                    case '2':
                        Console.WriteLine("\n App: writing to db and to logs.");
                        var dbserviceForLogger = new DbService();
                        var loggerDecorator = new LoggerDecorator(dbserviceForLogger);
                        new AuthorizationService(message, loggerDecorator);
                        break;
                    case '3':
                        Console.WriteLine("\n App: writing to db, to logs and sending an email.");
                        var dbserviceForLoggerAndEmail = new DbService();
                        var loggerDecoratorForEmail = new LoggerDecorator(dbserviceForLoggerAndEmail);
                        var emailSenderDecorator = new EmailSenderDecorator(loggerDecoratorForEmail);
                        new AuthorizationService(message, emailSenderDecorator);

                        break;
                    case '4':
                        Console.WriteLine("\n App: writing to db, to logs, sending an email and an sms.");
                        var dbserviceForLoggerAndEmailAndSms = new DbService();
                        var loggerDecoratorForEmailAndSms = new LoggerDecorator(dbserviceForLoggerAndEmailAndSms);
                        var emailSenderDecoratorEmailAndSms = new EmailSenderDecorator(loggerDecoratorForEmailAndSms);
                        var smsSenderDecoratorEmailAndSms = new SmsSenderDecorator(emailSenderDecoratorEmailAndSms);
                        new AuthorizationService(message, smsSenderDecoratorEmailAndSms);
                        break;

                    default:
                        Console.WriteLine("\n Something went wrong. Please try again.");
                        break;
                }
            }
            Console.WriteLine("\n App: Aply client code for the Decorated component.");
            Console.WriteLine("END RUNNING ADAPTER.");
            Console.ReadKey();

        }
    }
}













