namespace CarBuilder.Models
{
    public class Director
    {
        private ICarBuilder _builder;

        public ICarBuilder Builder
        {
            set { _builder = value; }
        }

        public ICar buildMinimalViableCar()
        {
            return _builder.Init()
                           .SetEngine("4 cilinders basic engine")
                           .SetSeats(4)
                           .GetResult();
        }

        public ICar buildFullFeaturedCar()
        {
            return _builder.Init()
                           .SetEngine("V8")
                           .SetSeats(4)
                           .SetGps()
                           .GetResult();

        }
    }
}
