namespace DecoratorPratcicalExample.Models
{
    using System;
    public class MessageService : IMessageService
    {
        public bool Send(IMessageEvent message)
        {
            Console.WriteLine($"\n Sent a message :\n event type: {message.EventType}\n person's name {message.PersonName} \n The message was sent to:");
            foreach(var to in message.To)
            {
                Console.WriteLine($"{to}");
            }
            return true;
        }

    }
}
