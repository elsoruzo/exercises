namespace DecoratorPratcicalExample.DecoratorModel
{
    public interface ISmsSender : IDbService
    {
        bool SendSms(string logMessage);
    }
}
