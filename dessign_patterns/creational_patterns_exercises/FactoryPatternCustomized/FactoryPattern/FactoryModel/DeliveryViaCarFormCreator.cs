namespace FactoryModel
{
    using FactoryPatternCustomized.FactoryModel.TransportationEntities;

    class DeliveryViaCarFormCreator : DeliveryStatementFormFactory
    {
        private const double CarPrice = 12.35;
        private TransportInformation _transportInfo = new TransportInformation()
        {
            TypeOfTransportation = TransportType.Car,
            Price = CarPrice
        };
        public DeliveryViaCarFormCreator(Cargo cargo) { _cargo = cargo; }
        public override IFormText CreateFormsBase()
        {
            double totalPrice = GetTotalPrice(_transportInfo, _cargo);
            return new DeliveryViaCarForm(_cargo, _transportInfo, totalPrice);
        }
    }
}