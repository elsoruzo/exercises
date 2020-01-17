namespace DecoratorModel
{
    class PantsDecorator : ClothBaseDecorator
    {
        private const double _pantsTemperature = 1.7;
        private double _baseTemperatureWithPants;
        public PantsDecorator(WormerBaseInterface wormer) : base(wormer)
        {
            wormer.BaseTemperature += _pantsTemperature;
            var person = wormer as ConcretePerson;
            if (person != null)
            {
                wormer.BaseTemperature += person.BodyTemperature;
            }
            _baseTemperatureWithPants = wormer.BaseTemperature;
            this.BaseTemperature = _baseTemperatureWithPants;
        }
        public override string WormUp(double temperature)
        {
            return $"\n The {this.GetType().ToString()} is on " +
            $"and the temperature has been incresed by {_pantsTemperature} grades " +
            $" {base.WormUp(temperature)}";
        }

    }
}

