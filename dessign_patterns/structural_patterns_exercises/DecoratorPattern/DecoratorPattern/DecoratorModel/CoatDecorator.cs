namespace DecoratorModel
{
    class CoatDecorator : ClothBaseDecorator
    {

        private const double _coatTemperature = 5.2;
        public CoatDecorator(WormerBaseInterface wormer) : base(wormer)
        {
            wormer.BaseTemperature += _coatTemperature;
        }

        public override string WormUp()
        {
            return $"The {this.GetType().ToString()} is on " +
            $"and the temperature has been incresed by {_coatTemperature } grades " +
            $"and now {base.WormUp()}";
        }

    }
}
