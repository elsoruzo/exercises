namespace AdapterPatternCustomized.AdapterModel
{
    using System;

    public class LapTop
    {
        private const int _inputVoltage = 9;

        public LapTop(int inputVoltage)
        {

            if (inputVoltage == _inputVoltage)
                Console.WriteLine("Voltage is correct");
            else 
                Console.WriteLine("Voltage is incorrect, \n BOOM!");

        }
    }
}
