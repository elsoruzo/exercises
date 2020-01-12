namespace DecoratorModel
{
    class HouseDecorator : ClothBaseDecorator
    {

        private const double _houseTemperature = 7.2;
        public HouseDecorator(WormerBaseInterface wormer) : base(wormer)
        {
            wormer.BaseTemperature += _houseTemperature;
        }

        public override string WormUp()
        {
            return $"The {this.GetType().ToString()} is on " +
            $"and the temperature has been incresed by {_houseTemperature} grades " +
            $"and now {base.WormUp()}";
        }

    }
}

