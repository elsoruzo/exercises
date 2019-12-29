using FactoryPatternCustomized.FactoryModel.TransportationEntities;

namespace FactoryModel
{

    abstract class DeliveryStatementFormFactory
    {
        protected Cargo _cargo;
        public abstract IFormText CreateFormsBase();
        public double GetTotalPrice(TransportInformation transport, Cargo cargo) 
        {
            var transportCoeficient = (int)transport.TypeOfTransportation.GetTypeCode();
            var totalCoefiscient  = cargo.VolumeInCubicMilimeters * cargo.WeightInGrams * transportCoeficient;
            return transport.Price + totalCoefiscient;
        }

        public string CreateForm()
        {

            var baseForm = CreateFormsBase();

            var result = $"Delivery Statement Form: \n { baseForm.GetTextForForm()}";

            return result;
        }
    }
}
