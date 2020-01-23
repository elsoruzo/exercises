namespace ConsoleImplementationOfDecorator
{
    using System;
    using DecoratorModel;
    static class Program
    {

        static void Main()
        {
            Console.WriteLine("To exit press E or Press any key to START decorating");
            char command = Console.ReadKey().KeyChar;

            Console.WriteLine("START RUNNING DECORATOR.");
            WormerBaseInterface entityToDecorate;
            Client client = new Client();

            Console.WriteLine("App: created a PERSON.");
            ConcretePerson person = new ConcretePerson();
            Console.WriteLine("App: Aply client code for the Person component.");


            Console.WriteLine("Enter the temperature of the enviroment. The temperature is quantified as bellow zero becouse now is winter");
            double temperatureOutside = double.Parse(Console.ReadLine());
            person.BodyTemperature -= temperatureOutside;
            Console.WriteLine($"The current BodyTemperature of the person is: {person.BodyTemperature:F}");
            client.ClientCode(person, person.BodyTemperature);
            entityToDecorate = person;
            while (command != 'E')
            {
                Console.WriteLine("To decorate the PERSON with the PANTS press 1");
                Console.WriteLine("To decorate the PERSON with the TSHORT press 2");
                Console.WriteLine("To udecorate the PERSON with the JUMPER press 3");
                Console.WriteLine("To decorate the PERSON with the COAT press 4");
                Console.WriteLine("To decorate the PERSON with the HOUSE press 5");
                Console.WriteLine("To exit press E");
                command = Console.ReadKey().KeyChar;

                switch (command)
                {
                    case '1':
                        Console.WriteLine("\n App: The Person is decorated with Pants.");
                        entityToDecorate = new PantsDecorator(entityToDecorate);
                        break;
                    case '2':
                        Console.WriteLine("\n App: The Person is decorated with Tshirt.");
                        entityToDecorate = new TshirtDecorator(entityToDecorate);
                        break;
                    case '3':
                        Console.WriteLine("\n App: The Person is decorated with Jumper.");
                        entityToDecorate = new JumperDecorator(entityToDecorate);

                        break;
                    case '4':
                        Console.WriteLine("\n App: The Person is decorated with Coat.");
                        entityToDecorate = new CoatDecorator(entityToDecorate);

                        break;
                    case '5':
                        Console.WriteLine("\n App: The Person is decorated with House.");
                        entityToDecorate = new HouseDecorator(entityToDecorate);
                        break;

                    default:
                        Console.WriteLine("\n Something went wrong. Please try again.");
                        break;
                }
            }
            Console.WriteLine("\n App: Aply client code for the Decorated component.");
            client.ClientCode(entityToDecorate, entityToDecorate.BaseTemperature);
            Console.WriteLine("END RUNNING ADAPTER.");
            Console.ReadKey();

        }
    }
}













