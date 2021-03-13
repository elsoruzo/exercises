using System;
using DesignPatterns.Facade.Conceptual;
using DesignPatterns.Facade.Practical;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("BASIC IMPLEMENTATION \n");
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
            Client.ClientCode(facade);

            Console.Write("VideoConversionFacade \n");
            VideoConversionFacade converter = new VideoConversionFacade();
            VideoFile mp4Video = converter.ConvertVideo("youtubevideo.ogg", "mp4");
        }
    }
}
