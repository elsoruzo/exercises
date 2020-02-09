namespace CarBuilder.Models
{

    public class ReceiptBuilder : IReceiptBuilder
    {
        private Receipt _car = new Receipt();
        public ReceiptBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._car = new Receipt();
        }

        public Receipt GetCar()
        {
            Receipt result = this._car;

            this.Reset();

            return result;
        }
        
        public void SetSeats(int amounth)
        {
            this._car.Seats = amounth;
        }

        public void SetEngine(string type)
        {
            this._car.Engine = type;
        }

        public void SetTripComputer()
        {
            this._car.IsHasTripComputer = true;
        }

        public void SetGps()
        {
            this._car.IsHasGps = true;
        }
    }
}
