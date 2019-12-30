namespace AdapterModel
{

    public class AmericanSocketAdapter : AbstractAdapter
    {
        public AmericanSocketAdapter(AbstractAdoptee adaptee) :
            base(adaptee)
        {
            OutputVoltage = GetTransformedVoltage(adaptee.GetElectricity(), TargetVoltageLaptop);
        }
    }
}
