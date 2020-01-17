//namespace DecoratorModel
//{
//    class JumperDecorator : ClothBaseDecorator
//    {

//        private const double _jumperTemperature = 3.2;
//        public JumperDecorator(WormerBaseInterface wormer) : base(wormer)
//        {
//            wormer.BaseTemperature += _jumperTemperature;
//        }

//        public override string WormUp(double temperature)
//        {
//            return $"The {this.GetType().ToString()} is on " +
//            $"and the temperature has been incresed by {_jumperTemperature} grades " +
//            $"and now {base.WormUp()}";
//        }

//    }
//}

