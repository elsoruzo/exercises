namespace AdapterModel
{
    public class CarBatteryAdapter : AbstractAdapter
    {

        public CarBatteryAdapter(AbstractAdoptee adaptee) :
            base(adaptee)
        {
            OutputVoltage = GetTransformedVoltage(adaptee.GetElectricity(), TargetVoltageLaptop);
        }

    }
}
