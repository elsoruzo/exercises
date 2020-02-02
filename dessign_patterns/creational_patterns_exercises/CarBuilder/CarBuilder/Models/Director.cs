namespace CarBuilder.Models
{
    public class Director
    {
        private ICarBuilder _builder;

        public ICarBuilder Builder
        {
            set { _builder = value; }
        }

        public void buildMinimalViableProduct()
        {
            this._builder.SetEngine();
            this._builder.SetSeats();
        }

        public void buildFullFeaturedProduct()
        {
            this._builder.SetEngine();
            this._builder.SetSeats();
            this._builder.SetGps();
            this._builder.SetTripComputer();
        }
    }
}
