namespace DecoratorModel
{
    class CoatDecorator : ClothBaseDecorator
    {

        private const double _coatTemperature = 5.2;
        private double _baseTemperatureWithCoat;
        public CoatDecorator(WormerBaseInterface wormer) : base(wormer)
        {
            wormer.BaseTemperature += _coatTemperature;
            var person = wormer as ConcretePerson;
            if (person != null)
            {
                wormer.BaseTemperature += person.BodyTemperature;
            }
            _baseTemperatureWithCoat = wormer.BaseTemperature;
            this.BaseTemperature = _baseTemperatureWithCoat;
        }

        public override string WormUp(double temperature)
        {
            return $"\n The {this.GetType().ToString()} is on " +
            $"and the temperature has been incresed by {_coatTemperature} grades " +
            $" {base.WormUp(temperature)}";
        }

    }
}
