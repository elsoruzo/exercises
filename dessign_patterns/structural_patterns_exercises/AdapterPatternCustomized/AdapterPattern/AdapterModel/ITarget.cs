namespace AdapterModel
{
 
    public interface ITarget
    {
        int GetTransformedVoltage(int voltageToTansform, int targetVoltage);
    }
}
