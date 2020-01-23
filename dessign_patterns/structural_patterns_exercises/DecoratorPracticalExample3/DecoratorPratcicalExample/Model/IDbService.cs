namespace DecoratorPratcicalExample.Model
{
    public interface IDbService
    {
        bool Save(ITodoEvent todoEvent);
    }
}
