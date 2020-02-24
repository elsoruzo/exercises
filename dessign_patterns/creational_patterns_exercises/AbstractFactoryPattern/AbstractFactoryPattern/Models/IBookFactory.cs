namespace AbstractBookPublishingFactory.Models
{
    public interface IBookFactory
    {
        IBook MakeBook();
        IPublisher MakePublisher();
    }
}
