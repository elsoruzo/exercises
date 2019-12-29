namespace FactoryModel
{
    using FactoryPatternCustomized.FactoryModel;
    using FactoryPatternCustomized.FactoryModel.TransportationEntities;

    class DeliveryViaTrainForm : DeliveryForm, IFormText
    {
        public DeliveryViaTrainForm(Cargo cargo, TransportInformation transport, double totalPrice)
        {
            _cargo = cargo;
            _transport = transport;
            _totalPrice = totalPrice;
        }
        public string GetTextForForm()
        {
            return $"Delivery Via Train Form  {GetBaseFormText(_cargo, _transport)}";
        }
    }
}
