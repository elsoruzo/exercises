namespace DoorsAbstractFactory
{
    using System;
    using DoorsAbstractFactory.Models;

    class Program
    {
        static void Main(string[] args)
        {
            var vegaBluprint = new DoorBlooprint();
            vegaBluprint.High = 11;
            vegaBluprint.Width = 0;
            vegaBluprint.Depth = 0;
            vegaBluprint.Color = "Green";
            vegaBluprint.Material = "Wood";
            var vegaAFactory = new VegaFactory("VegaA");
            var classicVegaADoor = vegaAFactory.CreateClassicDoor(vegaBluprint, 40);
            foreach(var door in classicVegaADoor)
            {
                Console.WriteLine($"High { door.High} Width { door.Width } Depth {  door.Depth  } Material { door.Material } Decoration { door.Decoration } Design {door.Design } Model { door.Model } Color { door.Color }");
            }

            var modernAVegaADoor = vegaAFactory.CreateModernDoor(vegaBluprint, 30);
            foreach (var door in modernAVegaADoor)
            {
                Console.WriteLine($"High { door.High} Width { door.Width } Depth {  door.Depth  } Material { door.Material } Decoration { door.Decoration } Design {door.Design } Model { door.Model } Color { door.Color }");
            }

            var vegaBFactory = new VegaFactory("VegaB");
            var classicVegaBDoor = vegaBFactory.CreateClassicDoor(vegaBluprint, 15);
            foreach (var door in classicVegaBDoor)
            {
                Console.WriteLine($"High { door.High} Width { door.Width } Depth {  door.Depth  } Material { door.Material } Decoration { door.Decoration } Design {door.Design } Model { door.Model } Color { door.Color }");
            }
            var modernVegaBDoor = vegaBFactory.CreateModernDoor(vegaBluprint, 35);
            foreach (var door in modernVegaBDoor)
            {
                Console.WriteLine($"High { door.High} Width { door.Width } Depth {  door.Depth  } Material { door.Material } Decoration { door.Decoration } Design {door.Design } Model { door.Model } Color { door.Color }");
            }
            var sedaBluprint = new DoorBlooprint();
            sedaBluprint.High = 110;
            sedaBluprint.Width = 50;
            sedaBluprint.Depth = 10;
            sedaBluprint.Color = "Blue";
            sedaBluprint.Material = "Metal";
            var sedaAFactory = new SedaFactory("SedaA");

            foreach (var door in sedaAFactory.CreateClassicDoor(sedaBluprint, 40))
            {
                Console.WriteLine($"High { door.High} Width { door.Width } Depth {  door.Depth  } Material { door.Material } Decoration { door.Decoration } Design {door.Design } Model { door.Model } Color { door.Color }");
            }

            foreach (var door in sedaAFactory.CreateModernDoor(sedaBluprint, 30))
            {
                Console.WriteLine($"High { door.High} Width { door.Width } Depth {  door.Depth  } Material { door.Material } Decoration { door.Decoration } Design {door.Design } Model { door.Model } Color { door.Color }");
            }
            var sedaBFactory = new SedaFactory("SedaB");

            foreach (var door in sedaBFactory.CreateClassicDoor(sedaBluprint, 40))
            {
                Console.WriteLine($"High { door.High} Width { door.Width } Depth {  door.Depth  } Material { door.Material } Decoration { door.Decoration } Design {door.Design } Model { door.Model } Color { door.Color }");
            }

            foreach (var door in sedaBFactory.CreateModernDoor(sedaBluprint, 30))
            {
                Console.WriteLine($"High { door.High} Width { door.Width } Depth {  door.Depth  } Material { door.Material } Decoration { door.Decoration } Design {door.Design } Model { door.Model } Color { door.Color }");
            }
        }
    }
}
