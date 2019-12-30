namespace AdapterModel
{
    public abstract class AbstractAdapter : ITarget
    {
        public const int TargetVoltageLaptop = 9;
        public int OutputVoltage;
        protected readonly AbstractAdoptee _adaptee;

        public AbstractAdapter(AbstractAdoptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public int GetTransformedVoltage(int voltageToTansform, int targetVoltage)
        {
            if (voltageToTansform > targetVoltage)
            {
                var voltageDifference = voltageToTansform - targetVoltage;
                return voltageToTansform - voltageDifference;
            }
            else
            {
                var voltageDifference = targetVoltage - voltageToTansform;
                return voltageToTansform + voltageDifference;
            }
        }

    }
}
