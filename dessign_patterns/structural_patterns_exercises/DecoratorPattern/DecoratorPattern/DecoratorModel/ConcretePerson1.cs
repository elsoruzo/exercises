namespace DecoratorModel
{
    class ConcretePerson1 : WormerBaseInterface
    {
        private string _name = "Vladimir";
        private string _saysCold = "I am cold";
        private string _saysOk = "I am not cold I am Ok";
        private string _closeSize = "M";
        private double _bodyTemperature = 36.6;
        public ConcretePerson1()
        {
            Name = _name;
            CloseSize = _closeSize;
            BodyTemperature = _bodyTemperature;
        }
        public string Name;
        public string CloseSize;
        //public string Says;
        public double BodyTemperature;
        public bool IsPersonCold(double bodyTemperature)
        {
            return bodyTemperature < Constants.NormalBodyTemperature;
        }


        public void updateBodyTemperature()
        {
            BodyTemperature += base.BaseTemperature;
        }
        private string GetVladimirState() 
        {

            if (IsPersonCold(BodyTemperature))
            {
                return _saysCold;
            }
            return _saysOk;
        }
        public override string WormUp()
        {
            updateBodyTemperature();
            return $"\n The temperature of {Name}\\'s body is: {BodyTemperature:F} and {Name} says: {GetVladimirState()}";
        }

    }
}
