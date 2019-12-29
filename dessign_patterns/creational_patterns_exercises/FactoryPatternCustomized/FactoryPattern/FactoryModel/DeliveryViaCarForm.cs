namespace FactoryModel
{
    using FactoryPatternCustomized.FactoryModel;
    using FactoryPatternCustomized.FactoryModel.TransportationEntities;

    class DeliveryViaCarForm : DeliveryForm, IFormText
    {
        public DeliveryViaCarForm(Cargo cargo, TransportInformation transport, double totalPrice)
        {
            _cargo = cargo;
            _transport = transport;
            _totalPrice = totalPrice;
        }
        public string GetTextForForm()
        {
            return $"Delivery Via Car Form  {GetBaseFormText(_cargo, _transport)}";
        }
    }
}
