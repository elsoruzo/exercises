namespace DecoratorModel
{
    class JumperDecorator : ClothBaseDecorator
    {

        private const double _jumperTemperature = 3.2;
        private double _baseTemperatureWithJumper;
        public JumperDecorator(WormerBaseInterface wormer) : base(wormer)
        {
            wormer.BaseTemperature += _jumperTemperature;
            var person = wormer as ConcretePerson;
            if (person != null)
            {
                wormer.BaseTemperature += person.BodyTemperature;
            }
            _baseTemperatureWithJumper = wormer.BaseTemperature;
            this.BaseTemperature = _baseTemperatureWithJumper;
        }

        public override string WormUp(double temperature)
        {
            return $"\n The {this.GetType().ToString()} is on " +
            $"and the temperature has been incresed by {_jumperTemperature} grades " +
            $" {base.WormUp(temperature)}";
        }

    }
}

