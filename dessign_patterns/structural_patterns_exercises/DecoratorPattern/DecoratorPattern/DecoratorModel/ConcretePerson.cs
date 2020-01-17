namespace DecoratorModel
{
    class ConcretePerson : WormerBaseInterface
    {
        private string _name = "Vladimir";
        private string _saysCold = "I am cold";
        private string _saysOk = "I am not cold I am Ok";
        private string _saysIdiot = "I am not OK I am ON FIRE YOU IDIOT!!!!!";
        private string _closeSize = "M";
        private double _bodyTemperature = 36.6;
        public ConcretePerson()
        {
            Name = _name;
            CloseSize = _closeSize;
            BodyTemperature = _bodyTemperature;
        }
        public string Name;
        public string CloseSize;
        public double BodyTemperature;
        public bool IsPersonCold(double bodyTemperature)
        {
            return bodyTemperature < Constants.NormalBodyTemperature;
        }
        public bool IsPersonHot(double bodyTemperature)
        {
            return bodyTemperature > Constants.NormalBodyTemperature;
        }


        public void updateBodyTemperature(double bodyTemperature)
        {
            BodyTemperature = bodyTemperature;
        }
        private string GetVladimirState()
        {

            if (IsPersonCold(BodyTemperature))
            {
                return _saysCold;
            }

            if (IsPersonHot(BodyTemperature))
            {
                return _saysIdiot;
            }
            return _saysOk;
        }
        public override string WormUp(double bodyTemperature)
        {
            updateBodyTemperature(bodyTemperature);
            return $"\n The temperature of {Name}\\'s body is: {bodyTemperature:F} and {Name} says: {GetVladimirState()}";
        }

    }
}
