namespace CarBuilder.Models
{

    public class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();
        public CarBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._car = new Car();
        }

        public Car GetCar()
        {
            Car result = this._car;

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
