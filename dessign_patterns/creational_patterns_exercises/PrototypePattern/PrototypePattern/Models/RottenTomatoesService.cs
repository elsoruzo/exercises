namespace PrototypePattern.Models
{
    using System;

    public class RottenTomatoesService
    {
        public void SendDataToRottenTomatoes(IMovieCharacteristics movieCharacteristics)
        {
            Console.WriteLine("Sending to RottenTomatoes data: " + movieCharacteristics);
        }
    }
}
