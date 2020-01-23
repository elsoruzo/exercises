namespace DecoratorModel
{
    class HouseDecorator : ClothBaseDecorator
    {

        private const double _houseTemperature = 7.2;
        private double _baseTemperatureWithHouse;
        public HouseDecorator(WormerBaseInterface wormer) : base(wormer)
        {
            wormer.BaseTemperature += _baseTemperatureWithHouse;
            var person = wormer as ConcretePerson;
            if (person != null)
            {
                wormer.BaseTemperature += person.BodyTemperature;
            }
            _baseTemperatureWithHouse = wormer.BaseTemperature;
            this.BaseTemperature = _baseTemperatureWithHouse;
        }

        public override string WormUp(double temperature)
        {
            return $"\n The {this.GetType().ToString()} is on " +
            $"and the temperature has been incresed by {_houseTemperature} grades " +
            $" {base.WormUp(temperature)}";
        }

    }
}

