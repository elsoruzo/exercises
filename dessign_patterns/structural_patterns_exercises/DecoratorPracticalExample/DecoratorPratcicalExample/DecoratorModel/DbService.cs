namespace DecoratorPratcicalExample.DecoratorModel
{
    using System;
    public class DbService: IDbService
    {
        public bool WriteToDb(string logMessage) 
        {
            Console.WriteLine($"\n Writting to db data: \n {logMessage}");
            return true;
        }
    }
}
