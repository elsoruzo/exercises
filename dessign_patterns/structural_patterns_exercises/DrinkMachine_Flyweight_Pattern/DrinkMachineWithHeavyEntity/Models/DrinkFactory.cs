using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DrinkMachineWithHeavyEntity.Models
{
    public class DrinkFactory
    {


        public Drink GetDrink(string drinkKey)
        {

            switch (drinkKey)
            {
                case "Espresso":
                    return new Drink()
                    {
                        Matter = "Espresso",
                        Shugar = false,
                        Color = "Brown",
                        TextureOfDrink = Image.FromFile(@"..\..\..\GLIF2017_maps_9-21\\GLIF2017_Europe_Africa_8k_9-21.jpg"),
                        Size = 300,
                        Stick = false,
                        TextureOfCup = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_SouthAmerica_8k_9-21.jpg"),
                        Price = 3.59
                    };
                    break;
                case "Coffee":
                    return new Drink()
                    {
                        Matter = "Coffee",
                        Shugar = false,
                        Color = "Black",
                        TextureOfDrink = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_Europe_Africa_8k_9-21.jpg"),
                        Size = 250,
                        Stick = false,
                        TextureOfCup = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_SouthAmerica_8k_9-21.jpg"),
                        Price = 3.89
                    };
                    break;
                case "Tea":
                    return new Drink()
                    {
                        Matter = "Tea",
                        Shugar = false,
                        Color = "Brown",
                        TextureOfDrink = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_Europe_Africa_8k_9-21.jpg"),
                        Size = 300,
                        Stick = false,
                        TextureOfCup = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_SouthAmerica_8k_9-21.jpg"),
                        Price = 1.59
                    };
                    break;
                case "CocaCola":
                    return new Drink()
                    {
                        Matter = "CocaCola",
                        Shugar = false,
                        Color = "Black",
                        TextureOfDrink = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_Europe_Africa_8k_9-21.jpg"),
                        Size = 300,
                        Stick = false,
                        TextureOfCup = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_SouthAmerica_8k_9-21.jpg"),
                        Price = 6.59
                    };
                    break;
                case "Pepsi":
                    return new Drink()
                    {
                        Matter = "Pepsi",
                        Shugar = false,
                        Color = "Black",
                        TextureOfDrink = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_Europe_Africa_8k_9-21.jpg"),
                        Size = 250,
                        Stick = false,
                        TextureOfCup = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_SouthAmerica_8k_9-21.jpg"),
                        Price = 7.59
                    };
                    break;
                case "Sprite":
                    return new Drink()
                    {
                        Matter = "Sprite",
                        Shugar = false,
                        Color = "Transparent",
                        TextureOfDrink = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_Europe_Africa_8k_9-21.jpg"),
                        Size = 250,
                        Stick = false,
                        TextureOfCup = Image.FromFile("..\\..\\..\\GLIF2017_maps_9-21\\GLIF2017_SouthAmerica_8k_9-21.jpg"),
                        Price = 3.59
                    };
                    break;
                default:
                    throw new Exception("This is not a flyweight drink object...");
            }

        }

    }
}
