namespace FactoryPatternCustomized.FactoryModel
{
    using FactoryPatternCustomized.FactoryModel.TransportationEntities;
    public class DeliveryForm
    {
        protected Cargo _cargo;
        protected TransportInformation _transport;
        protected double _totalPrice;
        protected string GetBaseFormText(Cargo cargo, TransportInformation transport) 
        {
            return $"\n transport caracteristics: " +
                   $"\n Type Of Transportation: {transport.TypeOfTransportation.ToString()} " +
                   $"\n Price: {_totalPrice} $" +
                   $"\n cargos caracteristics: " +
                   $"\n Weight: {cargo.WeightInGrams} Grams" +
                   $"\n Volume: {cargo.VolumeInCubicMilimeters} cubic Mls";
        }
    }
}
