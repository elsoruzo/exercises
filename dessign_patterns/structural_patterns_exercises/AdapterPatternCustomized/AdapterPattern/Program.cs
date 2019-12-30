namespace ConsoleImplementationOfAdapter
{
    using System;
    using AdapterModel;
    using AdapterPatternCustomized.AdapterModel;

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("START RUNNING ADAPTER.");
            Console.WriteLine("To use american socket press 1");
            Console.WriteLine("To use bicicle dinamo press 2");
            Console.WriteLine("To use car battery press 3");
            Console.WriteLine("To use solar battery press 4");
            Console.WriteLine("To use turbine generator press 5");
            Console.WriteLine("To use usb port press 6");

            char adapter = Console.ReadKey().KeyChar;

            switch (adapter)
            {
                case '1':
                    Console.WriteLine("App: Launched american socket.");
                    AmericanSocket amerSocket = new AmericanSocket();
                    AmericanSocketAdapter amerSocketAdapter = new AmericanSocketAdapter(amerSocket);
                    _ = new LapTop(amerSocketAdapter.OutputVoltage);
                    break;
                case '2':
                    Console.WriteLine("App: Launched bicicle dinamo.");
                    BicicleDinamo bicicleDinamo  = new BicicleDinamo();
                    UsbPortAdapter bicicleDinamoAdapter = new UsbPortAdapter(bicicleDinamo);
                    _ = new LapTop(bicicleDinamoAdapter.OutputVoltage);
                    break;
                case '3':
                    Console.WriteLine("App: Launched car battery.");
                    CarBattery carBattery = new CarBattery();
                    CarBatteryAdapter carBatteryAdapter = new CarBatteryAdapter(carBattery);
                    _ = new LapTop(carBatteryAdapter.OutputVoltage);
                    break;
                case '4':
                    Console.WriteLine("App: Launched solar battery.");
                    SolarBattery solarBattery = new SolarBattery();
                    SolarBatteryAdapter solarBatteryAdapter = new SolarBatteryAdapter(solarBattery);
                    _ = new LapTop(solarBatteryAdapter.OutputVoltage);
                    break;
                case '5':
                    Console.WriteLine("App: Launched turbine generator.");
                    TurbineGenerator turbineGenerator = new TurbineGenerator();
                    TurbineGeneratorAdapter turbineGeneratorAdapter = new TurbineGeneratorAdapter(turbineGenerator);
                    _ = new LapTop(turbineGeneratorAdapter.OutputVoltage);
                    break;
                case '6':
                    Console.WriteLine("App: Launched usb port.");
                    UsbPort usbSource = new UsbPort();
                    UsbPortAdapter usbPortAdapter = new UsbPortAdapter(usbSource);
                    _ = new LapTop(usbPortAdapter.OutputVoltage);
                    break;
                default:
                    Console.WriteLine("Something went wrong. Please try again.");
                    Main(new string[0]);
                    break;
            }

            Console.WriteLine("END RUNNING ADAPTER.");
            Console.ReadKey();
        }
    }
}













