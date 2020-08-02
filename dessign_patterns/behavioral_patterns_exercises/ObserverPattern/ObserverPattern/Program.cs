using ObserverPattern.Models;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new MessageStream();
            PhoneClient phoneClient = new PhoneClient(subject);
            TabletClient tabletClient = new TabletClient(subject);

            phoneClient.AddMessage("Here is a new message!");
            tabletClient.AddMessage("Another new message!");
        }
    }
}