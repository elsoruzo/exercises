namespace AdapterModel
{
    public class TurbineGeneratorAdapter : AbstractAdapter
    {
        public TurbineGeneratorAdapter(AbstractAdoptee adaptee) :
            base(adaptee)
        {
            OutputVoltage = GetTransformedVoltage(adaptee.GetElectricity(), TargetVoltageLaptop);
        }

    }
}
