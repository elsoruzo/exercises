using DrinkMachineWithHeavyEntity.Models;

namespace DrinkMachineWithHeavyEntity
{
    class Program
    {
        static void Main(string[] args)
        {

            //Image imageEuropeAfrica = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_Europe_Africa_8k_9-21.jpg");
            //Image imageSouthAmerica = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_SouthAmerica_8k_9-21.jpg");
            //Image imageSouthAmericaCrop = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_SouthAmericaCrop_8k_9-21.jpg");
            //Image imageEuropeIndia = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_Europe-India_8k_9-21.jpg");
            //Image imageNorthAmerica = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_NorthAmerica_8k_9-21.jpg");
            //Image imageEurope = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_Europe_8k_9-21.jpg");
            //Image imageWorld = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_World_8k_9-21.jpg");
            //Image imageAsia = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_Asia_8k_9-21.jpg");
            var factory = new DrinkFactory();
            factory.GetDrink("Espresso");
            factory.GetDrink("Coffee");
            factory.GetDrink("Tea");
            factory.GetDrink("CocaCola"); 
            factory.GetDrink("Pepsi");
            factory.GetDrink("Sprite");
        }
    }
}
