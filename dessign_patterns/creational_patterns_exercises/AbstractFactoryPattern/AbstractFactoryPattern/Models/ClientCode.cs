namespace AbstractBookPublishingFactory.Models
{
    public class ClientCode
    {
        public void Publish(IBookFactory factory)
        {
            factory.MakeBook();
            factory.MakePublisher();
        }
    }
}
