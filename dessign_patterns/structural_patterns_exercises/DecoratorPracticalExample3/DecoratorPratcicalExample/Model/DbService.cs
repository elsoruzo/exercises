namespace DecoratorPratcicalExample.Model
{
    using System;
    public class DbService: IDbService
    {
        public bool Save(ITodoEvent todoEvent)
        {
            Console.WriteLine($"\n Writting to db data: \n Event type: {todoEvent.EventType} \n Person Name: {todoEvent.PersonName}");
            return true;
        }

    }
}
