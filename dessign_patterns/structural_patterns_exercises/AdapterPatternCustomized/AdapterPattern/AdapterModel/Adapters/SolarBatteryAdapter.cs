namespace AdapterModel
{
    public class SolarBatteryAdapter : AbstractAdapter
    {
        public SolarBatteryAdapter(AbstractAdoptee adaptee) :
            base(adaptee)
        {
            OutputVoltage = GetTransformedVoltage(adaptee.GetElectricity(), TargetVoltageLaptop);
        }

    }
}
