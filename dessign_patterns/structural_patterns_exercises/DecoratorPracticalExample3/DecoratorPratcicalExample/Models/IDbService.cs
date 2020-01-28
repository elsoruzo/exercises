namespace DecoratorPratcicalExample.Models
{
    public interface IDbService
    {
        bool Save(ITodoEvent todoEvent);
    }
}
