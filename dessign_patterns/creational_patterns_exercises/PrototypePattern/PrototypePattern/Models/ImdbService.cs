namespace PrototypePattern.Models
{
    using System;

    public class ImdbService
    {
        public void SendDataToImdb(IMovieCharacteristics movieCharacteristics)
        {
            Console.WriteLine("Sending to IMDB data: " + movieCharacteristics);
        }
    }
}
