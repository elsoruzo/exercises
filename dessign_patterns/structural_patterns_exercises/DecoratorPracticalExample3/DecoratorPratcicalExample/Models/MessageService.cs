namespace DecoratorPratcicalExample.Models
{
    using System;
    public class MessageService : IMessageService
    {
        public bool SendMessage(IMessageEvent message)
        {
            Console.WriteLine($"\n Sent a message :\n event type: {message.EventType}\n person's name {message.PersonName} \n state of action {message.IsDone}");
            return true;
        }

    }
}
