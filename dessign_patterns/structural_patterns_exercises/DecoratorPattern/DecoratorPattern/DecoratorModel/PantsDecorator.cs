namespace DecoratorModel
{
    class PantsDecorator : ClothBaseDecorator
    {
        private const double _pantsTemperature = 1.7;
        public PantsDecorator(WormerBaseInterface wormer) : base(wormer)
        {
            wormer.BaseTemperature += _pantsTemperature;
        }

        public override string WormUp()
        {
            return $"\n The {this.GetType().ToString()} is on " +
            $"and the temperature has been incresed by {_pantsTemperature} grades " +
            $" {base.WormUp()}";
        }

    }
}

