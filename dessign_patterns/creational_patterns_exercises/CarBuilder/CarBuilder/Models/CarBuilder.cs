namespace CarBuilder.Models
{

    public class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();
        private bool _isRaceCar { get; set; }
        public CarBuilder(bool isRaceCar = false)
        {
            this.Reset();
            this._isRaceCar = isRaceCar;
        }

        public void Reset()
        {
            this._car = new Car();
        }

        public void SetSeats()
        {
            if (_isRaceCar)
                this._car.SetSeats(2);
            else
                this._car.SetSeats(4);
        }

        public void SetEngine()
        {
            if (_isRaceCar)
                this._car.SetEngine("V8");
            else
                this._car.SetEngine("4 cylinders");
        }

        public void SetTripComputer()
        {
            if (!_isRaceCar)
                this._car.SetTripComputer();
        }

        public void SetGps()
        {
            if (!_isRaceCar)
                this._car.SetTripComputer();
        }
        public Car GetCar()
        {
            Car result = this._car;

            this.Reset();

            return result;
        }
    }
}
