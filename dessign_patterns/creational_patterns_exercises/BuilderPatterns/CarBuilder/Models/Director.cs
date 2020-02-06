namespace CarBuilder.Models
{
    public class Director
    {
        private ICarBuilder _builder;

        public ICarBuilder Builder
        {
            set { _builder = value; }
        }

        public void buildMinimalViableCar()
        {
            this._builder.SetEngine("4 cilinders basic engine");
            this._builder.SetSeats(4);
        }

        public void buildFullFeaturedCar()
        {
            this._builder.SetEngine("V8");
            this._builder.SetSeats(4);
            this._builder.SetGps();
            this._builder.SetTripComputer();
        }
    }
}
