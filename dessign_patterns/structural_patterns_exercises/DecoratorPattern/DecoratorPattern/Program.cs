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
                Console.WriteLine("To decorate the PERSON with the TSHORT press 1");
                Console.WriteLine("To decorate the PERSON with the PANTS press 2");
                Console.WriteLine("To udecorate the PERSON with the TSHORT press 3");
                Console.WriteLine("To decorate the PERSON with the TSHORT press 4");
                Console.WriteLine("To decorate the PERSON with the TSHORT press 5");
                Console.WriteLine("To decorate the PERSON with the TSHORT press 6");
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

                        break;
                    case '4':


                        break;
                    case '5':


                        break;
                    case '6':
                        break;
                    default:
                        Console.WriteLine("\n Something went wrong. Please try again.");
                        break;
                        //entityToDecorate = entityToDecorate as WormerBaseInterface;
                }
            }
            Console.WriteLine("\n App: Aply client code for the Decorated component.");
            client.ClientCode(entityToDecorate, entityToDecorate.BaseTemperature);
            Console.WriteLine("END RUNNING ADAPTER.");
            Console.ReadKey();


            //Client client = new Client();
            //var person1 = new ConcretePerson1();

            //Console.WriteLine("Client: I get a simple component:");

            //Console.WriteLine();
            
            //person1.BodyTemperature -= temperatureOutside;
            
            //Console.WriteLine($"The current BodyTemperature of the person is: {person1.BodyTemperature:F}");
            //client.ClientCode(person1, person1.BodyTemperature);

            //PantsDecorator personInPants = new PantsDecorator(person1);
            
            //TshirtDecorator personInPantsAndTshirt = new TshirtDecorator(personInPants);
            //Console.WriteLine("Client: Now I've got a decorated component:");
            //client.ClientCode(personInPantsAndTshirt, personInPantsAndTshirt.BaseTemperature);
            
            //Console.ReadKey();

            //if (command == 'E')
            //{
            //    return;
            //};
            //var entityToDecorateNestIteration = entityToDecorate as WormerBaseInterface;

        }
    }
}













