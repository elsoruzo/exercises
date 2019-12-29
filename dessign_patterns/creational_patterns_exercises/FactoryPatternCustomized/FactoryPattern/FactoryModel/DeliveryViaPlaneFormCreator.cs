namespace FactoryModel
{
    using FactoryPatternCustomized.FactoryModel.TransportationEntities;

    class DeliveryViaPlaneFormCreator : DeliveryStatementFormFactory
    {
        private const double PlanePrice = 300.56;
        private TransportInformation _transportInfo = new TransportInformation()
        {
            TypeOfTransportation = TransportType.Plane,
            Price = PlanePrice
        };
        public DeliveryViaPlaneFormCreator(Cargo cargo) { _cargo = cargo; }
        public override IFormText CreateFormsBase()
        {
            double totalPrice = GetTotalPrice(_transportInfo, _cargo);
            return new DeliveryViaPlainForm(_cargo, _transportInfo, totalPrice);
        }
    }
}