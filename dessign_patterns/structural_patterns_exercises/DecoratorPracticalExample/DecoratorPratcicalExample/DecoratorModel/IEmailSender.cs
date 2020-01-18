namespace DecoratorPratcicalExample.DecoratorModel
{
    public interface IEmailSender : IDbService
    {
        bool SendEmail(string logMessage);
    }
}
