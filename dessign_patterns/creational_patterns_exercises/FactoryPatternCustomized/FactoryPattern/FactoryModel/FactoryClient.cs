namespace FactoryModel
{
    using FactoryPatternCustomized.FactoryModel.TransportationEntities;
    using System;
    using System.Globalization;

    class FactoryClient
    {
        private static int CallTryParse(string stringToConvert, NumberStyles styles)
        {
            CultureInfo provider;
            int number = 0;

            // If currency symbol is allowed, use en-US culture.
            if ((styles & NumberStyles.AllowCurrencySymbol) > 0)
                provider = new CultureInfo("en-US");
            else
                provider = CultureInfo.InvariantCulture;

            bool success = Int32.TryParse(stringToConvert, styles,
                                         provider, out number);
            if (success)
                Console.WriteLine("Converted '{0}' to {1}.", stringToConvert, number);
            else
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                  Convert.ToString(stringToConvert));
            return number;
        }
        public void Main()
        {
            Console.WriteLine("Let's create a delivery statement form");
            Console.WriteLine("Please enter the cargos characteristics:");
            Console.WriteLine("Please enter the cargos weight in grams:");          
            int weight = CallTryParse(Console.ReadLine(), NumberStyles.Integer);
            Console.WriteLine("Please enter the cargos Volume in cubic milimeters:");
            int volumeInCubicMilimeters = CallTryParse(Console.ReadLine(), NumberStyles.Integer);
            Console.WriteLine("To Delivery Via Plane press 1");
            Console.WriteLine("To Delivery Via Car press 2");
            Console.WriteLine("To Delivery Via Train press 3");
            char transport = Console.ReadKey().KeyChar;
            var cargo = new Cargo() 
            {
                WeightInGrams = weight,
                VolumeInCubicMilimeters = volumeInCubicMilimeters
            };
           
            switch (transport)
            {
                case '1':
                    Console.WriteLine("App: Launched Delivery Via Plane.");
                    ClientCode(new DeliveryViaPlaneFormCreator(cargo));
                    break;
                case '2':
                    Console.WriteLine("App: Launched Delivery Via Car.");
                    ClientCode(new DeliveryViaCarFormCreator(cargo));
                    break;
                case '3':
                    Console.WriteLine("App: Launched Delivery Via Train.");
                    ClientCode(new DeliveryViaTrainFormCreator(cargo));
                    break;
                default:
                    Console.WriteLine("Something went wrong. Please try again.");
                    Main();
                    break;

            }

        }

        public void ClientCode(DeliveryStatementFormFactory factoryCreator)
        {
            // ...
            Console.WriteLine($"works.\n {factoryCreator.CreateForm()}");
            // ...
        }
     }
}
