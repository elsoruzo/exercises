
namespace AdapterModel
{

    public abstract class AbstractAdoptee
    {
        private int _voltage;

        protected int Get_voltage()
        {
            return _voltage;
        }

        protected void Set_voltage(int value)
        {
            _voltage = value;
        }

        public int GetElectricity()
        {
            return Get_voltage();
        }
    }
}



