namespace DecoratorModel
{
    class TshirtDecorator : ClothBaseDecorator
    {
        private const double _tshirtTemperature = 1.2;
        private double _baseTemperatureWithTshort;
        public TshirtDecorator(WormerBaseInterface wormer) : base(wormer)
        {
            wormer.BaseTemperature += _tshirtTemperature;
            var person = wormer as ConcretePerson;
            if (person != null)
            {
                wormer.BaseTemperature += person.BodyTemperature;
            }
            _baseTemperatureWithTshort = wormer.BaseTemperature;
            this.BaseTemperature = _baseTemperatureWithTshort;
        }

        public override string WormUp(double temperature)
        {
            return $"\n The {this.GetType().ToString()} is on " +
            $"and the temperature has been incresed by {_tshirtTemperature} grades " +
            $" {base.WormUp(temperature)}";
        }

    }
}

