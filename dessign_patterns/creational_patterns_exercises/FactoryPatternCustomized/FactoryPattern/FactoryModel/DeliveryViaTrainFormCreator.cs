namespace FactoryModel
{
    using FactoryPatternCustomized.FactoryModel.TransportationEntities;

    class DeliveryViaTrainFormCreator : DeliveryStatementFormFactory
    {
        private const double TrainPrice = 122.36;
        private TransportInformation _transportInfo = new TransportInformation()
        {
            TypeOfTransportation = TransportType.Train,
            Price = TrainPrice
};
        public DeliveryViaTrainFormCreator(Cargo cargo) { _cargo = cargo; }
        public override IFormText CreateFormsBase()
        {
            double totalPrice = GetTotalPrice(_transportInfo, _cargo);
            return new DeliveryViaTrainForm(_cargo, _transportInfo, totalPrice);
        }
    }
}
