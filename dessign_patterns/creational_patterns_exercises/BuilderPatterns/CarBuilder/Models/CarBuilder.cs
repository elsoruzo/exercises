namespace CarBuilder.Models
{
    using System;
    public class CarBuilder : ICarBuilder
    {
        private Car _car = null;
        public CarBuilder()
        {
            this.Init();
        }

        public ICarBuilder Init()
        {
            this._car = new Car();
            return this;
        }

        private void CheckCarIsNotNull()
        {
            if (_car == null)
                throw new Exception();
        }

        public Car GetResult()
        {
            CheckCarIsNotNull();
            return this._car;
        }

        public ICarBuilder SetSeats(int amounth)
        {
            CheckCarIsNotNull();
            this._car.Seats = amounth;
            return this;
        }

        public ICarBuilder SetEngine(string type)
        {
            CheckCarIsNotNull();
            this._car.Engine = type;
            return this;
        }

        public ICarBuilder SetTripComputer()
        {
            CheckCarIsNotNull();
            this._car.IsHasTripComputer = true;
            return this;
        }

        public ICarBuilder SetGps()
        {
            CheckCarIsNotNull();
            this._car.IsHasGps = true;
            return this;
        }
    }
}
