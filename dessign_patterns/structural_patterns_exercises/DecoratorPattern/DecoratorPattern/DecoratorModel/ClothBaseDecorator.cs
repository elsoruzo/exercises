namespace DecoratorModel
{
    abstract class ClothBaseDecorator : WormerBaseInterface
    {
        protected WormerBaseInterface _wormer;

        public ClothBaseDecorator(WormerBaseInterface wormer)
        {
            this._wormer = wormer;
        }

        public void SetComponent(WormerBaseInterface wormer)
        {
            this._wormer = wormer;
        }
 
        // The Decorator delegates all work to the wrapped component.
        public override string WormUp(double temperature)
        {
            if (this._wormer != null)
            {
                return this._wormer.WormUp(temperature);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
