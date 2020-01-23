namespace DecoratorPratcicalExample.DecoratorModel
{
    public interface IDbService
    {
        bool WriteToDb(string logMessage);
    }
}
