using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternCustomized.FactoryModel.TransportationEntities
{
    public class Cargo
    {
        public int WeightInGrams { get; set; }

        public int VolumeInCubicMilimeters { get; set; }
        //{ 
        //    get => (int)Math.Sqrt(VolumeInCubicMilimeters); 
        //    set => _ = value * value; 
        //}
    }
}
