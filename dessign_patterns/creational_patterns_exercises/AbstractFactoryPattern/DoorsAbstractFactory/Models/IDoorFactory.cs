namespace DoorsAbstractFactory.Models
{
    using System.Collections.Generic;

    public interface IDoorFactory
    {
        abstract IList<IDoor>  CreateClassicDoor(IDoorBlooprint blooprint, int amounth);
        abstract IList<IDoor> CreateModernDoor(IDoorBlooprint blooprint, int amounth);
    }
} 
