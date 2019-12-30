namespace AdapterModel
{
    public class BicicleDinamoAdapter : AbstractAdapter
    {
        public BicicleDinamoAdapter(AbstractAdoptee adaptee) :
            base(adaptee)
        {
            OutputVoltage = GetTransformedVoltage(adaptee.GetElectricity(), TargetVoltageLaptop);
        }

    }
}
