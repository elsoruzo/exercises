namespace AdapterModel
{
    public class UsbPortAdapter : AbstractAdapter
    {
        public UsbPortAdapter(AbstractAdoptee adaptee) :
            base(adaptee)
        {
            OutputVoltage = GetTransformedVoltage(adaptee.GetElectricity(), TargetVoltageLaptop);
        }

    }
}
