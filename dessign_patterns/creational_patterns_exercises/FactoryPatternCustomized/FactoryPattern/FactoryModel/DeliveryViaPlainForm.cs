namespace FactoryModel
{
    using FactoryPatternCustomized.FactoryModel;
    using FactoryPatternCustomized.FactoryModel.TransportationEntities;

    class DeliveryViaPlainForm : DeliveryForm, IFormText
    {

        public DeliveryViaPlainForm(Cargo cargo, TransportInformation transport, double totalPrice)
        {
            _cargo = cargo;
            _transport = transport;
            _totalPrice = totalPrice;
        }
        public string GetTextForForm()
        {
            return $"Delivery Via Plain Form  {GetBaseFormText(_cargo, _transport)}";
        }
    }
}
