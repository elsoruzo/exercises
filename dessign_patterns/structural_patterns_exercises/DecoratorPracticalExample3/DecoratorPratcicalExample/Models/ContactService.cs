namespace DecoratorPratcicalExample.Models
{
    using System;
    public class ContactService : IContactService
    {
        public bool IsPersonOnLine(IMessageEvent message)
        {
            Console.WriteLine($"\n Checking if the person is on line.");
            return message.PersonName == "YAKOV";
        }

    }
}
