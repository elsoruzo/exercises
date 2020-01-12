namespace DecoratorModel
{
    class TshirtDecorator : ClothBaseDecorator
    {
        private const double _tshirtTemperature = 1.2;
        public TshirtDecorator(WormerBaseInterface wormer) : base(wormer)
        {
            wormer.BaseTemperature += _tshirtTemperature;
        }

        public override string WormUp()
        {
            return $"\n The {this.GetType().ToString()} is on " +
            $"and the temperature has been incresed by {_tshirtTemperature} grades " +
            $" {base.WormUp()}";
        }

    }
}

